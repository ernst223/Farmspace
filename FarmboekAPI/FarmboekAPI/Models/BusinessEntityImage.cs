using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class BusinessEntityImage
    {
        public int BusinessEntityImageId { get; set; }
        public int BusinessEntityBaseId { get; set; }
        public int ListingFileId { get; set; }

        public BusinessEntityBase BusinessEntityBase { get; set; }
        public ListingFile ListingFile { get; set; }
    }
}
