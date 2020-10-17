using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class SupplierDto
    {
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
        public string ImageName { get; set; }
    }
}
