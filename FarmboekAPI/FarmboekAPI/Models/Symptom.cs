using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Symptom
    {
        public Symptom()
        {
            ProblemSymptom = new HashSet<ProblemSymptom>();
        }

        public int SymptomId { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }

        public ICollection<ProblemSymptom> ProblemSymptom { get; set; }
    }
}
