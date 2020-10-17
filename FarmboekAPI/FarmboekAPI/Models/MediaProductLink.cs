using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Models
{
    public class MediaProductLink
    {
        public int Id { get; set; }
        public int MediaId { get; set; }
        public int EntryId { get; set; }
    }
}
