using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Entity
    {
        public int EntityId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string CompanyRegistrationId { get; set; }
        public string Sarsnumber { get; set; }
        public string Vatnumber { get; set; }
        public int? CompanyTypeIdCompanyTypeId { get; set; }
        public int? EntityAddressAddressTypeId { get; set; }
        public int? UserTypeIdUserTypeId { get; set; }

        public CompanyType CompanyTypeIdCompanyType { get; set; }
        public EntityAddress EntityAddressAddressType { get; set; }
        public UserType UserTypeIdUserType { get; set; }
    }
}
