using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class RepresentativeProvince
    {
        public int RepresentativeProvinceId { get; set; }
        public int RepresentativeId { get; set; }
        public int? ProvinceId { get; set; }

        public Province Province { get; set; }
        public Representative Representative { get; set; }
    }
}
