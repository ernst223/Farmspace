using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Country
    {
        public Country()
        {
            Address = new HashSet<Address>();
            EntityAddress = new HashSet<EntityAddress>();
            Province = new HashSet<Province>();
            Supplier = new HashSet<Supplier>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }

        public ICollection<Address> Address { get; set; }
        public ICollection<EntityAddress> EntityAddress { get; set; }
        public ICollection<Province> Province { get; set; }
        public ICollection<Supplier> Supplier { get; set; }
    }
}
