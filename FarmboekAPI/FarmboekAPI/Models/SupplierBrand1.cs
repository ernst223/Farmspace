using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class SupplierBrand1
    {
        public int SupplierSupplierId { get; set; }
        public int BrandBrandId { get; set; }

        public Brand BrandBrand { get; set; }
        public Supplier SupplierSupplier { get; set; }
    }
}
