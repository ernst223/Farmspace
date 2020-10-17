using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class BusinessEntity
    {
        public BusinessEntity()
        {
            BusinessEntityTypeAssignment = new HashSet<BusinessEntityTypeAssignment>();
        }

        public int BusinessEntityId { get; set; }
        public int BusinessEntityBaseId { get; set; }
        public int RouteId { get; set; }

        public BusinessEntityBase BusinessEntityBase { get; set; }
        public Route Route { get; set; }
        public ICollection<BusinessEntityTypeAssignment> BusinessEntityTypeAssignment { get; set; }
    }
}
