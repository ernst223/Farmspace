using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Setting
    {
        public int SettingId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
