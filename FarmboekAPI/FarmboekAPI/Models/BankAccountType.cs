using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class BankAccountType
    {
        public BankAccountType()
        {
            TraderProfileSnapshot = new HashSet<TraderProfileSnapshot>();
            UserBankAccount = new HashSet<UserBankAccount>();
        }

        public int BankAccountTypeId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public ICollection<TraderProfileSnapshot> TraderProfileSnapshot { get; set; }
        public ICollection<UserBankAccount> UserBankAccount { get; set; }
    }
}
