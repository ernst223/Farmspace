using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class VehicleTradeAd
    {
        public int Id { get; set; }
        public string Range { get; set; }
        public string Model { get; set; }
        public int YearModel { get; set; }
        public string Colour { get; set; }
        public int Mileage { get; set; }
        public bool ServiceHistory { get; set; }
        public int BrandId { get; set; }
        public int TradeAdId { get; set; }
        public bool? IsOther { get; set; }

        public Brand Brand { get; set; }
        public TradeAd TradeAd { get; set; }
    }
}
