using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Town
    {
        public Town()
        {
            Address = new HashSet<Address>();
            Auctions = new HashSet<Auctions>();
            Branch = new HashSet<Branch>();
            EntityAddress = new HashSet<EntityAddress>();
            SupplierTown = new HashSet<SupplierTown>();
            TradeAd = new HashSet<TradeAd>();
        }

        public int TownId { get; set; }
        public string TownName { get; set; }
        public string TownCode { get; set; }
        public int? ProvinceProvinceId { get; set; }

        public Province ProvinceProvince { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<Auctions> Auctions { get; set; }
        public ICollection<Branch> Branch { get; set; }
        public ICollection<EntityAddress> EntityAddress { get; set; }
        public ICollection<SupplierTown> SupplierTown { get; set; }
        public ICollection<TradeAd> TradeAd { get; set; }
    }
}
