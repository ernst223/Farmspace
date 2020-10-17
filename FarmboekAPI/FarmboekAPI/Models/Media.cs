using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Media
    {
        public int MediaId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
        public bool HideImage { get; set; }
        public string WebLink { get; set; }
        public string YoutubeLink { get; set; }
        public int BrandId { get; set; }
        public Nullable<DateTime> MediaDate { get; set; }
    }
}
