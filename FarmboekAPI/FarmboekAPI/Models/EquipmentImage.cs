using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class EquipmentImage
    {
        public int EquipmentImageId { get; set; }
        public int EquipmentBaseId { get; set; }
        public int ListingFileId { get; set; }

        public EquipmentBase EquipmentBase { get; set; }
        public ListingFile ListingFile { get; set; }
    }
}
