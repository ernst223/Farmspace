using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class GroupSuperGroups
    {
        public int GroupSuperGroupId { get; set; }
        public string Code { get; set; }
        public int SuperGroupId { get; set; }
        public int GroupId { get; set; }

        public Groups Group { get; set; }
        public SuperGroups SuperGroup { get; set; }
    }
}
