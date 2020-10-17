using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class SubGroups
    {
        public SubGroups()
        {
            GroupSubGroups = new HashSet<GroupSubGroups>();
            Route = new HashSet<Route>();
            SubGroupGroupList = new HashSet<SubGroupGroupList>();
            TradeAd = new HashSet<TradeAd>();
        }

        public int SubGroupId { get; set; }
        public string SubGroupName { get; set; }
        public string SubGroupDesc { get; set; }
        public bool IsCommercial { get; set; }
        public bool IsInformation { get; set; }

        public ICollection<GroupSubGroups> GroupSubGroups { get; set; }
        public ICollection<Route> Route { get; set; }
        public ICollection<SubGroupGroupList> SubGroupGroupList { get; set; }
        public ICollection<TradeAd> TradeAd { get; set; }
    }
}
