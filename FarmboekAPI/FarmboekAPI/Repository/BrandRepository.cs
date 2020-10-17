using FarmboekAPI.DTO;
using FarmboekAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Repository
{
    public class BrandRepository
    {
        private FarmboekContext dc;
        public BrandRepository(FarmboekContext context)
        {
            dc = context;
        }

        public BrandDto getBrand(int id)
        {
            var temp = dc.Brand.Where(o => o.BrandId == id).FirstOrDefault();
            if(temp != null)
            {
                var tempBrandImage = dc.BrandImage.Where(o => o.BrandId == temp.BrandId).FirstOrDefault();
                if (tempBrandImage != null)
                {
                    return new BrandDto()
                    {
                        BrandId = temp.BrandId,
                        AccountNo = temp.AccountNo,
                        Address = temp.Address,
                        ContactId = temp.ContactId,
                        Summary = temp.Summary,
                        Description = temp.Description,
                        HasPaid = temp.HasPaid,
                        IsActive = temp.IsActive,
                        Name = temp.Name,
                        ImageName = dc.ListingFile.Where(o => o.ListingFileId == tempBrandImage.ListingFileId).FirstOrDefault().FilePath.Substring(15)
                    };
                }
                else
                {
                    return new BrandDto()
                    {
                        BrandId = temp.BrandId,
                        AccountNo = temp.AccountNo,
                        Address = temp.Address,
                        ContactId = temp.ContactId,
                        Summary = temp.Summary,
                        Description = temp.Description,
                        HasPaid = temp.HasPaid,
                        IsActive = temp.IsActive,
                        Name = temp.Name,
                        ImageName = "No_image_3x4.svg.png"
                    };
                }
                
            }
            else
            {
                return null;
            }
        }

        public ContactDto getBrandContact(int id)
        {
            var temp = dc.Contact.Where(o => o.ContactId == id).FirstOrDefault();
            if(temp != null)
            {
                return new ContactDto()
                {
                    CellNumber = temp.CellNumber,
                    ContactId = temp.ContactId,
                    Email = temp.Email,
                    FullName = temp.FullName,
                    TelNumber = temp.TelNumber,
                    Website = temp.Website
                };
            }
            else
            {
                return null;
            }
        }

        public List<BrandDto> getAllBrands()
        {
            List<BrandDto> result = new List<BrandDto>();
            foreach(var o in dc.Brand.ToList())
            {
                result.Add(new BrandDto()
                {
                    AccountNo = o.AccountNo,
                    Address = o.Address,
                    BrandId = o.BrandId,
                    IsActive = o.IsActive,
                    ContactId = o.ContactId,
                    Description = o.Description,
                    HasPaid = o.HasPaid,
                    Name = o.Name,
                    Summary = o.Summary
                });
            }
            return result;
        }
    }
}
