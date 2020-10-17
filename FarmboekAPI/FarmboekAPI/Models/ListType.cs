using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ListType
    {
        public ListType()
        {
            SubGroupGroupList = new HashSet<SubGroupGroupList>();
        }

        public int ListTypeId { get; set; }
        public string ListTypeName { get; set; }
        public string ListTypeDesc { get; set; }
        public bool HasPrice { get; set; }
        public bool HasActiveIngredient { get; set; }
        public bool HasRemedy { get; set; }
        public bool HasRating { get; set; }
        public bool HasExternalLink { get; set; }

        public ICollection<SubGroupGroupList> SubGroupGroupList { get; set; }
    }
}
