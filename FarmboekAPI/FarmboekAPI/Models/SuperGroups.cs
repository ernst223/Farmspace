using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class SuperGroups
    {
        public SuperGroups()
        {
            GroupSuperGroups = new HashSet<GroupSuperGroups>();
            Route = new HashSet<Route>();
            TradeAd = new HashSet<TradeAd>();
        }

        public int SuperGroupId { get; set; }
        public string SuperGroupName { get; set; }
        public string SuperGroupDesc { get; set; }
        public bool IsCommercial { get; set; }
        public bool IsInformation { get; set; }

        public ICollection<GroupSuperGroups> GroupSuperGroups { get; set; }
        public ICollection<Route> Route { get; set; }
        public ICollection<TradeAd> TradeAd { get; set; }
    }
}
