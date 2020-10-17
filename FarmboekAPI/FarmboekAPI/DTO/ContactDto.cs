using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class ContactDto
    {
        public int ContactId { get; set; }
        public string FullName { get; set; }
        public string TelNumber { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
}
