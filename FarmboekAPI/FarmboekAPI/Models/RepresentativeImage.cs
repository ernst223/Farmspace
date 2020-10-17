using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class RepresentativeImage
    {
        public int RepresentativeImageId { get; set; }
        public int RepresentativeId { get; set; }
        public int ListingFileId { get; set; }

        public ListingFile ListingFile { get; set; }
        public Representative Representative { get; set; }
    }
}
