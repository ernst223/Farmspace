using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class SupplierImage
    {
        public int SupplierImageId { get; set; }
        public int SupplierId { get; set; }
        public int ListingFileId { get; set; }

        public ListingFile ListingFile { get; set; }
        public Supplier Supplier { get; set; }
    }
}
