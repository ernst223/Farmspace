using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class CompanyType
    {
        public CompanyType()
        {
            Entity = new HashSet<Entity>();
        }

        public int CompanyTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Entity> Entity { get; set; }
    }
}
