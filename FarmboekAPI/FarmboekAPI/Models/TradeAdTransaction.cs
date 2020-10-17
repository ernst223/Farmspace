using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class TradeAdTransaction
    {
        public int Id { get; set; }
        public string TradeSafeId { get; set; }
        public string Step { get; set; }
        public Guid? TradeSafeReference { get; set; }
        public double OfferAmount { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Accepted { get; set; }
        public DateTime? Updated { get; set; }
        public int TradeAdId { get; set; }
        public int BuyerId { get; set; }

        public TraderProfileSnapshot Buyer { get; set; }
        public TradeAd TradeAd { get; set; }
    }
}
