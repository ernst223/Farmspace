using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class AdvertisementRoute
    {
        public int AdvertisementRouteId { get; set; }
        public int AdvertisementId { get; set; }
        public int RouteId { get; set; }
        public int? LoadCounter { get; set; }

        public Advertisement Advertisement { get; set; }
        public Route Route { get; set; }
    }
}
