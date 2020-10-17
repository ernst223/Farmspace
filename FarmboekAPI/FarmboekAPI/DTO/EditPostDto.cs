using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class EditPostDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string NewImage { get; set; }
        public string FileName { get; set; }
    }
}
