using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class GameAndLivestockTradeAd
    {
        public int Id { get; set; }
        public string AnimalType { get; set; }
        public string Breed { get; set; }
        public int Quantity { get; set; }
        public int TradeAdId { get; set; }

        public TradeAd TradeAd { get; set; }
    }
}
