using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class EntryDetailsForSeoDto
    {
        public int Id { get; set; }
        public string Supergroup { get; set; }
        public string Group { get; set; }
        public string Subgroup { get; set; }
        public string Brand { get; set; }
        public string ProductName { get; set; }
    }
}
