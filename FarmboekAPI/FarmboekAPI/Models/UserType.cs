using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class UserType
    {
        public UserType()
        {
            Entity = new HashSet<Entity>();
            UserProfile = new HashSet<UserProfile>();
        }

        public int UserTypeId { get; set; }
        public int? AccessLevelAccessTypeId { get; set; }
        public int? EmployeeTypeEmployeeTypeId { get; set; }
        public int? ProfileTypeProfileTypeId { get; set; }

        public AccessType AccessLevelAccessType { get; set; }
        public EmployeeType EmployeeTypeEmployeeType { get; set; }
        public ProfileType ProfileTypeProfileType { get; set; }
        public ICollection<Entity> Entity { get; set; }
        public ICollection<UserProfile> UserProfile { get; set; }
    }
}
