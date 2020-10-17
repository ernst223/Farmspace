﻿using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Bank
    {
        public Bank()
        {
            TraderProfileSnapshot = new HashSet<TraderProfileSnapshot>();
            UserBankAccount = new HashSet<UserBankAccount>();
        }

        public int BankId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public ICollection<TraderProfileSnapshot> TraderProfileSnapshot { get; set; }
        public ICollection<UserBankAccount> UserBankAccount { get; set; }
    }
}
