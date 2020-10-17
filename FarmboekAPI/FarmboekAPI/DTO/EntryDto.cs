using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class EntryDto
    {
        public int EntryId { get; set; }
        public string Name { get; set; }
        public bool IsBrowseBy { get; set; }
        public bool IsInfo { get; set; }
        public int? BrandId { get; set; }
        public string Brand{ get; set; }
        public int? EntryTypeTemplateId { get; set; }
        public string Range { get; set; }
        public string ImageLink { get; set; }
    }
}
