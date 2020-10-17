using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Infrastructure
    {
        public Infrastructure()
        {
            Farm = new HashSet<Farm>();
            FarmInfrastructure = new HashSet<FarmInfrastructure>();
        }

        public int InfrastructureId { get; set; }
        public string Name { get; set; }

        public ICollection<Farm> Farm { get; set; }
        public ICollection<FarmInfrastructure> FarmInfrastructure { get; set; }
    }
}
