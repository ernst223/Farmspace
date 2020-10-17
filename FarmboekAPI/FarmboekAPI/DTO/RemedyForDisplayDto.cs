using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class RemedyForDisplayDto
    {
        public int ProductBaseId { get; set; }
        public string ProductName { get; set; }
        public string Formulation { get; set; }
        public string Concentration { get; set; }
        public string Registration { get; set; }
        public int BrandId { get; set; }
        public string Brand { get; set; }
        public string Range { get; set; }
    }
}
