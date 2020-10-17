using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class UserFavouriteTradeAd
    {
        public int UserFavouriteTradeAdId { get; set; }
        public int UserId { get; set; }
        public int TradeAdId { get; set; }

        public TradeAd TradeAd { get; set; }
        public UserProfile User { get; set; }
    }
}
