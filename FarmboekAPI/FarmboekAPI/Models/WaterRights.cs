using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class WaterRights
    {
        public WaterRights()
        {
            Farm = new HashSet<Farm>();
            FarmWaterRight = new HashSet<FarmWaterRight>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Farm> Farm { get; set; }
        public ICollection<FarmWaterRight> FarmWaterRight { get; set; }
    }
}
