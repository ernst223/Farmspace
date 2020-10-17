using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class UserIndustries
    {
        public int UiId { get; set; }
        public bool Active { get; set; }
        public bool Answered { get; set; }
        public int? IndustryGroupId { get; set; }
        public int? UserUserId { get; set; }
        public bool GetInfo { get; set; }
        public int ClickCounter { get; set; }

        public Groups IndustryGroup { get; set; }
        public UserProfile UserUser { get; set; }
    }
}
