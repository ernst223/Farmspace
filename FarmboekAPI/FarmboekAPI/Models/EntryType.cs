using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class EntryType
    {
        public EntryType()
        {
            CombineBase = new HashSet<CombineBase>();
            EquipmentBase = new HashSet<EquipmentBase>();
            ProblemBase = new HashSet<ProblemBase>();
            ProductBase = new HashSet<ProductBase>();
            TractorBase = new HashSet<TractorBase>();
            VehicleBase = new HashSet<VehicleBase>();
        }

        public int EntryTypeId { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public string Key { get; set; }

        public ICollection<CombineBase> CombineBase { get; set; }
        public ICollection<EquipmentBase> EquipmentBase { get; set; }
        public ICollection<ProblemBase> ProblemBase { get; set; }
        public ICollection<ProductBase> ProductBase { get; set; }
        public ICollection<TractorBase> TractorBase { get; set; }
        public ICollection<VehicleBase> VehicleBase { get; set; }
    }
}
