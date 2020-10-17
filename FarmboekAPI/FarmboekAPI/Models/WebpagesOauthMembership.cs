using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class WebpagesOauthMembership
    {
        public string Provider { get; set; }
        public string ProviderUserId { get; set; }
        public int UserId { get; set; }

        public UserProfile User { get; set; }
        public WebpagesMembership UserNavigation { get; set; }
    }
}
