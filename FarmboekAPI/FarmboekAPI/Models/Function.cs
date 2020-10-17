using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Function
    {
        public Function()
        {
            RoleFunction = new HashSet<RoleFunction>();
        }

        public int FunctionId { get; set; }
        public string FunctionNo { get; set; }
        public string FunctionName { get; set; }
        public string Category { get; set; }
        public string FunctionDescription { get; set; }

        public ICollection<RoleFunction> RoleFunction { get; set; }
    }
}
