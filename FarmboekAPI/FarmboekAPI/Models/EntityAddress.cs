using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class EntityAddress
    {
        public EntityAddress()
        {
            Entity = new HashSet<Entity>();
        }

        public int AddressTypeId { get; set; }
        public string CellNumber { get; set; }
        public string PostalAddress { get; set; }
        public string ResidentialAddress { get; set; }
        public int? PostalCountryIdCountryId { get; set; }
        public int? PostalProvinceIdProvinceId { get; set; }
        public int? PostalTownIdTownId { get; set; }

        public Country PostalCountryIdCountry { get; set; }
        public Province PostalProvinceIdProvince { get; set; }
        public Town PostalTownIdTown { get; set; }
        public ICollection<Entity> Entity { get; set; }
    }
}
