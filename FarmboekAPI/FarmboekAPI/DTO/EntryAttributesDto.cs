using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class EntryAttributesDto
    {
        public int EntryAttributeId { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }
        public int? BrandId { get; set; }
        public string ImageLink { get; set; }
        public string EntryName { get; set; }
        public string EntryRange { get; set; }
    }
}
