using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class EntryForDisplayDto
    {
        public int EntryId { get; set; }
        public string Name { get; set; }
        public int? BrandId { get; set; }
        public string BrandName { get; set; }
        public string Range { get; set; }
        public List<EntryAttributesForDisplayDto> EntryAttributes { get; set; }
    }
}
