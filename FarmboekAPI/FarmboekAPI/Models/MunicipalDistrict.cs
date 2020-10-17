using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class MunicipalDistrict
    {
        public MunicipalDistrict()
        {
            SupplierMunicipalDistrict = new HashSet<SupplierMunicipalDistrict>();
        }

        public int MunicipalDistrictId { get; set; }
        public int ProvinceId { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public Province Province { get; set; }
        public ICollection<SupplierMunicipalDistrict> SupplierMunicipalDistrict { get; set; }
    }
}
