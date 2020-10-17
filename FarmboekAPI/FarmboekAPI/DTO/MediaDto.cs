using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class MediaDto
    {
        public int MediaId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
        public string WebLink { get; set; }
        public string YoutubeLink { get; set; }
        public Nullable<DateTime> MediaDate { get; set; }
        public bool LikeStatus { get; set; }
        public string LikeCount { get; set; }
        public string ShareCount { get; set; }
        public string CommentCount { get; set; }

        public List<MediaCommentDto> MediaComments { get; set; }
    }
}
