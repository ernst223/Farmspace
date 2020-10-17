using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class BussinessProfile
    {
        public int BusinessId { get; set; }
        public int CountryId { get; set; }
        public string BusinessName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string AreaCode { get; set; }
        public int ProvinceId { get; set; }
        public int TownId { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostCode { get; set; }
        public string WorkTel { get; set; }
        public string WorkFax { get; set; }
        public string CellNo { get; set; }
        public int PrimaryActivityId { get; set; }
        public int BusinessTypeId { get; set; }
        public string RegistrationNo { get; set; }
        public string VatNo { get; set; }
        public string AccountHolder { get; set; }
        public string AccountNumber { get; set; }
        public int BankId { get; set; }
        public string BranchCode { get; set; }
        public int AccountTypeId { get; set; }
    }
}
