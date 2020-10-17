using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Groups
    {
        public Groups()
        {
            GroupSubGroups = new HashSet<GroupSubGroups>();
            GroupSuperGroups = new HashSet<GroupSuperGroups>();
            Route = new HashSet<Route>();
            TradeAd = new HashSet<TradeAd>();
            UserIndustries = new HashSet<UserIndustries>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDesc { get; set; }
        public bool IsCommercial { get; set; }
        public bool IsInformation { get; set; }

        public ICollection<GroupSubGroups> GroupSubGroups { get; set; }
        public ICollection<GroupSuperGroups> GroupSuperGroups { get; set; }
        public ICollection<Route> Route { get; set; }
        public ICollection<TradeAd> TradeAd { get; set; }
        public ICollection<UserIndustries> UserIndustries { get; set; }
    }
}
