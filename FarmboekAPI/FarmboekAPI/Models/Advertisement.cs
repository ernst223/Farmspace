using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Advertisement
    {
        public Advertisement()
        {
            AdvertisementImage = new HashSet<AdvertisementImage>();
            AdvertisementRoute = new HashSet<AdvertisementRoute>();
        }

        public int AdvertisementId { get; set; }
        public string Code { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool TopLevelItem { get; set; }
        public bool Active { get; set; }
        public int RankId { get; set; }
        public string AdvertisementLink { get; set; }
        public int? SupplierId { get; set; }
        public int? BrandId { get; set; }
        public int LoadCounter { get; set; }
        public int ClickCounter { get; set; }
        public int TotalLoadCounter { get; set; }
        public bool Home { get; set; }
        public bool SupplierBrandHome { get; set; }
        public bool PhonePage { get; set; }

        public Brand Brand { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<AdvertisementImage> AdvertisementImage { get; set; }
        public ICollection<AdvertisementRoute> AdvertisementRoute { get; set; }
    }
}
