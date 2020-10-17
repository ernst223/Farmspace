using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class AuctionCategory
    {
        public AuctionCategory()
        {
            Auctions = new HashSet<Auctions>();
        }

        public int AuctionCategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Auctions> Auctions { get; set; }
    }
}
