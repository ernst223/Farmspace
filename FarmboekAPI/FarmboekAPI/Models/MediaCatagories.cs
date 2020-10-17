using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Models
{
    public partial class MediaCatagories
    {
        public int Id { get; set; }
        public int MediaId { get; set; }
        public int CatagoryId { get; set; }
    }
}
