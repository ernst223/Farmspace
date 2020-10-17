using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ProfileType
    {
        public ProfileType()
        {
            UserType = new HashSet<UserType>();
        }

        public int ProfileTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<UserType> UserType { get; set; }
    }
}
