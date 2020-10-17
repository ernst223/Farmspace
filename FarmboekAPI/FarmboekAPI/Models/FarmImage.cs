using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class FarmImage
    {
        public int FarmImageId { get; set; }
        public int FarmId { get; set; }
        public int ListingFileId { get; set; }

        public ListingFile ListingFile { get; set; }
    }
}
