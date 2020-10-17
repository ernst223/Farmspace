using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ClassifiedAdRegion
    {
        public ClassifiedAdRegion()
        {
            ClassifiedAd = new HashSet<ClassifiedAd>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public ICollection<ClassifiedAd> ClassifiedAd { get; set; }
    }
}
