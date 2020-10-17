using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Models
{
    public class MediaRemediesLink
    {
        public int Id { get; set; }
        public int MediaId { get; set; }
        public int ProductBaseId { get; set; }
    }
}
