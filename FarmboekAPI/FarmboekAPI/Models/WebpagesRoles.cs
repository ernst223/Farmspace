using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class WebpagesRoles
    {
        public WebpagesRoles()
        {
            RoleFunction = new HashSet<RoleFunction>();
            WebpagesUsersInRoles = new HashSet<WebpagesUsersInRoles>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<RoleFunction> RoleFunction { get; set; }
        public ICollection<WebpagesUsersInRoles> WebpagesUsersInRoles { get; set; }
    }
}
