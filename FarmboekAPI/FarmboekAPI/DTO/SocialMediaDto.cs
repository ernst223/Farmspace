using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class SocialMediaDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<DateTime> MediaDate { get; set; }
        public string WebLink { get; set; }
        public string YoutubeLink { get; set; }
        public string TheImage { get; set; }
        public string TheImageName { get; set; }
        public int Brandid { get; set; }
        public List<MediaCatagoriesDto> mediaCatagories { get; set; }
        public List<MediaProductLinkDto> mediaProducts { get; set; }
        public List<MediaRemediesLinkDto> mediaRemedies { get; set; }
        public List<int> Languages { get; set; }
        public bool hideImage { get; set; }
    }
}
