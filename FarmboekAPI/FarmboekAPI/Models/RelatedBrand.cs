using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class RelatedBrand
    {
        public int RelatedBrandId { get; set; }
        public int BrandId { get; set; }
        public int ChildBrandId { get; set; }
        public int? BrandBrandId { get; set; }

        public Brand Brand { get; set; }
        public Brand BrandBrand { get; set; }
        public Brand ChildBrand { get; set; }
    }
}
