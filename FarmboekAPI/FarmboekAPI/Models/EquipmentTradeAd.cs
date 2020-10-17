using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class EquipmentTradeAd
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int YearModel { get; set; }
        public int Hours { get; set; }
        public int Kilowatt { get; set; }
        public string Condition { get; set; }
        public int TradeAdId { get; set; }

        public TradeAd TradeAd { get; set; }
    }
}
