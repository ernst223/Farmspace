using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class AdvertisementImage
    {
        public int AdvertisementImageId { get; set; }
        public int AdvertisementId { get; set; }
        public int ListingFileId { get; set; }

        public Advertisement Advertisement { get; set; }
        public ListingFile ListingFile { get; set; }
    }
}
