using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.DTO
{
    public class UserDto
    {
        public string userName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string cellNumber { get; set; }
        public string email { get; set; }
        public string Country { get; set; }
        public string IdNumber { get; set; }
        public string role { get; set; }
        public List<int> Languages { get; set; }
    }
}
