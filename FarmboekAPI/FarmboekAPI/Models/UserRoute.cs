using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class UserRoute
    {
        public int UserRouteId { get; set; }
        public int UserId { get; set; }
        public int RouteId { get; set; }
        public int ViewCount { get; set; }

        public Route Route { get; set; }
        public UserProfile User { get; set; }
    }
}
