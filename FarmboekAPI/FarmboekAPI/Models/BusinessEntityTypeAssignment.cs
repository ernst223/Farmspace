using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class BusinessEntityTypeAssignment
    {
        public int BusinessEntityTypeAssignmentId { get; set; }
        public int BusinessEntityId { get; set; }
        public int BusinessEntityTypeId { get; set; }

        public BusinessEntity BusinessEntity { get; set; }
        public BusinessEntityType BusinessEntityType { get; set; }
    }
}
