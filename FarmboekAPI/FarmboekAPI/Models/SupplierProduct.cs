using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class SupplierProduct
    {
        public int SupplierProductId { get; set; }
        public int? ProductBaseId { get; set; }
        public int? EntryId { get; set; }
        public int SupplierId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public bool Display { get; set; }
        public int? RouteRouteId { get; set; }

        public Entry Entry { get; set; }
        public ProductBase ProductBase { get; set; }
        public Route RouteRoute { get; set; }
    }
}
