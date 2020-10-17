using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class MarketRoute
    {
        public int MarketRouteId { get; set; }
        public int MarketId { get; set; }
        public int RouteId { get; set; }

        public Market Market { get; set; }
        public Route Route { get; set; }
    }
}
