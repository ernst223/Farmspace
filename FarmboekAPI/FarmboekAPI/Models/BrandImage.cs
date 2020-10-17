using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class BrandImage
    {
        public int BrandImageId { get; set; }
        public int BrandId { get; set; }
        public int ListingFileId { get; set; }

        public Brand Brand { get; set; }
        public ListingFile ListingFile { get; set; }
    }
}
