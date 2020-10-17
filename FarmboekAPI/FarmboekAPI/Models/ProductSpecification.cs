using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ProductSpecification
    {
        public int ProductSpecificationId { get; set; }
        public int ProductBaseId { get; set; }
        public int SpecificationSpecificationId { get; set; }

        public ProductBase ProductBase { get; set; }
        public Specification SpecificationSpecification { get; set; }
    }
}
