using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class CensoredWord
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
