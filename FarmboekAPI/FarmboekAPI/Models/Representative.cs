using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Representative
    {
        public Representative()
        {
            RepresentativeImage = new HashSet<RepresentativeImage>();
            RepresentativeProvince = new HashSet<RepresentativeProvince>();
        }

        public int RepresentativeId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int? BrandId { get; set; }
        public int? SupplierId { get; set; }

        public Brand Brand { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<RepresentativeImage> RepresentativeImage { get; set; }
        public ICollection<RepresentativeProvince> RepresentativeProvince { get; set; }
    }
}
