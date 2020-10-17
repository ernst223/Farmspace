using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ProductAttachment
    {
        public int ProductAttachmentId { get; set; }
        public int ProductBaseId { get; set; }
        public int ListingFileId { get; set; }

        public ListingFile ListingFile { get; set; }
        public ProductBase ProductBase { get; set; }
    }
}
