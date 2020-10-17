using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class RemedyProblems
    {
        public int RouteId { get; set; }
        public int ProblemBaseId { get; set; }
        public string Description { get; set; }
    }
}
