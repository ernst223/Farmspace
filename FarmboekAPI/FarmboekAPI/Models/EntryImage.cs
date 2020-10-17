using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class EntryImage
    {
        public int EntryImageId { get; set; }
        public int EntryId { get; set; }
        public int ListingFileId { get; set; }

        public Entry Entry { get; set; }
        public ListingFile ListingFile { get; set; }
    }
}
