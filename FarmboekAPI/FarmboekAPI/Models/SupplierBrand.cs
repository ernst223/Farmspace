using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class SupplierBrand
    {
        public int SupplierBrandId { get; set; }
        public int BrandId { get; set; }
        public int SupplierId { get; set; }

        public Brand Brand { get; set; }
        public Supplier Supplier { get; set; }
    }
}
