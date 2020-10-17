using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class EquipmentFarm
    {
        public int EquipmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int FarmId { get; set; }
    }
}
