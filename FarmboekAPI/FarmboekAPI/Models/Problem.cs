using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Problem
    {
        public Problem()
        {
            ProblemSymptom = new HashSet<ProblemSymptom>();
            Remedy = new HashSet<Remedy>();
        }

        public int ProblemId { get; set; }
        public int ProblemBaseId { get; set; }
        public int MenuTypeId { get; set; }
        public int RouteId { get; set; }

        public MenuType MenuType { get; set; }
        public ProblemBase ProblemBase { get; set; }
        public Route Route { get; set; }
        public ICollection<ProblemSymptom> ProblemSymptom { get; set; }
        public ICollection<Remedy> Remedy { get; set; }
    }
}
