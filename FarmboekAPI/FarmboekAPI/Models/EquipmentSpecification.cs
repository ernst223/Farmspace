using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class EquipmentSpecification
    {
        public int EquipmentSpecificationId { get; set; }
        public int EquipmentBaseEquipmentBaseId { get; set; }
        public int SpecificationSpecificationId { get; set; }

        public EquipmentBase EquipmentBaseEquipmentBase { get; set; }
        public Specification SpecificationSpecification { get; set; }
    }
}
