using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class SupplierMunicipalDistrict
    {
        public int SupplierMunicipalDistrictId { get; set; }
        public int SupplierId { get; set; }
        public int MunicipalDistrictId { get; set; }

        public MunicipalDistrict MunicipalDistrict { get; set; }
        public Supplier Supplier { get; set; }
    }
}
