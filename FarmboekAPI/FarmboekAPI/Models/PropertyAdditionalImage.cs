using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class PropertyAdditionalImage
    {
        public int PropAddId { get; set; }
        public int PropertyAdditionalId { get; set; }
        public int ListingFileId { get; set; }

        public ListingFile ListingFile { get; set; }
        public PropertyAdditional PropertyAdditional { get; set; }
    }
}
