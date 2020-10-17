using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class UserBankAccount
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public int UserId { get; set; }
        public int BankId { get; set; }
        public int BankAccountTypeId { get; set; }

        public Bank Bank { get; set; }
        public BankAccountType BankAccountType { get; set; }
        public UserProfile User { get; set; }
    }
}
