using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ListingFile
    {
        public ListingFile()
        {
            AdvertisementImage = new HashSet<AdvertisementImage>();
            BrandImage = new HashSet<BrandImage>();
            BusinessEntityImage = new HashSet<BusinessEntityImage>();
            ChatMessageListingFileImage = new HashSet<ChatMessage>();
            ChatMessageListingFileVideo = new HashSet<ChatMessage>();
            CombineImage = new HashSet<CombineImage>();
            EntryImage = new HashSet<EntryImage>();
            EntryPdf = new HashSet<EntryPdf>();
            EquipmentBase = new HashSet<EquipmentBase>();
            EquipmentImage = new HashSet<EquipmentImage>();
            FarmImage = new HashSet<FarmImage>();
            MarketPdf = new HashSet<MarketPdf>();
            MessageImage = new HashSet<MessageImage>();
            NewsImage = new HashSet<NewsImage>();
            ProblemAttachment = new HashSet<ProblemAttachment>();
            ProblemImage = new HashSet<ProblemImage>();
            ProductAttachment = new HashSet<ProductAttachment>();
            ProductImage = new HashSet<ProductImage>();
            PropertyAdditionalImage = new HashSet<PropertyAdditionalImage>();
            RepresentativeImage = new HashSet<RepresentativeImage>();
            SupplierImage = new HashSet<SupplierImage>();
            TractorBase = new HashSet<TractorBase>();
            TractorImage = new HashSet<TractorImage>();
            TradeAdImage = new HashSet<TradeAdImage>();
            UserImage = new HashSet<UserImage>();
            VehicleBase = new HashSet<VehicleBase>();
            VehicleImage = new HashSet<VehicleImage>();
        }

        public int ListingFileId { get; set; }
        public string FilePath { get; set; }
        public string FileDescription { get; set; }
        public string OriginalFilename { get; set; }
        public string FileType { get; set; }

        public ICollection<AdvertisementImage> AdvertisementImage { get; set; }
        public ICollection<BrandImage> BrandImage { get; set; }
        public ICollection<BusinessEntityImage> BusinessEntityImage { get; set; }
        public ICollection<ChatMessage> ChatMessageListingFileImage { get; set; }
        public ICollection<ChatMessage> ChatMessageListingFileVideo { get; set; }
        public ICollection<CombineImage> CombineImage { get; set; }
        public ICollection<EntryImage> EntryImage { get; set; }
        public ICollection<EntryPdf> EntryPdf { get; set; }
        public ICollection<EquipmentBase> EquipmentBase { get; set; }
        public ICollection<EquipmentImage> EquipmentImage { get; set; }
        public ICollection<FarmImage> FarmImage { get; set; }
        public ICollection<MarketPdf> MarketPdf { get; set; }
        public ICollection<MessageImage> MessageImage { get; set; }
        public ICollection<NewsImage> NewsImage { get; set; }
        public ICollection<ProblemAttachment> ProblemAttachment { get; set; }
        public ICollection<ProblemImage> ProblemImage { get; set; }
        public ICollection<ProductAttachment> ProductAttachment { get; set; }
        public ICollection<ProductImage> ProductImage { get; set; }
        public ICollection<PropertyAdditionalImage> PropertyAdditionalImage { get; set; }
        public ICollection<RepresentativeImage> RepresentativeImage { get; set; }
        public ICollection<SupplierImage> SupplierImage { get; set; }
        public ICollection<TractorBase> TractorBase { get; set; }
        public ICollection<TractorImage> TractorImage { get; set; }
        public ICollection<TradeAdImage> TradeAdImage { get; set; }
        public ICollection<UserImage> UserImage { get; set; }
        public ICollection<VehicleBase> VehicleBase { get; set; }
        public ICollection<VehicleImage> VehicleImage { get; set; }
    }
}
