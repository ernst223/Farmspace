using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Route
    {
        public Route()
        {
            AdvertisementRoute = new HashSet<AdvertisementRoute>();
            BusinessEntity = new HashSet<BusinessEntity>();
            ChatGroup = new HashSet<ChatGroup>();
            Combine = new HashSet<Combine>();
            EntryHeader = new HashSet<EntryHeader>();
            Equipment = new HashSet<Equipment>();
            Farm = new HashSet<Farm>();
            MarketRoute = new HashSet<MarketRoute>();
            Problem = new HashSet<Problem>();
            Product = new HashSet<Product>();
            SupplierProduct = new HashSet<SupplierProduct>();
            Tractor = new HashSet<Tractor>();
            UserRoute = new HashSet<UserRoute>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int RouteId { get; set; }
        public int SuperGroupId { get; set; }
        public int? GroupId { get; set; }
        public int? SubGroupId { get; set; }
        public int? SectionId { get; set; }
        public int? ViewCount { get; set; }
        public int? ProblemBaseId { get; set; }

        public Groups Group { get; set; }
        public ProblemBase ProblemBase { get; set; }
        public Section Section { get; set; }
        public SubGroups SubGroup { get; set; }
        public SuperGroups SuperGroup { get; set; }
        public ICollection<AdvertisementRoute> AdvertisementRoute { get; set; }
        public ICollection<BusinessEntity> BusinessEntity { get; set; }
        public ICollection<ChatGroup> ChatGroup { get; set; }
        public ICollection<Combine> Combine { get; set; }
        public ICollection<EntryHeader> EntryHeader { get; set; }
        public ICollection<Equipment> Equipment { get; set; }
        public ICollection<Farm> Farm { get; set; }
        public ICollection<MarketRoute> MarketRoute { get; set; }
        public ICollection<Problem> Problem { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<SupplierProduct> SupplierProduct { get; set; }
        public ICollection<Tractor> Tractor { get; set; }
        public ICollection<UserRoute> UserRoute { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
