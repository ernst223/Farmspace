using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            UserType = new HashSet<UserType>();
        }

        public int EmployeeTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<UserType> UserType { get; set; }
    }
}
