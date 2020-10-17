using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class BusinessEntityBase
    {
        public BusinessEntityBase()
        {
            BusinessEntity = new HashSet<BusinessEntity>();
            BusinessEntityImage = new HashSet<BusinessEntityImage>();
        }

        public int BusinessEntityBaseId { get; set; }
        public string Name { get; set; }

        public ICollection<BusinessEntity> BusinessEntity { get; set; }
        public ICollection<BusinessEntityImage> BusinessEntityImage { get; set; }
    }
}
