using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class BusinessEntityType
    {
        public BusinessEntityType()
        {
            BusinessEntityTypeAssignment = new HashSet<BusinessEntityTypeAssignment>();
        }

        public int BusinessEntityTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<BusinessEntityTypeAssignment> BusinessEntityTypeAssignment { get; set; }
    }
}
