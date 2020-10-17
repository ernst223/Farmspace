using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ProblemBase
    {
        public ProblemBase()
        {
            Problem = new HashSet<Problem>();
            ProblemAttachment = new HashSet<ProblemAttachment>();
            ProblemImage = new HashSet<ProblemImage>();
            Route = new HashSet<Route>();
        }

        public int ProblemBaseId { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string Symptoms { get; set; }
        public string Morbidity { get; set; }
        public string Epidemiology { get; set; }
        public int EntryTypeId { get; set; }

        public EntryType EntryType { get; set; }
        public ICollection<Problem> Problem { get; set; }
        public ICollection<ProblemAttachment> ProblemAttachment { get; set; }
        public ICollection<ProblemImage> ProblemImage { get; set; }
        public ICollection<Route> Route { get; set; }
    }
}
