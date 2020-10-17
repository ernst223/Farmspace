using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class MarketPdf
    {
        public int MarketPdfid { get; set; }
        public int MarketId { get; set; }
        public int ListingFileId { get; set; }

        public ListingFile ListingFile { get; set; }
        public Market Market { get; set; }
    }
}
