using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class ProblemForDisplayDto
    {
        public int ProblemBaseId { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string Symptoms { get; set; }
        public string Morbidiy { get; set; }
        public string Epidemiology { get; set; }
    }
}
