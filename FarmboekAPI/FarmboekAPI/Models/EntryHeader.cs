using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class EntryHeader
    {
        public int EntryHeaderId { get; set; }
        public int EntryId { get; set; }
        public int RouteId { get; set; }

        public Entry Entry { get; set; }
        public Route Route { get; set; }
    }
}
