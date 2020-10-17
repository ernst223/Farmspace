using FarmboekAPI.DTO;
using FarmboekAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Repository
{
    public class RemediesRepository
    {
        private FarmboekContext dc;
        public RemediesRepository(FarmboekContext context)
        {
            dc = context;
        }
        public List<ProductBaseDto> getAllRemedies(int brandid)
        {
            var allRemedies = dc.ProductBase.Where(o => o.BrandId == brandid).ToList();
            List<ProductBaseDto> result = new List<ProductBaseDto>();
            foreach(var entity in allRemedies)
            {
                result.Add(new ProductBaseDto()
                {
                    ProductBaseId = entity.ProductBaseId,
                    Name = entity.Name
                });
            }
            return result;
        }
        public List<ProductBaseDto> getRemedies(int problemBaseId)
        {
            var problemId = dc.Problem.Where(o => o.ProblemBaseId == problemBaseId).First().ProblemId;
            var Remedies = dc.Remedy.Where(o => o.ProblemId == problemId).ToList();
            List<ProductBase> Tempresult = new List<ProductBase>();
            foreach(var entity in Remedies)
            {
                Tempresult.Add(dc.ProductBase.Where(o => o.ProductBaseId == entity.ProductBaseId).First());
            }
            List<ProductBaseDto> result = new List<ProductBaseDto>();
            ProductImage tempProductImage;
            foreach(var entity in Tempresult)
            {
                tempProductImage = dc.ProductImage.Where(o => o.ProductBaseId == entity.ProductBaseId).FirstOrDefault();
                if(tempProductImage != null)
                {
                    result.Add(new ProductBaseDto()
                    {
                        ProductBaseId = entity.ProductBaseId,
                        Name = entity.Name,
                        Information = entity.Information,
                        Formulation = entity.Formulation,
                        Registration = entity.Registration,
                        Concentration = entity.Concentration,
                        EntryTypeId = entity.EntryTypeId,
                        BrandId = entity.BrandId,
                        Range = entity.Range,
                        BrandProductDisplay = entity.BrandProductDisplay,
                        ImageLink = dc.ListingFile.Where(o => o.ListingFileId == tempProductImage.ListingFileId).FirstOrDefault().FilePath.Substring(15)
                    });
                }
                else
                {
                    result.Add(new ProductBaseDto()
                    {
                        ProductBaseId = entity.ProductBaseId,
                        Name = entity.Name,
                        Information = entity.Information,
                        Formulation = entity.Formulation,
                        Registration = entity.Registration,
                        Concentration = entity.Concentration,
                        EntryTypeId = entity.EntryTypeId,
                        BrandId = entity.BrandId,
                        Range = entity.Range,
                        BrandProductDisplay = entity.BrandProductDisplay
                    }) ;
                }
            }
            return result;
        }

        public ProductBaseDto getRemedyById(int id)
        {
            try
            {
                var remedy = dc.ProductBase.Where(o => o.ProductBaseId == id).FirstOrDefault();
                ProductBaseDto result = new ProductBaseDto();
                ProductImage tempProductImage = dc.ProductImage.Where(o => o.ProductBaseId == remedy.ProductBaseId).FirstOrDefault();
                if(tempProductImage != null)
                {
                    result.ImageLink = dc.ListingFile.Where(o => o.ListingFileId == tempProductImage.ListingFileId).FirstOrDefault().FilePath.Substring(15);
                }
                result.ProductBaseId = remedy.ProductBaseId;
                result.Name = remedy.Name;
                result.Information = remedy.Information;
                result.Formulation = remedy.Formulation;
                result.Registration = remedy.Registration;
                result.Concentration = remedy.Concentration;
                result.EntryTypeId = remedy.EntryTypeId;
                result.BrandId = remedy.BrandId;
                result.Range = remedy.Range;
                
                return result;
            }
            catch(Exception e)
            {
                return null;
            }
        }
        public BrandDto getBrand(int id)
        {
            BrandDto result = new BrandDto();
            Brand temp = dc.Brand.Where(o => o.BrandId == id).FirstOrDefault();
            result.AccountNo = temp.AccountNo;
            result.Address = temp.Address;
            result.BrandId = temp.BrandId;
            result.ContactId = temp.ContactId;
            result.Description = temp.Description;
            result.HasPaid = temp.HasPaid;
            result.IsActive = temp.IsActive;
            result.Name = temp.Name;
            result.Summary = temp.Summary;
            return result;
        }

        public List<RemedyProblems> getRemedyProblems(int ProductBaseId)
        {
            List<RemedyProblems> result = new List<RemedyProblems>();
            var tempRemedies = dc.Remedy.Where(o => o.ProductBaseId == ProductBaseId).ToList();
            Problem tempProblem;
            Route tempRoute;
            foreach (var entity in tempRemedies)
            {
                tempProblem = dc.Problem.Where(o => o.ProblemId == entity.ProblemId).First();
                tempRoute = dc.Route.Where(o => o.RouteId == tempProblem.RouteId).First();
                result.Add(new RemedyProblems()
                {
                    RouteId = tempProblem.RouteId,
                    ProblemBaseId = tempProblem.ProblemBaseId,
                    Description = dc.Groups.Where(o => o.GroupId == tempRoute.GroupId).First().GroupName + " - "
                    + dc.SubGroups.Where(o => o.SubGroupId == tempRoute.SubGroupId).First().SubGroupName + " - "
                    + dc.ProblemBase.Where(o => o.ProblemBaseId == tempProblem.ProblemBaseId).First().Name
                });
            }
            return result;
        }

        public List<ActiveIngredientDto> GetActiveIngredient(int productId)
        {
            var temp = dc.ProductActiveIngredient.Where(o => o.ProductBaseId == productId).ToList();
            if(temp == null)
            {
                return null;
            }
            else
            {
                List<ActiveIngredientDto> result = new List<ActiveIngredientDto>();
                ActiveIngredient tempIng;
                foreach (var entity in temp)
                {
                    tempIng = dc.ActiveIngredient.Where(o => o.ActiveIngredientId == entity.ActiveIngredientId).FirstOrDefault();
                    result.Add(new ActiveIngredientDto()
                    {
                        ActiveIngredientId = tempIng.ActiveIngredientId,
                        Code = tempIng.Code,
                        Name = tempIng.Name
                    });
                }

                return result;
            }
        }

        public ReturnOnlyString ProcessRemedyFile(IFormFile theFile)
        {
            int count = 0;
            int commaCount = 0;
            int commaPointCount = 0;
            string line;
            string[] values;
            string testAuth = "";
            int amountOfUploads = -1;
            using (var ms = new MemoryStream())
            {
                theFile.CopyTo(ms);
                ms.Position = 0;

                using (var reader = new StreamReader(ms))
                {
                    while (!reader.EndOfStream)
                    {
                        amountOfUploads++;
                        line = reader.ReadLine();
                        commaCount = line.Count(f => f == ',');
                        commaPointCount = line.Count(f => f == ';');
                        if (commaCount > commaPointCount)
                        {
                            values = line.Split(',');
                        }
                        else
                        {
                            values = line.Split(';');
                        }
                        if (count == 0)
                        {
                            testAuth = TestAuthentisityRemedyFile(values);
                            if (testAuth != "")
                            {
                                return new ReturnOnlyString(testAuth, amountOfUploads);
                            }
                        }
                        else
                        {
                            if (ProcessRemedyLine(values) != true)
                            {

                                return new ReturnOnlyString("Oops something went wrong with the processing", amountOfUploads);
                            }
                        }
                        count++;
                    }
                }
            }
            return new ReturnOnlyString("Success", amountOfUploads);
        }
     
        public bool ProcessRemedyLine(string[] values)
        {
            try
            {
                var theBrand = dc.Brand.Where(o => o.Name == values[12]).First();
                var theSuperGroup = dc.SuperGroups.Where(o => o.SuperGroupName == values[1]).First().SuperGroupId;
                var theGroup = dc.Groups.Where(o => o.GroupDesc == values[2]).First().GroupId;
                var theSubGroup = dc.SubGroups.Where(o => o.SubGroupDesc == values[3]).First().SubGroupId;
                var theRoute = dc.Route.Where(o => o.SuperGroupId == theSuperGroup && o.GroupId == theGroup && o.SubGroupId == theSubGroup).First();

            //Firstly add the Remedy ProductBase
                dc.ProductBase.Add(new ProductBase()
                {
                    Name = values[10],
                    Information = "",
                    Formulation = values[8],
                    Registration = values[11],
                    Concentration = values[9],
                    Range = values[13],
                    BrandId = theBrand.BrandId,
                    EntryTypeId = 4
                });
                dc.SaveChanges();

                var tempProductBase = dc.ProductBase.OrderByDescending(o => o.ProductBaseId).First();
                // Adding into Product
                if(values[0] == "Browse By")
                {
                dc.Product.Add(new Product()
                {
                    ProductBaseId = tempProductBase.ProductBaseId,
                    ProductBase = tempProductBase,
                    RouteId = theRoute.RouteId,
                    Route = theRoute,
                    MenuTypeId = 2
                });
                }else if(values[0] == "Info")
                {
                    dc.Product.Add(new Product()
                    {
                        ProductBaseId = tempProductBase.ProductBaseId,
                        ProductBase = tempProductBase,
                        RouteId = theRoute.RouteId,
                        Route = theRoute,
                        MenuTypeId = 1
                    });
                }
                else
                {
                    dc.Product.Add(new Product()
                    {
                        ProductBaseId = tempProductBase.ProductBaseId,
                        ProductBase = tempProductBase,
                        RouteId = theRoute.RouteId,
                        Route = theRoute,
                        MenuTypeId = 2
                    });
                }
                

                //Now adding the active ingredients
                ActiveIngredient tempActive;
                for(int i = 4; i <= 7; i++)
                {
                  if(values[i] != "")
                {
                    tempActive = dc.ActiveIngredient.Where(o => o.Name == values[i]).FirstOrDefault();
                    if (tempActive == null)
                    {
                        dc.ActiveIngredient.Add(new ActiveIngredient()
                        {
                            Code = values[i].ToUpper(),
                            Name = values[i]
                        });
                        dc.SaveChanges();
                        tempActive = dc.ActiveIngredient.OrderByDescending(o => o.ActiveIngredientId).First();

                        dc.ProductActiveIngredient.Add(new ProductActiveIngredient()
                        {
                            ProductBase = tempProductBase,
                            ProductBaseId = tempProductBase.ProductBaseId,
                            ActiveIngredient = tempActive,
                            ActiveIngredientId = tempActive.ActiveIngredientId
                        });
                    }
                    else
                    {
                        dc.ProductActiveIngredient.Add(new ProductActiveIngredient()
                        {
                            ProductBase = tempProductBase,
                            ProductBaseId = tempProductBase.ProductBaseId,
                            ActiveIngredient = tempActive,
                            ActiveIngredientId = tempActive.ActiveIngredientId
                        });
                    }
                }
                }
                dc.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("CUSTOM LOG: " + e);
                return false;
            }
        }
        public string TestAuthentisityRemedyFile(string[] values)
        {
            if (values[0] != "MainMenu")
            {
                return "Column MainMenu is not Found";
            }
            if (values[1] != "Supergroup")
            {
                return "Column Supergroup is not Found";
            }
            if (values[2] != "Industry")
            {
                return "Column Industry is not Found";
            }
            if (values[3] != "Division")
            {
                return "Column Division is not Found";
            }
            if (values[4] != "Active1")
            {
                return "Column Active1 is not Found";
            }
            if (values[5] != "Active2")
            {
                return "Column Active2 is not Found";
            }
            if (values[6] != "Active3")
            {
                return "Column Active3 is not Found";
            }
            if (values[7] != "Active4")
            {
                return "Column Active4 is not Found";
            }
            if (values[8] != "Formulation")
            {
                return "Column Fomulation is not Found";
            }
            if (values[9] != "Concentration")
            {
                return "Column Concentration is not Found";
            }
            if (values[10] != "ProductName")
            {
                return "Column ProductName is not Found";
            }
            if (values[11] != "Registration")
            {
                return "Column Registration is not Found";
            }
            if (values[12] != "Brand")
            {
                return "Column Brand is not Found";
            }
            if (values[13] != "Range")
            {
                return "Column Range is not Found";
            }
            return "";
        }

        public List<RemedyForDisplayDto> getRemediesForDisplay()
        {
            try
            {
                var tempProductBaseList = dc.ProductBase.OrderByDescending(o => o.ProductBaseId).Include(p => p.Brand).Take(100).ToList();
                List<RemedyForDisplayDto> result = new List<RemedyForDisplayDto>();
                foreach (var entity in tempProductBaseList)
                {
                    result.Add(new RemedyForDisplayDto()
                    {
                        ProductBaseId = entity.ProductBaseId,
                        ProductName = entity.Name,
                        Brand = entity.Brand.Name,
                        BrandId = entity.Brand.BrandId,
                        Concentration = entity.Concentration,
                        Formulation = entity.Formulation,
                        Range = entity.Range,
                        Registration = entity.Registration
                    });
                }
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<RemedyForDisplayDto> getLatestRemediesForDisplay(int amount)
        {
            try
            {
                var tempProductBaseList = dc.ProductBase.OrderByDescending(o => o.ProductBaseId).Include(p => p.Brand).Take(amount).ToList();
                List<RemedyForDisplayDto> result = new List<RemedyForDisplayDto>();
                foreach (var entity in tempProductBaseList)
                {
                    result.Add(new RemedyForDisplayDto()
                    {
                        ProductBaseId = entity.ProductBaseId,
                        ProductName = entity.Name,
                        Brand = entity.Brand.Name,
                        BrandId = entity.Brand.BrandId,
                        Concentration = entity.Concentration,
                        Formulation = entity.Formulation,
                        Range = entity.Range,
                        Registration = entity.Registration
                    });
                }
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool deleteRemedies(DeleteByIdDto T)
        {
            try
            {
                List<ProductActiveIngredient> tempActive;
                foreach(var entity in T.Id)
                {
                    dc.ProductBase.Remove(dc.ProductBase.Where(o => o.ProductBaseId == entity).First());
                    dc.Product.Remove(dc.Product.Where(o => o.ProductBaseId == entity).First());
                    tempActive = dc.ProductActiveIngredient.Where(o => o.ProductBaseId == entity).ToList();
                    foreach (var subentity in tempActive)
                    {
                        dc.ProductActiveIngredient.Remove(subentity);
                    }
                }
                dc.SaveChanges();
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }
    }
}
