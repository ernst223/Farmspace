using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmboekAPI.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string cellNumber { get; set; }
        public string Country { get; set; }
        public string IdNumber { get; set; }
        public string role { get; set; }
        public string SodiumHash { get; set; }
    }
}
