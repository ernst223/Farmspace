using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ProductBaseRemedyType
    {
        public int ProductBaseRemedyTypeId { get; set; }
        public int ProductBaseId { get; set; }
        public int RemedyTypeId { get; set; }

        public ProductBase ProductBase { get; set; }
        public RemedyType RemedyType { get; set; }
    }
}
