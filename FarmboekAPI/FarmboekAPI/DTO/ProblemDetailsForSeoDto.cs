using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class ProblemDetailsForSeoDto
    {
        public int ProblemBaseId { get; set; }
        public string Supergroup { get; set; }
        public string Group { get; set; }
        public string Subgroup { get; set; }
        public string Problemname { get; set; }
    }
}
