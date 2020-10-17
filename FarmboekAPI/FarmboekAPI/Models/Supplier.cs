using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Advertisement = new HashSet<Advertisement>();
            LinkRequest = new HashSet<LinkRequest>();
            Manager = new HashSet<Manager>();
            Representative = new HashSet<Representative>();
            SupplierBrand = new HashSet<SupplierBrand>();
            SupplierBrand1 = new HashSet<SupplierBrand1>();
            SupplierImage = new HashSet<SupplierImage>();
            SupplierMunicipalDistrict = new HashSet<SupplierMunicipalDistrict>();
            SupplierTown = new HashSet<SupplierTown>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierDesc { get; set; }
        public string SupplierAddress1 { get; set; }
        public string SupplierAddress2 { get; set; }
        public string SupplierCity { get; set; }
        public int? ProvinceId { get; set; }
        public int? CountryId { get; set; }
        public string SupplierPostCode { get; set; }
        public string SupplierTel1 { get; set; }
        public string SupplierTel2 { get; set; }
        public string AccountNo { get; set; }
        public bool IsActive { get; set; }
        public bool HasPaid { get; set; }

        public Country Country { get; set; }
        public Province Province { get; set; }
        public ICollection<Advertisement> Advertisement { get; set; }
        public ICollection<LinkRequest> LinkRequest { get; set; }
        public ICollection<Manager> Manager { get; set; }
        public ICollection<Representative> Representative { get; set; }
        public ICollection<SupplierBrand> SupplierBrand { get; set; }
        public ICollection<SupplierBrand1> SupplierBrand1 { get; set; }
        public ICollection<SupplierImage> SupplierImage { get; set; }
        public ICollection<SupplierMunicipalDistrict> SupplierMunicipalDistrict { get; set; }
        public ICollection<SupplierTown> SupplierTown { get; set; }
    }
}
