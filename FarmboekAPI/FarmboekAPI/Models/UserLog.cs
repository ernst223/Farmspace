using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class UserLog
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public DateTime? LoginInTime { get; set; }
        public string Status { get; set; }
        public DateTime? LogOutTime { get; set; }
    }
}
