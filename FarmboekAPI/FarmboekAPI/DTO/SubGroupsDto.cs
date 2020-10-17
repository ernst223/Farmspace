using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class SubGroupsDto
    {
        public int SubGroupId { get; set; }
        public string SubGroupName { get; set; }
        public string SubGroupDesc { get; set; }
        public bool IsCommercial { get; set; }
        public bool IsInformation { get; set; }
    }
}
