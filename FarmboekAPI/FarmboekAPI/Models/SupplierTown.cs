using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class SupplierTown
    {
        public int SupplierTownId { get; set; }
        public int SupplierId { get; set; }
        public int TownId { get; set; }

        public Supplier Supplier { get; set; }
        public Town Town { get; set; }
    }
}
