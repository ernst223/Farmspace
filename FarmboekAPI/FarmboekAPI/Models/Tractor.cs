using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Tractor
    {
        public int TractorId { get; set; }
        public int TractorBaseId { get; set; }
        public int RouteId { get; set; }
        public int MenuTypeId { get; set; }

        public MenuType MenuType { get; set; }
        public Route Route { get; set; }
        public TractorBase TractorBase { get; set; }
    }
}
