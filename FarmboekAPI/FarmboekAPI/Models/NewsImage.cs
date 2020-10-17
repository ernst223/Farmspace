using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class NewsImage
    {
        public int NewsImageId { get; set; }
        public int NewsId { get; set; }
        public int ListingFileId { get; set; }

        public ListingFile ListingFile { get; set; }
        public News News { get; set; }
    }
}
