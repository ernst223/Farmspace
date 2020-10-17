using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class BrandDto
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string Address { get; set; }
        public int? ContactId { get; set; }
        public string AccountNo { get; set; }
        public bool IsActive { get; set; }
        public bool HasPaid { get; set; }
        public string ImageName { get; set; }
    }
}
