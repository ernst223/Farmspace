using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class ProductBaseDto
    {
        public int ProductBaseId { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string Formulation { get; set; }
        public string Registration { get; set; }
        public string Concentration { get; set; }
        public int EntryTypeId { get; set; }
        public int BrandId { get; set; }
        public string Range { get; set; }
        public bool? BrandProductDisplay { get; set; }
        public string ImageLink { get; set; }
    }
}
