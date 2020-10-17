using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class GroupList
    {
        public int GroupListId { get; set; }
        public string GroupListName { get; set; }
        public string GroupListDesc { get; set; }
        public bool IsCommercial { get; set; }
        public bool IsInformation { get; set; }
    }
}
