using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ProblemSymptom
    {
        public int ProblemSymptomId { get; set; }
        public int ProblemProblemId { get; set; }
        public int SymptomSymptomId { get; set; }

        public Problem ProblemProblem { get; set; }
        public Symptom SymptomSymptom { get; set; }
    }
}
