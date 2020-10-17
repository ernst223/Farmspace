using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public int MediaId { get; set; }
        public string UserId { get; set; }
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
