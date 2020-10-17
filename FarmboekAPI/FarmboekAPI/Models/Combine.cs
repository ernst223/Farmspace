using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Combine
    {
        public int CombineId { get; set; }
        public int CombineBaseId { get; set; }
        public int RouteId { get; set; }
        public int MenuTypeId { get; set; }

        public CombineBase CombineBase { get; set; }
        public MenuType MenuType { get; set; }
        public Route Route { get; set; }
    }
}
