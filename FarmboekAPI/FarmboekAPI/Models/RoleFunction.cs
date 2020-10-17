using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class RoleFunction
    {
        public int RoleFunctionId { get; set; }
        public int FunctionId { get; set; }
        public int RoleId { get; set; }

        public Function Function { get; set; }
        public WebpagesRoles Role { get; set; }
    }
}
