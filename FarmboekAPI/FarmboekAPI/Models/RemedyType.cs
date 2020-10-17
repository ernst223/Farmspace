using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class RemedyType
    {
        public RemedyType()
        {
            ProductBaseRemedyType = new HashSet<ProductBaseRemedyType>();
        }

        public int RemedyTypeId { get; set; }
        public string Description { get; set; }

        public ICollection<ProductBaseRemedyType> ProductBaseRemedyType { get; set; }
    }
}
