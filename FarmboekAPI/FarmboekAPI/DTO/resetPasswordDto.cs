using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class resetPasswordDto
    {
        public string username { get; set; }
        public string password { get; set; }
        public string token { get; set; }
    }
}
