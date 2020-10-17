using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class CropTradeAd
    {
        public int Id { get; set; }
        public string CropType { get; set; }
        public string Grade { get; set; }
        public string Packaging { get; set; }
        public int Quantity { get; set; }
        public int TradeAdId { get; set; }

        public TradeAd TradeAd { get; set; }
    }
}
