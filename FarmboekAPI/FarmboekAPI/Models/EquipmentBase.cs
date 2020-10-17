using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class EquipmentBase
    {
        public EquipmentBase()
        {
            Equipment = new HashSet<Equipment>();
            EquipmentImage = new HashSet<EquipmentImage>();
            EquipmentSpecification = new HashSet<EquipmentSpecification>();
        }

        public int EquipmentBaseId { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public int? SpecificationId { get; set; }
        public int EntryTypeId { get; set; }
        public int? BrandId { get; set; }
        public int? SpecificationListingFileId { get; set; }

        public Brand Brand { get; set; }
        public EntryType EntryType { get; set; }
        public ListingFile SpecificationListingFile { get; set; }
        public ICollection<Equipment> Equipment { get; set; }
        public ICollection<EquipmentImage> EquipmentImage { get; set; }
        public ICollection<EquipmentSpecification> EquipmentSpecification { get; set; }
    }
}
