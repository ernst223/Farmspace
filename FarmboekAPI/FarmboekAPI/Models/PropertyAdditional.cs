using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class PropertyAdditional
    {
        public PropertyAdditional()
        {
            PropertyAdditionalImage = new HashSet<PropertyAdditionalImage>();
        }

        public int PropertyAdditionalId { get; set; }
        public int PropertyId { get; set; }
        public int PropId { get; set; }
        public string Description { get; set; }

        public ICollection<PropertyAdditionalImage> PropertyAdditionalImage { get; set; }
    }
}
