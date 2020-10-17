using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class FarmWaterRight
    {
        public int FarmWaterRightId { get; set; }
        public int FarmId { get; set; }
        public int WaterRightId { get; set; }
        public string WaterRightName { get; set; }
        public string HaListed { get; set; }
        public string M3Listed { get; set; }

        public WaterRights WaterRight { get; set; }
    }
}
