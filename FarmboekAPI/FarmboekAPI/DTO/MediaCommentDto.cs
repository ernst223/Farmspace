using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class MediaCommentDto
    {
        public int CommentId { get; set; }
        public DateTime CommentDate { get; set; }
        public string theComment { get; set; }
        public string userId { get; set; }
        public string userName { get; set; }
    }
}
