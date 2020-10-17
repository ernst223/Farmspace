using FarmboekAPI.DTO;
using FarmboekAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Repository
{
    public class SupplierRepository
    {
        private FarmboekContext dc;
        public SupplierRepository(FarmboekContext context)
        {
            dc = context;
        }

        public SupplierDto getSupplierById (int supplierId)
        {
            var temp = dc.Supplier.Where(o => o.SupplierId == supplierId).FirstOrDefault();
            if (temp == null)
            {
                return null;
            }
            else
            {
                var tempSupplierImage = dc.SupplierImage.Where(o => o.SupplierId == temp.SupplierId).FirstOrDefault();
                if (tempSupplierImage != null)
                {
                    return new SupplierDto()
                    {
                        AccountNo = temp.AccountNo,
                        CountryId = temp.CountryId,
                        HasPaid = temp.HasPaid,
                        IsActive = temp.IsActive,
                        ProvinceId = temp.ProvinceId,
                        SupplierAddress1 = temp.SupplierAddress1,
                        SupplierAddress2 = temp.SupplierAddress2,
                        SupplierCity = temp.SupplierCity,
                        SupplierDesc = temp.SupplierDesc,
                        SupplierId = temp.SupplierId,
                        SupplierName = temp.SupplierName,
                        SupplierPostCode = temp.SupplierPostCode,
                        SupplierTel1 = temp.SupplierTel1,
                        SupplierTel2 = temp.SupplierTel2,
                        ImageName = dc.ListingFile.Where(o => o.ListingFileId == tempSupplierImage.ListingFileId).FirstOrDefault().FilePath.Substring(15)
                    };
                }
                else
                {
                    return new SupplierDto()
                    {
                        AccountNo = temp.AccountNo,
                        CountryId = temp.CountryId,
                        HasPaid = temp.HasPaid,
                        IsActive = temp.IsActive,
                        ProvinceId = temp.ProvinceId,
                        SupplierAddress1 = temp.SupplierAddress1,
                        SupplierAddress2 = temp.SupplierAddress2,
                        SupplierCity = temp.SupplierCity,
                        SupplierDesc = temp.SupplierDesc,
                        SupplierId = temp.SupplierId,
                        SupplierName = temp.SupplierName,
                        SupplierPostCode = temp.SupplierPostCode,
                        SupplierTel1 = temp.SupplierTel1,
                        SupplierTel2 = temp.SupplierTel2,
                        ImageName = "No_image_3x4.svg.png"
                    };
                }
            }
        }

        public List<SupplierDto> getSuppliersByBrandId(int brandId)
        {
            List<SupplierDto> result = new List<SupplierDto>();
            var tempSupplierBrand = dc.SupplierBrand.Where(o => o.BrandId == brandId).ToList();
            Supplier temp;
            foreach(var entity in tempSupplierBrand)
            {
                temp = dc.Supplier.Where(o => o.SupplierId == entity.SupplierId).FirstOrDefault();
                if (temp != null)
                {
                    var tempSupplierImage = dc.SupplierImage.Where(o => o.SupplierId == temp.SupplierId).FirstOrDefault();
                    if (tempSupplierImage != null)
                    {
                        result.Add(new SupplierDto()
                        {
                            AccountNo = temp.AccountNo,
                            CountryId = temp.CountryId,
                            HasPaid = temp.HasPaid,
                            IsActive = temp.IsActive,
                            ProvinceId = temp.ProvinceId,
                            SupplierAddress1 = temp.SupplierAddress1,
                            SupplierAddress2 = temp.SupplierAddress2,
                            SupplierCity = temp.SupplierCity,
                            SupplierDesc = temp.SupplierDesc,
                            SupplierId = temp.SupplierId,
                            SupplierName = temp.SupplierName,
                            SupplierPostCode = temp.SupplierPostCode,
                            SupplierTel1 = temp.SupplierTel1,
                            SupplierTel2 = temp.SupplierTel2,
                            ImageName = dc.ListingFile.Where(o => o.ListingFileId == tempSupplierImage.ListingFileId).FirstOrDefault().FilePath.Substring(15)
                        });
                    }
                    else
                    {
                        result.Add(new SupplierDto()
                        {
                            AccountNo = temp.AccountNo,
                            CountryId = temp.CountryId,
                            HasPaid = temp.HasPaid,
                            IsActive = temp.IsActive,
                            ProvinceId = temp.ProvinceId,
                            SupplierAddress1 = temp.SupplierAddress1,
                            SupplierAddress2 = temp.SupplierAddress2,
                            SupplierCity = temp.SupplierCity,
                            SupplierDesc = temp.SupplierDesc,
                            SupplierId = temp.SupplierId,
                            SupplierName = temp.SupplierName,
                            SupplierPostCode = temp.SupplierPostCode,
                            SupplierTel1 = temp.SupplierTel1,
                            SupplierTel2 = temp.SupplierTel2,
                            ImageName = "No_image_3x4.svg.png"
                        }); 
                    }
                }
            }
            return result;
          
        }
        public List<Province> getProvinces()
        {
            return dc.Province.ToList();
        }
        public List<ViewBrandsDto> getSupplierBrands(int supplierId)
        {
            List<ViewBrandsDto> result = new List<ViewBrandsDto>();
            var temp = dc.SupplierBrand.Where(o => o.SupplierId == supplierId).ToList();
            BrandImage tempImage;
            foreach(var entity in temp)
            {
                tempImage = dc.BrandImage.Where(o => o.BrandId == entity.BrandId).FirstOrDefault();
                if(tempImage != null)
                {
                    result.Add(new ViewBrandsDto()
                    {
                        BrandId = entity.BrandId,
                        BrandName = dc.Brand.Where(o => o.BrandId == entity.BrandId).First().Name,
                        ImageLink = dc.ListingFile.Where(o => o.ListingFileId == tempImage.ListingFileId).FirstOrDefault().FilePath.Substring(15)
                    });
                }
                else
                {
                    result.Add(new ViewBrandsDto()
                    {
                        BrandId = entity.BrandId,
                        BrandName = dc.Brand.Where(o => o.BrandId == entity.BrandId).First().Name,
                        ImageLink = "No_image_3x4.svg.png"
                    });
                }
            }
            return result;
        }
    }
}
