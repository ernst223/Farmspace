using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class FarmInfrastructure
    {
        public int FarmInfrastructureId { get; set; }
        public int InfrastructureId { get; set; }
        public int FarmId { get; set; }
        public string InfrastructureName { get; set; }

        public Infrastructure Infrastructure { get; set; }
    }
}
