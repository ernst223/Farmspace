using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class TradeSafeLog
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
    }
}
