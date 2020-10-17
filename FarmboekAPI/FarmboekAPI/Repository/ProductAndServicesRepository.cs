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
    public class ProductAndServicesRepository
    {
        private FarmboekContext dc;
        public ProductAndServicesRepository(FarmboekContext context)
        {
            dc = context;
        }
        public int addSuperGroupFomCommercial(string desc)
        {
            try
            {
                //First Adding the Supergroup
                dc.SuperGroups.Add(new SuperGroups()
                {
                    SuperGroupName = desc,
                    SuperGroupDesc = desc,
                    IsCommercial = true,
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
        public int addGroupForCommercial(string desc, int SuperGroupId)
        {
            try
            {
                //First trying to find the Route
                var route = dc.Route.Where(o => o.SuperGroupId == SuperGroupId && o.GroupId == null).FirstOrDefault();

                //If does not exist create a new Route
                if(route == null)
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
                    IsCommercial = true,
                    IsInformation = false
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

        public int addSubGroupForCommercial(string desc, int SuperGroupId, int GroupId)
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
                    IsCommercial = true,
                    IsInformation = false
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
                foreach(var entity in tempGroupSubGroup)
                {
                    dc.GroupSubGroups.Remove(entity);
                }
                foreach(var entity in tempRoutes)
                {
                    entity.SubGroupId = null;
                    entity.SubGroup = null;
                    dc.SaveChanges();
                }
                dc.SubGroups.Remove(tempSubGroup);
                dc.SaveChanges();
                return true;
            }catch
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
                foreach(var entity in tempGroupSubGroup)
                {
                    dc.GroupSubGroups.Remove(entity);
                }
                foreach(var entity in tempGroupSuperGroup)
                {
                    dc.GroupSuperGroups.Remove(entity);
                }

                SubGroups tempSubGroupToDelete;
                foreach(var entity in tempRoute)
                {
                    tempSubGroupToDelete = dc.SubGroups.Where(o => o.SubGroupId == entity.SubGroupId).FirstOrDefault();
                    if(tempSubGroupToDelete != null)
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
                foreach(var entity in tempRoutes)
                {
                    tempGroupToDelete = dc.Groups.Where(o => o.GroupId == entity.GroupId).FirstOrDefault();
                    temSubGroupsToDelelte = dc.SubGroups.Where(o => o.SubGroupId == entity.SubGroupId).FirstOrDefault();
                    if(temSubGroupsToDelelte != null)
                    {
                        dc.SubGroups.Remove(temSubGroupsToDelelte);
                    }
                    if(tempGroupToDelete != null)
                    {
                        dc.Groups.Remove(tempGroupToDelete);
                    }
                    dc.Route.Remove(entity);
                }
                foreach(var entity in tempGroupSuperGroup)
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
        public List<SuperGroups> getSuperGroups()
        {
            return dc.SuperGroups.Where(o => o.IsCommercial == true).OrderBy(a => a.SuperGroupName).ToList();
        }
        public List<GroupsDto> getGroups(int id)
        {
            var routes = dc.Route.Where(o => o.SuperGroupId == id).ToList();
            if (routes != null)
            {
                List<GroupsDto> result = new List<GroupsDto>();
                Groups temp;
                foreach (var entity in routes)
                {
                    temp = dc.Groups.Where(o => o.GroupId == entity.GroupId & o.IsCommercial == true).FirstOrDefault();
                    if (temp != null)
                    {
                        if (result.Where(p => p.GroupId == temp.GroupId).FirstOrDefault() == null)
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

        public List<EntryDto> getAllEntries(int brandid)
        {
            var tempResult = dc.Entry.Where(o => o.BrandId == brandid).ToList();
            List<EntryDto> result = new List<EntryDto>();
            foreach(var entity in tempResult)
            {
                result.Add(new EntryDto()
                {
                    EntryId = entity.EntryId,
                    Name = entity.Name
                });
            }
            return result.OrderBy(o => o.Name).ToList();
        }
        public List<SubGroupsDto> getSubGroups(int supergroupId, int groupId)
        {
            var routes = dc.Route.Where(o => o.GroupId == groupId).ToList();
            if (routes != null)
            {
                List<SubGroupsDto> result = new List<SubGroupsDto>();
                SubGroups temp;
                Route tempRoute;
                foreach (var entity in routes)
                {
                    temp = dc.SubGroups.Where(o => o.SubGroupId == entity.SubGroupId & o.IsCommercial == true).FirstOrDefault();
                    if (temp != null)
                    {
                        // Testing Subgroup if have a result else dont add
                        tempRoute = dc.Route.Where(o => o.SuperGroupId == supergroupId && o.GroupId == groupId && o.SubGroupId == temp.SubGroupId).FirstOrDefault();
                        if (tempRoute != null)
                        {
                            if(dc.EntryHeader.Where(o => o.RouteId == tempRoute.RouteId).FirstOrDefault() != null)
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
                    }
                }
                return result.OrderBy(o => o.SubGroupName).ToList();
            }
            else
            {
                return null;
            }
        }
        public List<EntryDto> getEntries (int supergroup, int group, int subgroup)
        {
            var RouteId = dc.Route.Where(o => o.SuperGroupId == supergroup && o.GroupId == group && o.SubGroupId == subgroup).First().RouteId;
            var EntryHeader = dc.EntryHeader.Where(o => o.RouteId == RouteId).ToList();
            List<EntryDto> result = new List<EntryDto>();
            Entry tempEntry;
            EntryImage tempImage;
            foreach(var entity in EntryHeader)
            {
                tempEntry = dc.Entry.Where(o => o.EntryId == entity.EntryId).First();
                tempImage = dc.EntryImage.Where(o => o.EntryId == entity.EntryId).FirstOrDefault();
                if(tempImage != null)
                {
                    result.Add(new EntryDto()
                    {
                        EntryId = tempEntry.EntryId,
                        Name = tempEntry.Name,
                        IsBrowseBy = tempEntry.IsBrowseBy,
                        IsInfo = tempEntry.IsInfo,
                        Brand = dc.Brand.Where(o => o.BrandId == tempEntry.BrandId).First().Name,
                        BrandId = tempEntry.BrandId,
                        EntryTypeTemplateId = tempEntry.EntryTypeTemplateId,
                        Range = tempEntry.Range,
                        ImageLink = dc.ListingFile.Where(o => o.ListingFileId == tempImage.ListingFileId).FirstOrDefault().FilePath.Substring(15),
                    });
                }
                else
                {
                    result.Add(new EntryDto()
                    {
                        EntryId = tempEntry.EntryId,
                        Name = tempEntry.Name,
                        IsBrowseBy = tempEntry.IsBrowseBy,
                        IsInfo = tempEntry.IsInfo,
                        Brand = dc.Brand.Where(o => o.BrandId == tempEntry.BrandId).First().Name,
                        BrandId = tempEntry.BrandId,
                        EntryTypeTemplateId = tempEntry.EntryTypeTemplateId,
                        Range = tempEntry.Range,
                        ImageLink = "",
                    });
                }
            }
            return result.OrderBy(o => o.Name).ToList();
        }
        public List<EntryDto> getEntriesByTerm(string term)
        {
            var temp = dc.Entry.Include(a => a.Brand).Where(a => a.Name.Contains(term) || a.Brand.Name.Contains(term)).ToList();
            List<EntryDto> result = new List<EntryDto>();
            EntryImage tempImage;
            foreach (var tempEntry in temp)
            {
                tempImage = dc.EntryImage.Where(o => o.EntryId == tempEntry.EntryId).FirstOrDefault();
                if (tempImage != null)
                {
                    result.Add(new EntryDto()
                    {
                        EntryId = tempEntry.EntryId,
                        Name = tempEntry.Name,
                        IsBrowseBy = tempEntry.IsBrowseBy,
                        IsInfo = tempEntry.IsInfo,
                        Brand = dc.Brand.Where(o => o.BrandId == tempEntry.BrandId).First().Name,
                        BrandId = tempEntry.BrandId,
                        EntryTypeTemplateId = tempEntry.EntryTypeTemplateId,
                        Range = tempEntry.Range,
                        ImageLink = dc.ListingFile.Where(o => o.ListingFileId == tempImage.ListingFileId).FirstOrDefault().FilePath.Substring(15),
                    });
                }
                else
                {
                    result.Add(new EntryDto()
                    {
                        EntryId = tempEntry.EntryId,
                        Name = tempEntry.Name,
                        IsBrowseBy = tempEntry.IsBrowseBy,
                        IsInfo = tempEntry.IsInfo,
                        Brand = dc.Brand.Where(o => o.BrandId == tempEntry.BrandId).First().Name,
                        BrandId = tempEntry.BrandId,
                        EntryTypeTemplateId = tempEntry.EntryTypeTemplateId,
                        Range = tempEntry.Range,
                        ImageLink = "",
                    });
                }
            }
            return result.OrderBy(o => o.Name).ToList();
        }
        public EntryRouteDto getEntryRoute(int id)
        {
            try
            {
                var myEntry = dc.Entry.Include(a => a.Brand).Where(o => o.EntryId == id).First();
                var myEntryHeader = dc.EntryHeader.Include(a => a.Route).Include(a => a.Route.SuperGroup).Include(a => a.Route.Group).Include(a => a.Route.SubGroup).Where(a => a.EntryId == id).First();
                EntryRouteDto result = new EntryRouteDto();
                result.Brand = myEntry.Brand.Name;
                result.ProductName = myEntry.Name;
                result.SuperGroup = myEntryHeader.Route.SuperGroup.SuperGroupName;
                result.Group = myEntryHeader.Route.Group.GroupName;
                result.SubGroup = myEntryHeader.Route.SubGroup.SubGroupName;

                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<EntryAttributesDto> getEntryAttributes(int entryId)
        {
            List<EntryAttributesDto> result = new List<EntryAttributesDto>();
            var myEntry = dc.Entry.Where(o => o.EntryId == entryId).First();
            var tempEntryAttributes = dc.EntryAttribute.Where(o => o.EntryId == entryId).ToList();
            var tempImage = dc.EntryImage.Where(o => o.EntryId == entryId).FirstOrDefault();
            foreach (var entity in tempEntryAttributes)
            {
                if(tempImage != null)
                {
                    result.Add(new EntryAttributesDto()
                    {
                        BrandId = myEntry.BrandId,
                        Attribute = dc.Attribute.Where(o => o.AttributeId == entity.AttributeId).First().Key,
                        Value = entity.Value,
                        EntryAttributeId = entity.EntryAttributeId,
                        ImageLink = dc.ListingFile.Where(o => o.ListingFileId == tempImage.ListingFileId).FirstOrDefault().FilePath.Substring(15),
                        EntryName = myEntry.Name,
                        EntryRange = myEntry.Range
                    });
                }
                else
                {
                    result.Add(new EntryAttributesDto()
                    {
                        BrandId = myEntry.BrandId,
                        Attribute = dc.Attribute.Where(o => o.AttributeId == entity.AttributeId).First().Key,
                        Value = entity.Value,
                        EntryAttributeId = entity.EntryAttributeId,
                        ImageLink = "",
                        EntryName = myEntry.Name,
                        EntryRange = myEntry.Range
                    });
                }
            }
            return result;
        }
        public EntryDetailsForSeoDto getEntryDetailsForSEO(int EntryId)
        {
            var tempEntry = dc.Entry.Include(o => o.Brand).Where(o => o.EntryId == EntryId).FirstOrDefault();
            if(tempEntry == null)
            {
                return null;
            }
            else
            {
                var temp = dc.EntryHeader.Include(o => o.Route).ThenInclude(o => o.Group)
                    .Include(o => o.Route.SuperGroup).Include(o => o.Route.SubGroup)
                    .Where(o => o.EntryId == tempEntry.EntryId).First();
                EntryDetailsForSeoDto result = new EntryDetailsForSeoDto();
                result.Group = temp.Route.Group.GroupName;
                result.Supergroup = temp.Route.SuperGroup.SuperGroupName;
                result.Subgroup = temp.Route.SubGroup.SubGroupName;
                result.Brand = tempEntry.Brand.Name;
                result.ProductName = tempEntry.Name;
                return result;
            }
        }
        public List<EntryAttributesDto> getEntryAttributes(string productname)
        {
            try
            {
                var tempEntry = dc.Entry.Where(o => o.Name == productname).First();
                return getEntryAttributes(tempEntry.EntryId);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<EntryRange> getEntriesRange(string range)
        {
            var temp = dc.Entry.Where(o => o.Range == range).ToList();
            List<EntryRange> result = new List<EntryRange>();
            foreach(var entity in temp){
                result.Add(new EntryRange()
                {
                    EntryId = entity.EntryId,
                    Range = entity.Range,
                    EntryName = entity.Name
                });
            }
            return result;
        }

        public ReturnOnlyString ProcessEntryFile(IFormFile theFile)
        {
            int count = 0;
            int commaCount = 0;
            int commaPointCount = 0;
            string line;
            string[] values;
            string testAuth = "";
            int amountOfUploads = -1;
            List<EntryAttributeUploadDto> myAttributes = new List<EntryAttributeUploadDto>();
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
                        if(commaCount > commaPointCount)
                        {
                            values = line.Split(',');
                        }
                        else
                        {
                            values = line.Split(';');
                        }
                        
                        if(count == 0)
                        {
                            testAuth = TestAuthentisityEntryFile(values);
                            if (testAuth != "")
                            {
                                return new ReturnOnlyString(testAuth, amountOfUploads);
                            }
                            myAttributes = getAttributesList(values);
                        }
                        else
                        {
                            if (ProcessEntryLine(values, myAttributes) != true)
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
        public List<EntryAttributeUploadDto> getAttributesList(string[] values)
        {
            List<EntryAttributeUploadDto> result = new List<EntryAttributeUploadDto>();
            int count = 0;
            int attributeCount = 7;
            foreach(var entity in values)
            {
                if(attributeCount == count)
                {
                    result.Add(new EntryAttributeUploadDto()
                    {
                        pos = attributeCount,
                        heading = entity
                    });
                    count++;
                    attributeCount++;
                }
                else
                {
                    count++;
                }
            }
            return result;
        }
        public bool ProcessEntryLine(string[] values, List<EntryAttributeUploadDto> Attributes)
        {
            try
            {
                var theBrand = dc.Brand.Where(o => o.Name == values[5]).First();
                var theSuperGroup = dc.SuperGroups.Where(o => o.SuperGroupName == values[1]).First().SuperGroupId;
                var theGroup = dc.Groups.Where(o => o.GroupDesc == values[2]).First().GroupId;
                var theSubGroup = dc.SubGroups.Where(o => o.SubGroupDesc == values[3]).First().SubGroupId;
                var theRoute = dc.Route.Where(o => o.SuperGroupId == theSuperGroup && o.GroupId == theGroup && o.SubGroupId == theSubGroup).First();

                if(values[0] == "Browse By")
                {
                    dc.Entry.Add(new Entry()
                    {
                        Name = values[4],
                        IsBrowseBy = true,
                        IsInfo = false,
                        Brand = theBrand,
                        BrandId = theBrand.BrandId,
                        Range = values[6]
                    });
                    dc.SaveChanges();
                }
                else if(values[0] == "Info")
                {
                    dc.Entry.Add(new Entry()
                    {
                        Name = values[4],
                        IsBrowseBy = false,
                        IsInfo = true,
                        Brand = theBrand,
                        BrandId = theBrand.BrandId,
                        Range = values[6]
                    });
                    dc.SaveChanges();
                }
                else
                {
                    return false;
                }
                var theEntry = dc.Entry.OrderByDescending(o => o.EntryId).First();

                //adding to entryHeading
                dc.EntryHeader.Add(new EntryHeader()
                {
                    Entry = theEntry,
                    EntryId = theEntry.EntryId,
                    Route = theRoute,
                    RouteId = theRoute.RouteId
                });
                dc.SaveChanges();

                if(addEntryAtributes(theEntry, Attributes, values))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool addEntryAtributes(Entry myEntry, List<EntryAttributeUploadDto> Attributes, string[] values)
        {
            int count = 0;
            int attributeCount = 7;
            EntryAttributeUploadDto temp;
            FarmboekAPI.Models.Attribute tempAttribute;
            foreach(var entity in values)
            {
                if(count == attributeCount)
                {
                    temp = Attributes.Where(o => o.pos == attributeCount).First();
                    tempAttribute = dc.Attribute.Where(o => o.Key == temp.heading).FirstOrDefault();
                    if(tempAttribute == null)
                    {
                        dc.Attribute.Add(new Models.Attribute()
                        {
                            Key = temp.heading
                        });
                        dc.SaveChanges();
                        tempAttribute = dc.Attribute.OrderByDescending(a => a.AttributeId).First();
                        dc.EntryAttribute.Add(new EntryAttribute()
                        {
                            Entry = myEntry,
                            EntryId = myEntry.EntryId,
                            Attribute = tempAttribute,
                            AttributeId = tempAttribute.AttributeId,
                            Value = entity
                        });
                        dc.SaveChanges();
                    }
                    else
                    {
                        dc.EntryAttribute.Add(new EntryAttribute()
                        {
                            Entry = myEntry,
                            EntryId = myEntry.EntryId,
                            Attribute = tempAttribute,
                            AttributeId = tempAttribute.AttributeId,
                            Value = entity
                        });
                        dc.SaveChanges();
                    }
                    count++;
                    attributeCount++;
                }
                else
                {
                    count++;
                }
            }
            return true;
        }
        public string TestAuthentisityEntryFile(string[] values)
        {
            if(values[0] != "MainMenu")
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
            if (values[4] != "ProductName")
            {
                return "Column ProductName is not Found";
            }
            if (values[5] != "Brand")
            {
                return "Column Brand is not Found";
            }
            if (values[6] != "Range")
            {
                return "Column Range is not Found";
            }
            return "";
        }

        public bool deleteEntry(int entryId)
        {
            try
            {
                var theEntry = dc.Entry.Where(o => o.EntryId == entryId).FirstOrDefault();
                if(theEntry == null)
                {
                    return false;
                }
                var theEntryAttributes = dc.EntryAttribute.Where(o => o.EntryId == entryId).ToList();
                var theEntryHeader = dc.EntryHeader.Where(o => o.EntryId == entryId).FirstOrDefault();

                //Start Deleteing
                foreach(var entity in theEntryAttributes)
                {
                    dc.EntryAttribute.Remove(entity);
                }
                dc.EntryHeader.Remove(theEntryHeader);
                dc.Entry.Remove(theEntry);
                dc.SaveChanges();
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }
        public bool deleteEntries(DeleteByIdDto T)
        {
            try
            {
                bool temp;
                foreach(var entity in T.Id)
                {
                    temp = deleteEntry(entity);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<EntryForDisplayDto> getEntriesForDisplay()
        {
            List<EntryForDisplayDto> result = new List<EntryForDisplayDto>();
            List<EntryAttributesForDisplayDto> resultAttributes = new List<EntryAttributesForDisplayDto>();
            var entryBatch = dc.Entry.Include(o => o.Brand).OrderByDescending(a => a.EntryId).Take(100).ToList();
            List<EntryAttribute> tempEntryAttribute;
            foreach(var entity in entryBatch)
            {
                resultAttributes.Clear();
                tempEntryAttribute = dc.EntryAttribute.Include(a => a.Attribute).Where(o => o.EntryId == entity.EntryId).ToList();
                foreach(var subentity in tempEntryAttribute)
                {
                    resultAttributes.Add(new EntryAttributesForDisplayDto()
                    {
                       EntryAttributeId = subentity.EntryAttributeId,
                       Key = subentity.Attribute.Key,
                       Value = subentity.Value
                    });
                }
               
                result.Add(new EntryForDisplayDto() 
                {
                    BrandId = entity.BrandId,
                    BrandName = entity.Brand.Name,
                    EntryId = entity.EntryId,
                    Name = entity.Name,
                    Range = entity.Range,
                    EntryAttributes = resultAttributes
                });
            }
            return result.OrderBy(o => o.Name).ToList();
        }

        public List<EntryForDisplayDto> getEntriesForDisplay(int amount)
        {
            List<EntryForDisplayDto> result = new List<EntryForDisplayDto>();
            List<EntryAttributesForDisplayDto> resultAttributes = new List<EntryAttributesForDisplayDto>();
            var entryBatch = dc.Entry.Include(o => o.Brand).OrderByDescending(a => a.EntryId).Take(amount).ToList();
            List<EntryAttribute> tempEntryAttribute;
            foreach (var entity in entryBatch)
            {
                resultAttributes.Clear();
                tempEntryAttribute = dc.EntryAttribute.Include(a => a.Attribute).Where(o => o.EntryId == entity.EntryId).ToList();
                foreach (var subentity in tempEntryAttribute)
                {
                    resultAttributes.Add(new EntryAttributesForDisplayDto()
                    {
                        EntryAttributeId = subentity.EntryAttributeId,
                        Key = subentity.Attribute.Key,
                        Value = subentity.Value
                    });
                }

                result.Add(new EntryForDisplayDto()
                {
                    BrandId = entity.BrandId,
                    BrandName = entity.Brand.Name,
                    EntryId = entity.EntryId,
                    Name = entity.Name,
                    Range = entity.Range,
                    EntryAttributes = resultAttributes
                });
            }
            return result.OrderBy(o => o.Name).ToList();
        }

    }
}
