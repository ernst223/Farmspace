using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Contact
    {
        public Contact()
        {
            Brand = new HashSet<Brand>();
        }

        public int ContactId { get; set; }
        public string FullName { get; set; }
        public string TelNumber { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public ICollection<Brand> Brand { get; set; }
    }
}
