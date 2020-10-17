using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class AuctionItems
    {
        public int AuctionItemId { get; set; }
        public string ItemName { get; set; }


        public int AuctionId { get; set; }

        public Auctions Auction { get; set; }
    }
}
