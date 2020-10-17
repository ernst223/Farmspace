using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class TradeAdImage
    {
        public int Id { get; set; }
        public int ListingFileId { get; set; }
        public int TradeAdId { get; set; }

        public ListingFile ListingFile { get; set; }
        public TradeAd TradeAd { get; set; }
    }
}
