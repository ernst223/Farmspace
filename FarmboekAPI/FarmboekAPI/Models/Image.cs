using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Image
    {
        public int ImageId { get; set; }
        public string ImagePath { get; set; }
        public string ImageDescription { get; set; }
        public int ClassifiedAdId { get; set; }
        public int AdvertisementId { get; set; }
        public string OriginalFilename { get; set; }

        public ClassifiedAd ClassifiedAd { get; set; }
    }
}
