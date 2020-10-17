using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class AccessType
    {
        public AccessType()
        {
            UserType = new HashSet<UserType>();
        }

        public int AccessTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<UserType> UserType { get; set; }
    }
}
