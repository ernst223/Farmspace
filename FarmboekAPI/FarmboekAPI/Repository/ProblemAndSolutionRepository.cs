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
    public class ProblemAndSolutionRepository
    {
        private FarmboekContext dc;
        public ProblemAndSolutionRepository(FarmboekContext context)
        {
            dc = context;
        }
        
        public List<SuperGroups> getSuperGroups()
        {
            var result = dc.SuperGroups.Where(o => o.IsInformation == true).OrderBy(o => o.SuperGroupName).ToList();
            return result;
        }

        public List<GroupsDto> getGroups(int id)
        {
            var routes = dc.Route.Where(o => o.SuperGroupId == id).ToList();
            if(routes != null)
            {
                List<GroupsDto> result = new List<GroupsDto>();
                Groups temp;
                foreach (var entity in routes)
                {
                    temp = dc.Groups.Where(o => o.GroupId == entity.GroupId & o.IsInformation == true).FirstOrDefault();
                    if(temp != null)
                    {
                        if(result.Where(p => p.GroupId == temp.GroupId).FirstOrDefault() == null)
                        {
                            result.Add(new GroupsDto()
                            {
                                GroupId = temp.GroupId,
                                GroupDesc = temp.GroupDesc,
                                GroupName = temp.GroupName,
                                IsInformation = temp.IsInformation,
                                IsCommercial = temp.IsCommercial
                            });
                        }
                    }
                }
                return result.OrderBy(o => o.GroupName).ToList();
            }
            else
            {
                return null;
            }
        }

        public List<SubGroupsDto> getSubGroups(int id)
        {
            var routes = dc.Route.Where(o => o.GroupId == id).ToList();
            if (routes != null)
            {
                List<SubGroupsDto> result = new List<SubGroupsDto>();
                SubGroups temp;
                foreach (var entity in routes)
                {
                    temp = dc.SubGroups.Where(o => o.SubGroupId == entity.SubGroupId & o.IsInformation == true).FirstOrDefault();
                    if (temp != null)
                    {
                        if (result.Where(p => p.SubGroupId == temp.SubGroupId).FirstOrDefault() == null)
                        {
                            result.Add(new SubGroupsDto()
                            {
                                SubGroupId = temp.SubGroupId,
                                SubGroupDesc = temp.SubGroupDesc,
                                SubGroupName = temp.SubGroupName,
                                IsInformation = temp.IsInformation,
                                IsCommercial = temp.IsCommercial
                            });
                        }
                    }
                }
                return result.OrderBy(o => o.SubGroupName).ToList();
            }
            else
            {
                return null;
            }
        }

        public List<RouteProblemDto> getProblemsFromRoute(int supergroup, int group, int subgroup)
        {
            var RouteId = dc.Route.Where(o => o.SuperGroupId == supergroup && o.GroupId == group && o.SubGroupId == subgroup).First().RouteId;
            var myProblems = dc.Problem.Where(o => o.RouteId == RouteId).ToList();
            if (myProblems != null)
            {
                List<RouteProblemDto> Result = new List<RouteProblemDto>();
                ProblemBase temp;
                ProblemImage tempImage;
                foreach(var entity in myProblems)
                {
                    temp = dc.ProblemBase.Where(o => o.ProblemBaseId == entity.ProblemBaseId).FirstOrDefault();
                    tempImage = dc.ProblemImage.Where(o => o.ProblemBaseId == entity.ProblemBaseId).FirstOrDefault();
                    if(temp != null)
                    {
                        if(tempImage != null)
                        {
                            Result.Add(new RouteProblemDto()
                            {
                                ProblemBaseId = temp.ProblemBaseId,
                                Name = temp.Name,
                                Information = temp.Information,
                                Symptoms = temp.Symptoms,
                                Morbidity = temp.Morbidity,
                                Epidemiology = temp.Epidemiology,
                                EntryTypeId = temp.EntryTypeId,
                                ImageLink = dc.ListingFile.Where(o => o.ListingFileId == tempImage.ListingFileId).FirstOrDefault().FilePath.Substring(15),
                            });
                        }
                        else
                        {
                            Result.Add(new RouteProblemDto()
                            {
                                ProblemBaseId = temp.ProblemBaseId,
                                Name = temp.Name,
                                Information = temp.Information,
                                Symptoms = temp.Symptoms,
                                Morbidity = temp.Morbidity,
                                Epidemiology = temp.Epidemiology,
                                EntryTypeId = temp.EntryTypeId,
                                ImageLink = "No_image_3x4.svg.png",
                            });
                        }
                    }
                }
                return Result.OrderBy(o => o.Name).ToList();
            }
            else
            {
                return null;
            }
        }
        public RouteProblemDto getRouteProblemFromStrings(string supergroup, string group, string subgroup, string problemname)
        {
            try
            {
                RouteProblemDto result = new RouteProblemDto();
                var dbSupergroup = dc.SuperGroups.Where(o => o.SuperGroupName == supergroup).First();
                var dbGroup = dc.Groups.Where(o => o.GroupName == group).First();
                var dbSubGroup = dc.SubGroups.Where(o => o.SubGroupName == subgroup).First();
                var route = dc.Route.Where(o => o.SuperGroupId == dbSupergroup.SuperGroupId && o.GroupId == dbGroup.GroupId && o.SubGroupId == dbSubGroup.SubGroupId).First();
                var PotentialProblems = dc.ProblemBase.Where(o => o.Name == problemname).ToList();

                Problem tempProblem;
                Problem problemResult = null;
                foreach(var entity in PotentialProblems)
                {
                    tempProblem = dc.Problem.Where(o => o.ProblemBaseId == entity.ProblemBaseId && o.RouteId == route.RouteId).FirstOrDefault();
                    if(tempProblem != null)
                    {
                        problemResult = tempProblem;
                    }
                }
                result = getRouteProblemFromId(problemResult.ProblemBaseId);
                return result;
            }catch(Exception e)
            {
                return null;
            }
        }
        public ProblemDetailsForSeoDto getProblembaseDetailsSeo(int id)
        {
            try
            {
                ProblemDetailsForSeoDto result = new ProblemDetailsForSeoDto();
                var Problem = dc.Problem.Include(p => p.Route).ThenInclude(k => k.SuperGroup).Include(p => p.Route.Group).Include(p => p.Route.SubGroup).Where(o => o.ProblemBaseId == id).First();
                result.Supergroup = Problem.Route.SuperGroup.SuperGroupName;
                result.Group = Problem.Route.Group.GroupName;
                result.Subgroup = Problem.Route.SubGroup.SubGroupName;
                result.ProblemBaseId = id;
                result.Problemname = dc.ProblemBase.Where(o => o.ProblemBaseId == id).First().Name;
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public RouteProblemDto getRouteProblemFromId(int problemBaseId)
        {
            var tempProblem = dc.ProblemBase.Where(o => o.ProblemBaseId == problemBaseId).FirstOrDefault();
            RouteProblemDto result = new RouteProblemDto();
            var tempImage = dc.ProblemImage.Where(o => o.ProblemBaseId == problemBaseId).FirstOrDefault();
            if (tempProblem != null)
            {
                if(tempImage != null)
                {
                    result.EntryTypeId = tempProblem.EntryTypeId;
                    result.Epidemiology = tempProblem.Epidemiology;
                    result.ImageLink = dc.ListingFile.Where(o => o.ListingFileId == tempImage.ListingFileId).FirstOrDefault().FilePath.Substring(15);
                    result.Information = tempProblem.Information;
                    result.Morbidity = tempProblem.Morbidity;
                    result.Name = tempProblem.Name;
                    result.ProblemBaseId = tempProblem.ProblemBaseId;
                    result.Symptoms = tempProblem.Symptoms;
                }
                else
                {
                    result.EntryTypeId = tempProblem.EntryTypeId;
                    result.Epidemiology = tempProblem.Epidemiology;
                    result.ImageLink = "No_image_3x4.svg.png";
                    result.Information = tempProblem.Information;
                    result.Morbidity = tempProblem.Morbidity;
                    result.Name = tempProblem.Name;
                    result.ProblemBaseId = tempProblem.ProblemBaseId;
                    result.Symptoms = tempProblem.Symptoms;
                }
                return result;
            }
            else
            {
                return null;
            }
        }
        public List<string> getProblemsFromRouteImages(int id)
        {
            var problemImages = dc.ProblemImage.Where(o => o.ProblemBaseId == id).ToList();
            List<string> result = new List<string>();
            foreach(var entity in problemImages)
            {
                result.Add(dc.ListingFile.Where(o => o.ListingFileId == entity.ListingFileId).FirstOrDefault().FilePath.Substring(15));
            }
            return result;
        }


        public List<ProblemForDisplayDto> GetProblemBaseForDisplay()
        {
            try
            {
                List<ProblemForDisplayDto> result = new List<ProblemForDisplayDto>();
                var tempProblems = dc.ProblemBase.OrderByDescending(o => o.ProblemBaseId).Take(100).ToList();
                foreach(var entity in tempProblems)
                {
                    result.Add(new ProblemForDisplayDto()
                    {
                        ProblemBaseId = entity.ProblemBaseId,
                        Name = entity.Name,
                        Information = entity.Information.Substring(0,6) + "...",
                        Symptoms = entity.Symptoms.Substring(0, 6) + "...",
                        Morbidiy = entity.Morbidity.Substring(0, 6) + "...",
                        Epidemiology = entity.Epidemiology.Substring(0, 6) + "..."
                    });
                }
                return result.OrderBy(o => o.Name).ToList();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public List<ProblemForDisplayDto> GetProblemBaseForDisplay(int amount)
        {
            try
            {
                List<ProblemForDisplayDto> result = new List<ProblemForDisplayDto>();
                var tempProblems = dc.ProblemBase.OrderByDescending(o => o.ProblemBaseId).Take(amount).ToList();
                foreach (var entity in tempProblems)
                {
                    result.Add(new ProblemForDisplayDto()
                    {
                        ProblemBaseId = entity.ProblemBaseId,
                        Name = entity.Name,
                        Information = entity.Information.Substring(0, 6) + "...",
                        Symptoms = entity.Symptoms.Substring(0, 6) + "...",
                        Morbidiy = entity.Morbidity.Substring(0, 6) + "...",
                        Epidemiology = entity.Epidemiology.Substring(0, 6) + "..."
                    });
                }
                return result.OrderBy(o => o.Name).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public int addSuperGroupForInformation(string desc)
        {
            try
            {
                //First Adding the Supergroup
                dc.SuperGroups.Add(new SuperGroups()
                {
                    SuperGroupName = desc,
                    SuperGroupDesc = desc,
                    IsCommercial = false,
                    IsInformation = true,
                });
                dc.SaveChanges();

                //Now adding to Route and return superGroupId
                var temp = dc.SuperGroups.OrderByDescending(o => o.SuperGroupId).First();
                dc.Route.Add(new Route()
                {
                    SuperGroup = temp,
                    SuperGroupId = temp.SuperGroupId
                });
                dc.SaveChanges();

                return temp.SuperGroupId;
            }
            catch
            {
                return 0;
            }
        }
        public int addGroupForInformation(string desc, int SuperGroupId)
        {
            try
            {
                //First trying to find the Route
                var route = dc.Route.Where(o => o.SuperGroupId == SuperGroupId && o.GroupId == null).FirstOrDefault();

                //If does not exist create a new Route
                if (route == null)
                {
                    var TempSuperGroup = dc.SuperGroups.Where(o => o.SuperGroupId == SuperGroupId).First();
                    dc.Route.Add(new Route()
                    {
                        SuperGroup = TempSuperGroup,
                        SuperGroupId = SuperGroupId
                    });
                    dc.SaveChanges();
                    route = dc.Route.Where(o => o.SuperGroupId == SuperGroupId && o.GroupId == null).First();
                }

                //Adding the Group and add Id to the Route
                dc.Groups.Add(new Groups()
                {
                    GroupDesc = desc,
                    GroupName = desc,
                    IsCommercial = false,
                    IsInformation = true
                });
                dc.SaveChanges();

                var temp = dc.Groups.OrderByDescending(o => o.GroupId).First();

                route.Group = temp;
                route.GroupId = temp.GroupId;
                dc.SaveChanges();

                //Adding to GroupSuperGroups
                dc.GroupSuperGroups.Add(new GroupSuperGroups()
                {
                    SuperGroupId = SuperGroupId,
                    GroupId = temp.GroupId
                });
                return temp.GroupId;
            }
            catch
            {
                return 0;
            }
        }

        public int addSubGroupForInformation(string desc, int SuperGroupId, int GroupId)
        {
            try
            {
                //First trying to find the Route
                var route = dc.Route.Where(o => o.SuperGroupId == SuperGroupId && o.GroupId == GroupId && o.SubGroupId == null).FirstOrDefault();

                //If does not exist create a new Route
                if (route == null)
                {
                    var TempSuperGroup = dc.SuperGroups.Where(o => o.SuperGroupId == SuperGroupId).First();
                    var TempGroup = dc.Groups.Where(o => o.GroupId == GroupId).First();
                    dc.Route.Add(new Route()
                    {
                        SuperGroup = TempSuperGroup,
                        SuperGroupId = SuperGroupId,
                        Group = TempGroup,
                        GroupId = GroupId
                    });
                    dc.SaveChanges();
                    route = dc.Route.Where(o => o.SuperGroupId == SuperGroupId && o.GroupId == null).First();
                }

                //Adding the Group and add Id to the Route
                dc.SubGroups.Add(new SubGroups()
                {
                    SubGroupName = desc,
                    SubGroupDesc = desc,
                    IsCommercial = false,
                    IsInformation = true
                });
                dc.SaveChanges();

                var temp = dc.SubGroups.OrderByDescending(o => o.SubGroupId).First();

                route.SubGroup = temp;
                route.SubGroupId = temp.SubGroupId;
                dc.SaveChanges();

                //Adding to GroupSuperGroups
                dc.GroupSubGroups.Add(new GroupSubGroups()
                {
                    SubGroupId = temp.SubGroupId,
                    GroupId = GroupId
                });
                return temp.SubGroupId;
            }
            catch
            {
                return 0;
            }
        }

        public bool deleteSubGroup(int id)
        {
            try
            {
                var tempSubGroup = dc.SubGroups.Where(o => o.SubGroupId == id).FirstOrDefault();
                var tempRoutes = dc.Route.Where(o => o.SubGroupId == id).ToList();
                var tempGroupSubGroup = dc.GroupSubGroups.Where(o => o.SubGroupId == id).ToList();
                foreach (var entity in tempGroupSubGroup)
                {
                    dc.GroupSubGroups.Remove(entity);
                }
                foreach (var entity in tempRoutes)
                {
                    entity.SubGroupId = null;
                    entity.SubGroup = null;
                    dc.SaveChanges();
                }
                dc.SubGroups.Remove(tempSubGroup);
                dc.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteGroup(int id)
        {
            try
            {
                var tempGroup = dc.Groups.Where(o => o.GroupId == id).FirstOrDefault();
                var tempRoute = dc.Route.Where(o => o.GroupId == id).ToList();
                var tempGroupSubGroup = dc.GroupSubGroups.Where(o => o.GroupId == id).ToList();
                var tempGroupSuperGroup = dc.GroupSuperGroups.Where(o => o.GroupId == id).ToList();
                foreach (var entity in tempGroupSubGroup)
                {
                    dc.GroupSubGroups.Remove(entity);
                }
                foreach (var entity in tempGroupSuperGroup)
                {
                    dc.GroupSuperGroups.Remove(entity);
                }

                SubGroups tempSubGroupToDelete;
                foreach (var entity in tempRoute)
                {
                    tempSubGroupToDelete = dc.SubGroups.Where(o => o.SubGroupId == entity.SubGroupId).FirstOrDefault();
                    if (tempSubGroupToDelete != null)
                    {
                        dc.SubGroups.Remove(tempSubGroupToDelete);
                    }
                    entity.GroupId = null;
                    entity.Group = null;
                    entity.SubGroup = null;
                    entity.SubGroupId = null;
                    dc.SaveChanges();
                }
                dc.Groups.Remove(tempGroup);
                dc.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteSupterGroup(int id)
        {
            try
            {
                var tempSuperGroup = dc.SuperGroups.Where(o => o.SuperGroupId == id).FirstOrDefault();
                var tempRoutes = dc.Route.Where(o => o.SuperGroupId == id).ToList();
                var tempGroupSuperGroup = dc.GroupSuperGroups.Where(o => o.SuperGroupId == id).ToList();

                Groups tempGroupToDelete;
                SubGroups temSubGroupsToDelelte;
                foreach (var entity in tempRoutes)
                {
                    tempGroupToDelete = dc.Groups.Where(o => o.GroupId == entity.GroupId).FirstOrDefault();
                    temSubGroupsToDelelte = dc.SubGroups.Where(o => o.SubGroupId == entity.SubGroupId).FirstOrDefault();
                    if (temSubGroupsToDelelte != null)
                    {
                        dc.SubGroups.Remove(temSubGroupsToDelelte);
                    }
                    if (tempGroupToDelete != null)
                    {
                        dc.Groups.Remove(tempGroupToDelete);
                    }
                    dc.Route.Remove(entity);
                }
                foreach (var entity in tempGroupSuperGroup)
                {
                    dc.GroupSuperGroups.Remove(entity);
                }
                dc.SuperGroups.Remove(tempSuperGroup);
                dc.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        //administration section
        public ReturnOnlyString ProcessProblemFile(IFormFile theFile)
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
                            testAuth = TestAuthentisityProblemFile(values);
                            if (testAuth != "")
                            {
                                return new ReturnOnlyString(testAuth, amountOfUploads);
                            }
                        }
                        else
                        {
                            if (ProcessProblemLine(values) != true)
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

        public bool ProcessProblemLine(string[] values)
        {
            try
            {
                var theBrand = dc.Brand.Where(o => o.Name == values[10]).First();
                var theSuperGroup = dc.SuperGroups.Where(o => o.SuperGroupName == values[1]).First().SuperGroupId;
                var theGroup = dc.Groups.Where(o => o.GroupDesc == values[2]).First().GroupId;
                var theSubGroup = dc.SubGroups.Where(o => o.SubGroupDesc == values[3]).First().SubGroupId;
                var theRoute = dc.Route.Where(o => o.SuperGroupId == theSuperGroup && o.GroupId == theGroup && o.SubGroupId == theSubGroup).First();
                var ProblemBase = dc.ProblemBase.Where(o => o.Name == values[4]).FirstOrDefault();
                var ProductBase = dc.ProductBase.Where(o => o.Name == values[9]).FirstOrDefault();

                if(ProblemBase == null)
                {
                    //add Problem and remedy link
                    dc.ProblemBase.Add(new ProblemBase()
                    {
                        Name = values[4],
                        Information = values[5],
                        Symptoms = values[6],
                        Morbidity = values[7],
                        Epidemiology = values[8]
                    });
                    dc.SaveChanges();
                    var latestProblemBase = dc.ProblemBase.OrderByDescending(o => o.ProblemBaseId).First();

                    dc.Problem.Add(new Problem()
                    {
                        ProblemBaseId = latestProblemBase.ProblemBaseId,
                        MenuTypeId = 2,
                        RouteId = theRoute.RouteId
                    });
                    dc.SaveChanges();
                    var latestProblem = dc.Problem.OrderByDescending(o => o.ProblemId).First();
                    //Now adding the Link to a remedy
                    dc.Remedy.Add(new Remedy()
                    {
                        ProblemId = latestProblem.ProblemId,
                        ProductBaseId = ProductBase.ProductBaseId
                    });
                    dc.SaveChanges();
                }
                else
                {
                    //add remedy link
                    var latestProblem = dc.Problem.Where(o => o.ProblemBaseId == ProblemBase.ProblemBaseId).First();
                    dc.Remedy.Add(new Remedy()
                    {
                        ProblemId = latestProblem.ProblemId,
                        ProductBaseId = ProductBase.ProductBaseId
                    });
                    dc.SaveChanges();
                }
                
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("CUSTOM LOG: " + e);
                return false;
            }
        }

        public string TestAuthentisityProblemFile(string[] values)
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
            if (values[4] != "Problem")
            {
                return "Column Active1 is not Found";
            }
            if (values[5] != "Information")
            {
                return "Column Active2 is not Found";
            }
            if (values[6] != "Symptoms")
            {
                return "Column Active3 is not Found";
            }
            if (values[7] != "Morbidity")
            {
                return "Column Active4 is not Found";
            }
            if (values[8] != "Epidemiology")
            {
                return "Column Fomulation is not Found";
            }
            if (values[9] != "ProductName")
            {
                return "Column Concentration is not Found";
            }
            if (values[10] != "Brand")
            {
                return "Column ProductName is not Found";
            }
            if (values[11] != "RemedyType")
            {
                return "Column Registration is not Found";
            }
            if (values[12] != "ProblemType")
            {
                return "Column Brand is not Found";
            }
            return "";
        }


        //Displaying
        public List<ProblemForDisplayDto> getProblemForDisplay()
        {
            try
            {
                var tempProblem = dc.ProblemBase.OrderByDescending(o => o.ProblemBaseId).Include(p => p.Problem).Take(100).ToList();
                List<ProblemForDisplayDto> result = new List<ProblemForDisplayDto>();
                foreach (var entity in tempProblem)
                {
                    result.Add(new ProblemForDisplayDto()
                    {
                        Name = entity.Name,
                        Information = entity.Information,
                        Symptoms = entity.Symptoms,
                        Morbidiy = entity.Morbidity,
                        Epidemiology = entity.Epidemiology
                    });
                }
                return result.OrderBy(o => o.Name).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<ProblemForDisplayDto> getLatestProblemForDisplay(int amount)
        {
            try
            {
                var tempProblem = dc.ProblemBase.OrderByDescending(o => o.ProblemBaseId).Include(p => p.Problem).Take(amount).ToList();
                List<ProblemForDisplayDto> result = new List<ProblemForDisplayDto>();
                foreach (var entity in tempProblem)
                {
                    result.Add(new ProblemForDisplayDto()
                    {
                        Name = entity.Name,
                        Information = entity.Information,
                        Symptoms = entity.Symptoms,
                        Morbidiy = entity.Morbidity,
                        Epidemiology = entity.Epidemiology
                    });
                }
                return result.OrderBy(o => o.Name).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool deleteProblem(DeleteByIdDto T)
        {
            try
            {
                foreach (var entity in T.Id)
                {
                    dc.ProblemBase.Remove(dc.ProblemBase.Where(o => o.ProblemBaseId == entity).First());
                    dc.Problem.Remove(dc.Problem.Where(o => o.ProblemBaseId == entity).First());
                }
                dc.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
