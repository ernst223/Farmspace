using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Auctions
    {
        public Auctions()
        {
            AuctionItems = new HashSet<AuctionItems>();
        }

        public int AuctionId { get; set; }
        public string AuctionTitle { get; set; }
        public int ProvinceId { get; set; }
        public int TownId { get; set; }
        public int AuctionCategoryId { get; set; }
        public DateTime AuctionDate { get; set; }
        public int UserId { get; set; }

        public AuctionCategory AuctionCategory { get; set; }
        public Province Province { get; set; }
        public Town Town { get; set; }
        public UserProfile User { get; set; }
        public ICollection<AuctionItems> AuctionItems { get; set; }
    }
}
