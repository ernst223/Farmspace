using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Province
    {
        public Province()
        {
            Address = new HashSet<Address>();
            Auctions = new HashSet<Auctions>();
            Branch = new HashSet<Branch>();
            EntityAddress = new HashSet<EntityAddress>();
            MunicipalDistrict = new HashSet<MunicipalDistrict>();
            RepresentativeProvince = new HashSet<RepresentativeProvince>();
            Supplier = new HashSet<Supplier>();
            Town = new HashSet<Town>();
            TradeAd = new HashSet<TradeAd>();
        }

        public int ProvinceId { get; set; }
        public int CountryId { get; set; }
        public string ProvinceName { get; set; }
        public string ProvinceCode { get; set; }

        public Country Country { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<Auctions> Auctions { get; set; }
        public ICollection<Branch> Branch { get; set; }
        public ICollection<EntityAddress> EntityAddress { get; set; }
        public ICollection<MunicipalDistrict> MunicipalDistrict { get; set; }
        public ICollection<RepresentativeProvince> RepresentativeProvince { get; set; }
        public ICollection<Supplier> Supplier { get; set; }
        public ICollection<Town> Town { get; set; }
        public ICollection<TradeAd> TradeAd { get; set; }
    }
}
