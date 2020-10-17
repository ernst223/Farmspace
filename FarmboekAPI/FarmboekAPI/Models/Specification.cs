using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Specification
    {
        public Specification()
        {
            EquipmentSpecification = new HashSet<EquipmentSpecification>();
            ProductSpecification = new HashSet<ProductSpecification>();
        }

        public int SpecificationId { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }

        public ICollection<EquipmentSpecification> EquipmentSpecification { get; set; }
        public ICollection<ProductSpecification> ProductSpecification { get; set; }
    }
}
