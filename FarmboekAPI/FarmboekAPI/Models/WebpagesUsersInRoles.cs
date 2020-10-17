using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class WebpagesUsersInRoles
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public WebpagesRoles Role { get; set; }
        public WebpagesMembership User { get; set; }
    }
}
