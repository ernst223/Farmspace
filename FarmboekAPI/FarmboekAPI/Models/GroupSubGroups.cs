using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class GroupSubGroups
    {
        public int GroupSubGroupId { get; set; }
        public string Code { get; set; }
        public int GroupId { get; set; }
        public int SubGroupId { get; set; }

        public Groups Group { get; set; }
        public SubGroups SubGroup { get; set; }
    }
}
