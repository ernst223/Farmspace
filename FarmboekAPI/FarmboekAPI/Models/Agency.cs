using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Agency
    {
        public Agency()
        {
            Branch = new HashSet<Branch>();
        }

        public int AgencyId { get; set; }
        public string AgencyName { get; set; }

        public ICollection<Branch> Branch { get; set; }
    }
}
