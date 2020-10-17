using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Remedy
    {
        public int RemedyId { get; set; }
        public int ProblemId { get; set; }
        public int ProductBaseId { get; set; }

        public Problem Problem { get; set; }
        public ProductBase ProductBase { get; set; }
    }
}
