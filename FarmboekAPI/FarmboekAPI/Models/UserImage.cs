using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class UserImage
    {
        public int UserImageId { get; set; }
        public int UserId { get; set; }
        public int ListingFileId { get; set; }

        public ListingFile ListingFile { get; set; }
        public UserProfile User { get; set; }
    }
}
