using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class RouteProblemDto
    {
        public int ProblemBaseId { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string Symptoms { get; set; }
        public string Morbidity { get; set; }
        public string Epidemiology { get; set; }
        public int EntryTypeId { get; set; }
        public string ImageLink { get; set; }
    }
}
