using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class GroupsDto
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDesc { get; set; }
        public bool IsCommercial { get; set; }
        public bool IsInformation { get; set; }
    }
}
