using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class TractorImage
    {
        public int TractorImageId { get; set; }
        public int TractorBaseId { get; set; }
        public int ListingFileId { get; set; }

        public ListingFile ListingFile { get; set; }
        public TractorBase TractorBase { get; set; }
    }
}
