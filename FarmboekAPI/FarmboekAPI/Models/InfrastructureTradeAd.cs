using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class InfrastructureTradeAd
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int TradeAdId { get; set; }

        public TradeAd TradeAd { get; set; }
    }
}
