using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class TradeAdContactLog
    {
        public int Id { get; set; }
        public int TradeAdId { get; set; }
        public int UserProfileId { get; set; }

        public TradeAd TradeAd { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
