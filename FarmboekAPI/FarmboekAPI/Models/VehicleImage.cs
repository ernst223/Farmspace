using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class VehicleImage
    {
        public int VehicleImageId { get; set; }
        public int VehicleBaseId { get; set; }
        public int ListingFileId { get; set; }

        public ListingFile ListingFile { get; set; }
        public VehicleBase VehicleBase { get; set; }
    }
}
