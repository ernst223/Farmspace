using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Section
    {
        public Section()
        {
            Route = new HashSet<Route>();
        }

        public int SectionId { get; set; }
        public string SectionName { get; set; }

        public ICollection<Route> Route { get; set; }
    }
}
