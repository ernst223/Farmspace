using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Market
    {
        public Market()
        {
            MarketPdf = new HashSet<MarketPdf>();
            MarketRoute = new HashSet<MarketRoute>();
        }

        public int MarketId { get; set; }
        public string Code { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Active { get; set; }
        public string Category { get; set; }

        public ICollection<MarketPdf> MarketPdf { get; set; }
        public ICollection<MarketRoute> MarketRoute { get; set; }
    }
}
