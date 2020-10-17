using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class FarmType
    {
        public int FarmTypeId { get; set; }
        public int FarmId { get; set; }
        public string IndustryHa { get; set; }
        public string Drainage { get; set; }
        public string Irrigation { get; set; }
        public string Fencing { get; set; }
        public string Description { get; set; }
        public int SuperGroupId { get; set; }
        public string SuperGroupName { get; set; }
        public int SubGroupId { get; set; }
        public string SubGroupName { get; set; }
        public int ListingFileId { get; set; }
    }
}
