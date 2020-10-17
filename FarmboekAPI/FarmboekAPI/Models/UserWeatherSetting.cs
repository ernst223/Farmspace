using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class UserWeatherSetting
    {
        public int UserWeatherSettingId { get; set; }
        public int UserId { get; set; }
        public string DefaultLongitude { get; set; }
        public string DefaultLatitude { get; set; }
        public string LocationName { get; set; }
    }
}
