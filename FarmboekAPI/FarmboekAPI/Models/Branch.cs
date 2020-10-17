using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public int ProvinceId { get; set; }
        public int TownId { get; set; }
        public string Suburb { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostalCode { get; set; }
        public string ContactNumber { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public int AgencyId { get; set; }

        public Agency Agency { get; set; }
        public Province Province { get; set; }
        public Town Town { get; set; }
    }
}
