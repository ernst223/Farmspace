using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class SubGroupGroupList
    {
        public int SubGroupGroupListId { get; set; }
        public int? ListTypeListTypeId { get; set; }
        public int? SubGroupSubGroupId { get; set; }

        public ListType ListTypeListType { get; set; }
        public SubGroups SubGroupSubGroup { get; set; }
    }
}
