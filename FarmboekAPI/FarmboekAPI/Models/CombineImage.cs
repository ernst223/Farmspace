using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class CombineImage
    {
        public int CombineImageId { get; set; }
        public int CombineBaseId { get; set; }
        public int ListingFileId { get; set; }

        public CombineBase CombineBase { get; set; }
        public ListingFile ListingFile { get; set; }
    }
}
