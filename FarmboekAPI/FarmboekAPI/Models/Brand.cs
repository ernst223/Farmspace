using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Advertisement = new HashSet<Advertisement>();
            BrandImage = new HashSet<BrandImage>();
            CombineBase = new HashSet<CombineBase>();
            Entry = new HashSet<Entry>();
            EquipmentBase = new HashSet<EquipmentBase>();
            LinkRequest = new HashSet<LinkRequest>();
            Manager = new HashSet<Manager>();
            ProductBase = new HashSet<ProductBase>();
            RelatedBrandBrand = new HashSet<RelatedBrand>();
            RelatedBrandBrandBrand = new HashSet<RelatedBrand>();
            RelatedBrandChildBrand = new HashSet<RelatedBrand>();
            Representative = new HashSet<Representative>();
            SupplierBrand = new HashSet<SupplierBrand>();
            SupplierBrand1 = new HashSet<SupplierBrand1>();
            TractorBase = new HashSet<TractorBase>();
            VehicleBase = new HashSet<VehicleBase>();
            VehicleTradeAd = new HashSet<VehicleTradeAd>();
        }

        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string Address { get; set; }
        public int? ContactId { get; set; }
        public string AccountNo { get; set; }
        public bool IsActive { get; set; }
        public bool HasPaid { get; set; }

        public Contact Contact { get; set; }
        public ICollection<Advertisement> Advertisement { get; set; }
        public ICollection<BrandImage> BrandImage { get; set; }
        public ICollection<CombineBase> CombineBase { get; set; }
        public ICollection<Entry> Entry { get; set; }
        public ICollection<EquipmentBase> EquipmentBase { get; set; }
        public ICollection<LinkRequest> LinkRequest { get; set; }
        public ICollection<Manager> Manager { get; set; }
        public ICollection<ProductBase> ProductBase { get; set; }
        public ICollection<RelatedBrand> RelatedBrandBrand { get; set; }
        public ICollection<RelatedBrand> RelatedBrandBrandBrand { get; set; }
        public ICollection<RelatedBrand> RelatedBrandChildBrand { get; set; }
        public ICollection<Representative> Representative { get; set; }
        public ICollection<SupplierBrand> SupplierBrand { get; set; }
        public ICollection<SupplierBrand1> SupplierBrand1 { get; set; }
        public ICollection<TractorBase> TractorBase { get; set; }
        public ICollection<VehicleBase> VehicleBase { get; set; }
        public ICollection<VehicleTradeAd> VehicleTradeAd { get; set; }
    }
}
