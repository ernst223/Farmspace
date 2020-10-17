using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class TradeAd
    {
        public TradeAd()
        {
            CropTradeAd = new HashSet<CropTradeAd>();
            EquipmentTradeAd = new HashSet<EquipmentTradeAd>();
            GameAndLivestockTradeAd = new HashSet<GameAndLivestockTradeAd>();
            InfrastructureTradeAd = new HashSet<InfrastructureTradeAd>();
            TradeAdContactLog = new HashSet<TradeAdContactLog>();
            TradeAdImage = new HashSet<TradeAdImage>();
            TradeAdTransaction = new HashSet<TradeAdTransaction>();
            UserFavouriteTradeAd = new HashSet<UserFavouriteTradeAd>();
            VehicleTradeAd = new HashSet<VehicleTradeAd>();
        }

        public int Id { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public string AdditionalInformation { get; set; }
        public double Price { get; set; }
        public bool PriceIncludesVat { get; set; }
        public DateTime Created { get; set; }
        public string Slug { get; set; }
        public int Status { get; set; }
        public bool AcceptTradeSafe { get; set; }
        public int? FeeAllocation { get; set; }
        public int SellerId { get; set; }
        public int ProvinceId { get; set; }
        public int TownId { get; set; }
        public int SuperGroupId { get; set; }
        public int GroupId { get; set; }
        public int? SubGroupId { get; set; }
        public int CompletionDays { get; set; }

        public Groups Group { get; set; }
        public Province Province { get; set; }
        public TraderProfileSnapshot Seller { get; set; }
        public SubGroups SubGroup { get; set; }
        public SuperGroups SuperGroup { get; set; }
        public Town Town { get; set; }
        public ICollection<CropTradeAd> CropTradeAd { get; set; }
        public ICollection<EquipmentTradeAd> EquipmentTradeAd { get; set; }
        public ICollection<GameAndLivestockTradeAd> GameAndLivestockTradeAd { get; set; }
        public ICollection<InfrastructureTradeAd> InfrastructureTradeAd { get; set; }
        public ICollection<TradeAdContactLog> TradeAdContactLog { get; set; }
        public ICollection<TradeAdImage> TradeAdImage { get; set; }
        public ICollection<TradeAdTransaction> TradeAdTransaction { get; set; }
        public ICollection<UserFavouriteTradeAd> UserFavouriteTradeAd { get; set; }
        public ICollection<VehicleTradeAd> VehicleTradeAd { get; set; }
    }
}
