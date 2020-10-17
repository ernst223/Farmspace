using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class PropertyCategory
    {
        public PropertyCategory()
        {
            PropertyListing = new HashSet<PropertyListing>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public ICollection<PropertyListing> PropertyListing { get; set; }
    }
}
