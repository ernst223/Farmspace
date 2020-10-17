using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Models
{
    public class Likes
    {
        public int Id { get; set; }
        public int MediaId { get; set; }
        public string UserId { get; set; }
        public DateTime DateLiked { get; set; }
    }
}
