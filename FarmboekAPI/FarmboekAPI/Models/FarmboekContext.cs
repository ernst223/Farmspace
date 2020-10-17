using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FarmboekAPI.Models
{
    public class FarmboekContext : IdentityDbContext<User>
    {
        public FarmboekContext()
        {
        }

        public FarmboekContext(DbContextOptions<FarmboekContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public virtual DbSet<MediaCatagories> MediaCatagories { get; set; }
        public virtual DbSet<MediaProductLink> MediaProductLinks { get; set; }
        public virtual DbSet<MediaRemediesLink> MediaRemediesLinks { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<UserLanguages> UserLanguages { get; set; }
        public virtual DbSet<MediaLanguages> MediaLanguages { get; set; }
        public virtual DbSet<SocialMediaCatagory> SocialMediaCatagories { get; set; }
        public virtual DbSet<Likes> Likes { get; set; }
        public virtual DbSet<Shares> Shares { get; set; }
        public virtual DbSet<AccessType> AccessType { get; set; }
        public virtual DbSet<ActiveIngredient> ActiveIngredient { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Advertisement> Advertisement { get; set; }
        public virtual DbSet<AdvertisementImage> AdvertisementImage { get; set; }
        public virtual DbSet<AdvertisementRoute> AdvertisementRoute { get; set; }
        public virtual DbSet<Agency> Agency { get; set; }
        public virtual DbSet<Attribute> Attribute { get; set; }
        public virtual DbSet<AuctionCategory> AuctionCategory { get; set; }
        public virtual DbSet<AuctionItems> AuctionItems { get; set; }
        public virtual DbSet<Auctions> Auctions { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankAccountType> BankAccountType { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<BrandImage> BrandImage { get; set; }
        public virtual DbSet<BusinessEntity> BusinessEntity { get; set; }
        public virtual DbSet<BusinessEntityBase> BusinessEntityBase { get; set; }
        public virtual DbSet<BusinessEntityImage> BusinessEntityImage { get; set; }
        public virtual DbSet<BusinessEntityType> BusinessEntityType { get; set; }
        public virtual DbSet<BusinessEntityTypeAssignment> BusinessEntityTypeAssignment { get; set; }
        public virtual DbSet<BusinessType> BusinessType { get; set; }
        public virtual DbSet<BussinessProfile> BussinessProfile { get; set; }
        public virtual DbSet<CensoredWord> CensoredWord { get; set; }
        public virtual DbSet<ChatGroup> ChatGroup { get; set; }
        public virtual DbSet<ChatGroupUserBan> ChatGroupUserBan { get; set; }
        public virtual DbSet<ChatMessage> ChatMessage { get; set; }
        public virtual DbSet<ClassifiedAd> ClassifiedAd { get; set; }
        public virtual DbSet<ClassifiedAdRegion> ClassifiedAdRegion { get; set; }
        public virtual DbSet<ClassifiedsCategories> ClassifiedsCategories { get; set; }
        public virtual DbSet<Combine> Combine { get; set; }
        public virtual DbSet<CombineBase> CombineBase { get; set; }
        public virtual DbSet<CombineImage> CombineImage { get; set; }
        public virtual DbSet<CompanyType> CompanyType { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CropTradeAd> CropTradeAd { get; set; }
        public virtual DbSet<EmployeeType> EmployeeType { get; set; }
        public virtual DbSet<Entity> Entity { get; set; }
        public virtual DbSet<EntityAddress> EntityAddress { get; set; }
        public virtual DbSet<Entry> Entry { get; set; }
        public virtual DbSet<EntryAttribute> EntryAttribute { get; set; }
        public virtual DbSet<EntryHeader> EntryHeader { get; set; }
        public virtual DbSet<EntryImage> EntryImage { get; set; }
        public virtual DbSet<EntryPdf> EntryPdf { get; set; }
        public virtual DbSet<EntryType> EntryType { get; set; }
        public virtual DbSet<EntryTypeTemplate> EntryTypeTemplate { get; set; }
        public virtual DbSet<EntryTypeTemplateAttribute> EntryTypeTemplateAttribute { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentBase> EquipmentBase { get; set; }
        public virtual DbSet<EquipmentFarm> EquipmentFarm { get; set; }
        public virtual DbSet<EquipmentImage> EquipmentImage { get; set; }
        public virtual DbSet<EquipmentSpecification> EquipmentSpecification { get; set; }
        public virtual DbSet<EquipmentTradeAd> EquipmentTradeAd { get; set; }
        public virtual DbSet<Farm> Farm { get; set; }
        public virtual DbSet<FarmImage> FarmImage { get; set; }
        public virtual DbSet<FarmInfrastructure> FarmInfrastructure { get; set; }
        public virtual DbSet<FarmType> FarmType { get; set; }
        public virtual DbSet<FarmWaterRight> FarmWaterRight { get; set; }
        public virtual DbSet<Function> Function { get; set; }
        public virtual DbSet<GameAndLivestockTradeAd> GameAndLivestockTradeAd { get; set; }
        public virtual DbSet<GroupChatMessage> GroupChatMessage { get; set; }
        public virtual DbSet<GroupList> GroupList { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<GroupSubGroups> GroupSubGroups { get; set; }
        public virtual DbSet<GroupSuperGroups> GroupSuperGroups { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Infrastructure> Infrastructure { get; set; }
        public virtual DbSet<InfrastructureTradeAd> InfrastructureTradeAd { get; set; }
        public virtual DbSet<Institution> Institution { get; set; }
        public virtual DbSet<LinkRequest> LinkRequest { get; set; }
        public virtual DbSet<LinkRequestType> LinkRequestType { get; set; }
        public virtual DbSet<ListingEntry> ListingEntry { get; set; }
        public virtual DbSet<ListingFile> ListingFile { get; set; }
        public virtual DbSet<ListType> ListType { get; set; }
        public virtual DbSet<ManagementGroup> ManagementGroup { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Market> Market { get; set; }
        public virtual DbSet<MarketPdf> MarketPdf { get; set; }
        public virtual DbSet<MarketRoute> MarketRoute { get; set; }
        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<MenuType> MenuType { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MessageImage> MessageImage { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<MunicipalDistrict> MunicipalDistrict { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsCat> NewsCat { get; set; }
        public virtual DbSet<NewsImage> NewsImage { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<Problem> Problem { get; set; }
        public virtual DbSet<ProblemAttachment> ProblemAttachment { get; set; }
        public virtual DbSet<ProblemBase> ProblemBase { get; set; }
        public virtual DbSet<ProblemImage> ProblemImage { get; set; }
        public virtual DbSet<ProblemSymptom> ProblemSymptom { get; set; }
        public virtual DbSet<ProblemType> ProblemType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductActiveIngredient> ProductActiveIngredient { get; set; }
        public virtual DbSet<ProductAttachment> ProductAttachment { get; set; }
        public virtual DbSet<ProductBase> ProductBase { get; set; }
        public virtual DbSet<ProductBaseRemedyType> ProductBaseRemedyType { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<ProductSpecification> ProductSpecification { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<ProfileType> ProfileType { get; set; }
        public virtual DbSet<PropertyAdditional> PropertyAdditional { get; set; }
        public virtual DbSet<PropertyAdditionalImage> PropertyAdditionalImage { get; set; }
        public virtual DbSet<PropertyCategory> PropertyCategory { get; set; }
        public virtual DbSet<PropertyListing> PropertyListing { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<RelatedBrand> RelatedBrand { get; set; }
        public virtual DbSet<Remedy> Remedy { get; set; }
        public virtual DbSet<RemedyType> RemedyType { get; set; }
        public virtual DbSet<Representative> Representative { get; set; }
        public virtual DbSet<RepresentativeImage> RepresentativeImage { get; set; }
        public virtual DbSet<RepresentativeProvince> RepresentativeProvince { get; set; }
        public virtual DbSet<RoleFunction> RoleFunction { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<Specification> Specification { get; set; }
        public virtual DbSet<SubGroupGroupList> SubGroupGroupList { get; set; }
        public virtual DbSet<SubGroups> SubGroups { get; set; }
        public virtual DbSet<SuperGroups> SuperGroups { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierBrand> SupplierBrand { get; set; }
        public virtual DbSet<SupplierBrand1> SupplierBrand1 { get; set; }
        public virtual DbSet<SupplierImage> SupplierImage { get; set; }
        public virtual DbSet<SupplierMunicipalDistrict> SupplierMunicipalDistrict { get; set; }
        public virtual DbSet<SupplierProduct> SupplierProduct { get; set; }
        public virtual DbSet<SupplierTown> SupplierTown { get; set; }
        public virtual DbSet<Symptom> Symptom { get; set; }
        public virtual DbSet<TopLevelItem> TopLevelItem { get; set; }
        public virtual DbSet<Town> Town { get; set; }
        public virtual DbSet<Tractor> Tractor { get; set; }
        public virtual DbSet<TractorBase> TractorBase { get; set; }
        public virtual DbSet<TractorImage> TractorImage { get; set; }
        public virtual DbSet<TradeAd> TradeAd { get; set; }
        public virtual DbSet<TradeAdContactLog> TradeAdContactLog { get; set; }
        public virtual DbSet<TradeAdImage> TradeAdImage { get; set; }
        public virtual DbSet<TradeAdTransaction> TradeAdTransaction { get; set; }
        public virtual DbSet<TraderProfileSnapshot> TraderProfileSnapshot { get; set; }
        public virtual DbSet<TradeSafeLog> TradeSafeLog { get; set; }
        public virtual DbSet<UserBankAccount> UserBankAccount { get; set; }
        public virtual DbSet<UserFavouriteTradeAd> UserFavouriteTradeAd { get; set; }
        public virtual DbSet<UserImage> UserImage { get; set; }
        public virtual DbSet<UserIndustries> UserIndustries { get; set; }
        public virtual DbSet<UserLog> UserLog { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<UserProfileChatMessage> UserProfileChatMessage { get; set; }
        public virtual DbSet<UserRoute> UserRoute { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<UserWeatherSetting> UserWeatherSetting { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleBase> VehicleBase { get; set; }
        public virtual DbSet<VehicleImage> VehicleImage { get; set; }
        public virtual DbSet<VehicleTradeAd> VehicleTradeAd { get; set; }
        public virtual DbSet<WaterRights> WaterRights { get; set; }
        public virtual DbSet<WebpagesMembership> WebpagesMembership { get; set; }
        public virtual DbSet<WebpagesOauthMembership> WebpagesOauthMembership { get; set; }
        public virtual DbSet<WebpagesRoles> WebpagesRoles { get; set; }
        public virtual DbSet<WebpagesUsersInRoles> WebpagesUsersInRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=ws1.dankospark.co.za\ws1staging,5768;Initial Catalog=Farmboek;Persist Security Info=True;User id=bshb;password=Henno777?;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ActiveIngredient>(entity =>
            {
                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.AddressTypeId);

                entity.HasIndex(e => e.PostalCountryIdCountryId)
                    .HasName("IX_PostalCountryId_CountryId");

                entity.HasIndex(e => e.PostalProvinceIdProvinceId)
                    .HasName("IX_PostalProvinceId_ProvinceId");

                entity.HasIndex(e => e.PostalTownIdTownId)
                    .HasName("IX_PostalTownId_TownId");

                entity.Property(e => e.PostalCountryIdCountryId).HasColumnName("PostalCountryId_CountryId");

                entity.Property(e => e.PostalProvinceIdProvinceId).HasColumnName("PostalProvinceId_ProvinceId");

                entity.Property(e => e.PostalTownIdTownId).HasColumnName("PostalTownId_TownId");

                entity.Property(e => e.UserId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PostalCountryIdCountry)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.PostalCountryIdCountryId)
                    .HasConstraintName("FK_dbo.Address_dbo.Country_PostalCountryId_CountryId");

                entity.HasOne(d => d.PostalProvinceIdProvince)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.PostalProvinceIdProvinceId)
                    .HasConstraintName("FK_dbo.Address_dbo.Province_PostalProvinceId_ProvinceId");

                entity.HasOne(d => d.PostalTownIdTown)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.PostalTownIdTownId)
                    .HasConstraintName("FK_dbo.Address_dbo.Town_PostalTownId_TownId");
            });

            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TotalLoadCounter).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_dbo.Advertisement_dbo.Brand_BrandId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.Advertisement_dbo.Supplier_SupplierId");
            });

            modelBuilder.Entity<AdvertisementImage>(entity =>
            {
                entity.HasIndex(e => e.AdvertisementId)
                    .HasName("IX_AdvertisementId");

                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasOne(d => d.Advertisement)
                    .WithMany(p => p.AdvertisementImage)
                    .HasForeignKey(d => d.AdvertisementId)
                    .HasConstraintName("FK_dbo.AdvertisementImage_dbo.Advertisement_AdvertisementId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.AdvertisementImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.AdvertisementImage_dbo.ListingFile_ListingFileId");
            });

            modelBuilder.Entity<AdvertisementRoute>(entity =>
            {
                entity.HasIndex(e => e.AdvertisementId)
                    .HasName("IX_AdvertisementId");

                entity.HasIndex(e => e.RouteId)
                    .HasName("IX_RouteId");

                entity.Property(e => e.LoadCounter).HasColumnName("loadCounter");

                entity.HasOne(d => d.Advertisement)
                    .WithMany(p => p.AdvertisementRoute)
                    .HasForeignKey(d => d.AdvertisementId)
                    .HasConstraintName("FK_dbo.AdvertisementRoute_dbo.Advertisement_AdvertisementId");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.AdvertisementRoute)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_dbo.AdvertisementRoute_dbo.Route_RouteId");
            });

            modelBuilder.Entity<Attribute>(entity =>
            {
                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");
            });

            modelBuilder.Entity<AuctionItems>(entity =>
            {
                entity.HasKey(e => e.AuctionItemId);

                entity.HasIndex(e => e.AuctionId)
                    .HasName("IX_AuctionId");

                entity.HasOne(d => d.Auction)
                    .WithMany(p => p.AuctionItems)
                    .HasForeignKey(d => d.AuctionId)
                    .HasConstraintName("FK_dbo.AuctionItems_dbo.Auctions_AuctionId");
            });

            modelBuilder.Entity<Auctions>(entity =>
            {
                entity.HasKey(e => e.AuctionId);

                entity.HasIndex(e => e.AuctionCategoryId)
                    .HasName("IX_AuctionCategoryId");

                entity.HasIndex(e => e.ProvinceId)
                    .HasName("IX_ProvinceId");

                entity.HasIndex(e => e.TownId)
                    .HasName("IX_TownId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.AuctionDate).HasColumnType("datetime");

                entity.HasOne(d => d.AuctionCategory)
                    .WithMany(p => p.Auctions)
                    .HasForeignKey(d => d.AuctionCategoryId)
                    .HasConstraintName("FK_dbo.Auctions_dbo.AuctionCategory_AuctionCategoryId");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Auctions)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_dbo.Auctions_dbo.Province_ProvinceId");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Auctions)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_dbo.Auctions_dbo.Town_TownId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Auctions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Auctions_dbo.UserProfile_UserId");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasIndex(e => e.AgencyId)
                    .HasName("IX_AgencyId");

                entity.HasIndex(e => e.ProvinceId)
                    .HasName("IX_ProvinceId");

                entity.HasIndex(e => e.TownId)
                    .HasName("IX_TownId");

                entity.Property(e => e.AddressLine1).HasColumnName("Address_Line1");

                entity.Property(e => e.AddressLine2).HasColumnName("Address_Line2");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK_dbo.Branch_dbo.Agency_AgencyId");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_dbo.Branch_dbo.Province_ProvinceId");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_dbo.Branch_dbo.Town_TownId");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasIndex(e => e.ContactId)
                    .HasName("IX_ContactId");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Brand)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_dbo.Brand_dbo.Contact_ContactId");
            });

            modelBuilder.Entity<BrandImage>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandId");

                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.BrandImage)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_dbo.BrandImage_dbo.Brand_BrandId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.BrandImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.BrandImage_dbo.ListingFile_ListingFileId");
            });

            modelBuilder.Entity<BusinessEntity>(entity =>
            {
                entity.HasIndex(e => e.BusinessEntityBaseId)
                    .HasName("IX_BusinessEntityBaseId");

                entity.HasIndex(e => e.RouteId)
                    .HasName("IX_RouteId");

                entity.HasOne(d => d.BusinessEntityBase)
                    .WithMany(p => p.BusinessEntity)
                    .HasForeignKey(d => d.BusinessEntityBaseId)
                    .HasConstraintName("FK_dbo.BusinessEntity_dbo.BusinessEntityBase_BusinessEntityBaseId");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.BusinessEntity)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_dbo.BusinessEntity_dbo.Route_RouteId");
            });

            modelBuilder.Entity<BusinessEntityBase>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<BusinessEntityImage>(entity =>
            {
                entity.HasIndex(e => e.BusinessEntityBaseId)
                    .HasName("IX_BusinessEntityBaseId");

                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasOne(d => d.BusinessEntityBase)
                    .WithMany(p => p.BusinessEntityImage)
                    .HasForeignKey(d => d.BusinessEntityBaseId)
                    .HasConstraintName("FK_dbo.BusinessEntityImage_dbo.BusinessEntityBase_BusinessEntityBaseId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.BusinessEntityImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.BusinessEntityImage_dbo.ListingFile_ListingFileId");
            });

            modelBuilder.Entity<BusinessEntityType>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<BusinessEntityTypeAssignment>(entity =>
            {
                entity.HasIndex(e => e.BusinessEntityId)
                    .HasName("IX_BusinessEntityId");

                entity.HasIndex(e => e.BusinessEntityTypeId)
                    .HasName("IX_BusinessEntityTypeId");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.BusinessEntityTypeAssignment)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .HasConstraintName("FK_dbo.BusinessEntityTypeAssignment_dbo.BusinessEntity_BusinessEntityId");

                entity.HasOne(d => d.BusinessEntityType)
                    .WithMany(p => p.BusinessEntityTypeAssignment)
                    .HasForeignKey(d => d.BusinessEntityTypeId)
                    .HasConstraintName("FK_dbo.BusinessEntityTypeAssignment_dbo.BusinessEntityType_BusinessEntityTypeId");
            });

            modelBuilder.Entity<BussinessProfile>(entity =>
            {
                entity.HasKey(e => e.BusinessId);

                entity.Property(e => e.AccountHolder).HasMaxLength(100);

                entity.Property(e => e.AccountNumber).HasMaxLength(100);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AreaCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BranchCode).HasMaxLength(100);

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");

                entity.Property(e => e.CellNo).HasMaxLength(100);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.PostCode).HasMaxLength(100);

                entity.Property(e => e.PostalAddress1).HasMaxLength(100);

                entity.Property(e => e.PostalAddress2).HasMaxLength(100);

                entity.Property(e => e.PrimaryActivityId).HasColumnName("PrimaryActivityID");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.RegistrationNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TownId).HasColumnName("TownID");

                entity.Property(e => e.VatNo).HasMaxLength(100);

                entity.Property(e => e.WorkFax).HasMaxLength(100);

                entity.Property(e => e.WorkTel)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CensoredWord>(entity =>
            {
                entity.Property(e => e.DateUpdated).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChatGroup>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId)
                    .HasName("IX_CreatedUserId");

                entity.HasIndex(e => e.RouteId)
                    .HasName("IX_RouteId");

                entity.Property(e => e.CreatedUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.RouteId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ChatGroup)
                    .HasForeignKey(d => d.CreatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ChatGroup_dbo.UserProfile_CreatedUserId");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.ChatGroup)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_dbo.ChatGroup_dbo.Route_RouteId");
            });

            modelBuilder.Entity<ChatGroupUserBan>(entity =>
            {
                entity.HasIndex(e => e.ChatGroupId)
                    .HasName("IX_ChatGroupId");

                entity.HasIndex(e => e.CreatedUserId)
                    .HasName("IX_CreatedUserId");

                entity.HasIndex(e => e.UserProfileId)
                    .HasName("IX_UserProfileId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ChatGroup)
                    .WithMany(p => p.ChatGroupUserBan)
                    .HasForeignKey(d => d.ChatGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ChatGroupUserBan_dbo.ChatGroup_ChatGroupId");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ChatGroupUserBanCreatedUser)
                    .HasForeignKey(d => d.CreatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ChatGroupUserBan_dbo.UserProfile_CreatedUserId");

                entity.HasOne(d => d.UserProfile)
                    .WithMany(p => p.ChatGroupUserBanUserProfile)
                    .HasForeignKey(d => d.UserProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ChatGroupUserBan_dbo.UserProfile_UserProfileId");
            });

            modelBuilder.Entity<ChatMessage>(entity =>
            {
                entity.HasIndex(e => e.ListingFileImageId)
                    .HasName("IX_ListingFileImageId");

                entity.HasIndex(e => e.ListingFileVideoId)
                    .HasName("IX_ListingFileVideoId");

                entity.Property(e => e.SeenDate).HasColumnType("datetime");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.HasOne(d => d.ListingFileImage)
                    .WithMany(p => p.ChatMessageListingFileImage)
                    .HasForeignKey(d => d.ListingFileImageId)
                    .HasConstraintName("FK_dbo.ChatMessage_dbo.ListingFile_ListingFileImageId");

                entity.HasOne(d => d.ListingFileVideo)
                    .WithMany(p => p.ChatMessageListingFileVideo)
                    .HasForeignKey(d => d.ListingFileVideoId)
                    .HasConstraintName("FK_dbo.ChatMessage_dbo.ListingFile_ListingFileVideoId");
            });

            modelBuilder.Entity<ClassifiedAd>(entity =>
            {
                entity.HasIndex(e => e.ClassifiedAdCategoryId)
                    .HasName("IX_ClassifiedAdCategory_Id");

                entity.HasIndex(e => e.ClassifiedAdRegionId)
                    .HasName("IX_ClassifiedAdRegion_Id");

                entity.HasIndex(e => e.UserUserId)
                    .HasName("IX_User_UserId");

                entity.Property(e => e.ClassifiedAdCategoryId).HasColumnName("ClassifiedAdCategory_Id");

                entity.Property(e => e.ClassifiedAdRegionId).HasColumnName("ClassifiedAdRegion_Id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Desc).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.Property(e => e.UserUserId).HasColumnName("User_UserId");

                entity.HasOne(d => d.ClassifiedAdCategory)
                    .WithMany(p => p.ClassifiedAd)
                    .HasForeignKey(d => d.ClassifiedAdCategoryId)
                    .HasConstraintName("FK_dbo.ClassifiedAd_dbo.ClassifiedsCategories_ClassifiedAdCategory_Id");

                entity.HasOne(d => d.ClassifiedAdRegion)
                    .WithMany(p => p.ClassifiedAd)
                    .HasForeignKey(d => d.ClassifiedAdRegionId)
                    .HasConstraintName("FK_dbo.ClassifiedAd_dbo.ClassifiedAdRegion_ClassifiedAdRegion_Id");

                entity.HasOne(d => d.UserUser)
                    .WithMany(p => p.ClassifiedAd)
                    .HasForeignKey(d => d.UserUserId)
                    .HasConstraintName("FK_dbo.ClassifiedAd_dbo.UserProfile_User_UserId");
            });

            modelBuilder.Entity<Combine>(entity =>
            {
                entity.HasIndex(e => e.CombineBaseId)
                    .HasName("IX_CombineBaseId");

                entity.HasIndex(e => e.MenuTypeId)
                    .HasName("IX_MenuTypeID");

                entity.HasIndex(e => e.RouteId)
                    .HasName("IX_RouteId");

                entity.Property(e => e.MenuTypeId).HasColumnName("MenuTypeID");

                entity.HasOne(d => d.CombineBase)
                    .WithMany(p => p.Combine)
                    .HasForeignKey(d => d.CombineBaseId)
                    .HasConstraintName("FK_dbo.Combine_dbo.CombineBase_CombineBaseId");

                entity.HasOne(d => d.MenuType)
                    .WithMany(p => p.Combine)
                    .HasForeignKey(d => d.MenuTypeId)
                    .HasConstraintName("FK_dbo.Combine_dbo.MenuType_MenuTypeID");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Combine)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_dbo.Combine_dbo.Route_RouteId");
            });

            modelBuilder.Entity<CombineBase>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandID");

                entity.HasIndex(e => e.EntryTypeId)
                    .HasName("IX_EntryTypeID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.EntryTypeId).HasColumnName("EntryTypeID");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.CombineBase)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_dbo.CombineBase_dbo.Brand_BrandID");

                entity.HasOne(d => d.EntryType)
                    .WithMany(p => p.CombineBase)
                    .HasForeignKey(d => d.EntryTypeId)
                    .HasConstraintName("FK_dbo.CombineBase_dbo.EntryType_EntryTypeID");
            });

            modelBuilder.Entity<CombineImage>(entity =>
            {
                entity.HasIndex(e => e.CombineBaseId)
                    .HasName("IX_CombineBaseId");

                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasOne(d => d.CombineBase)
                    .WithMany(p => p.CombineImage)
                    .HasForeignKey(d => d.CombineBaseId)
                    .HasConstraintName("FK_dbo.CombineImage_dbo.CombineBase_CombineBaseId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.CombineImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.CombineImage_dbo.ListingFile_ListingFileId");
            });

            modelBuilder.Entity<CropTradeAd>(entity =>
            {
                entity.HasIndex(e => e.TradeAdId)
                    .HasName("IX_TradeAdId");

                entity.HasOne(d => d.TradeAd)
                    .WithMany(p => p.CropTradeAd)
                    .HasForeignKey(d => d.TradeAdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CropTradeAd_dbo.TradeAd_TradeAdId");
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.HasIndex(e => e.CompanyTypeIdCompanyTypeId)
                    .HasName("IX_CompanyTypeId_CompanyTypeId");

                entity.HasIndex(e => e.EntityAddressAddressTypeId)
                    .HasName("IX_EntityAddress_AddressTypeId");

                entity.HasIndex(e => e.UserTypeIdUserTypeId)
                    .HasName("IX_UserTypeId_UserTypeId");

                entity.Property(e => e.CompanyTypeIdCompanyTypeId).HasColumnName("CompanyTypeId_CompanyTypeId");

                entity.Property(e => e.EntityAddressAddressTypeId).HasColumnName("EntityAddress_AddressTypeId");

                entity.Property(e => e.Sarsnumber).HasColumnName("SARSnumber");

                entity.Property(e => e.UserTypeIdUserTypeId).HasColumnName("UserTypeId_UserTypeId");

                entity.Property(e => e.Vatnumber).HasColumnName("VATnumber");

                entity.HasOne(d => d.CompanyTypeIdCompanyType)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.CompanyTypeIdCompanyTypeId)
                    .HasConstraintName("FK_dbo.Entity_dbo.CompanyType_CompanyTypeId_CompanyTypeId");

                entity.HasOne(d => d.EntityAddressAddressType)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.EntityAddressAddressTypeId)
                    .HasConstraintName("FK_dbo.Entity_dbo.EntityAddress_EntityAddress_AddressTypeId");

                entity.HasOne(d => d.UserTypeIdUserType)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.UserTypeIdUserTypeId)
                    .HasConstraintName("FK_dbo.Entity_dbo.UserType_UserTypeId_UserTypeId");
            });

            modelBuilder.Entity<EntityAddress>(entity =>
            {
                entity.HasKey(e => e.AddressTypeId);

                entity.HasIndex(e => e.PostalCountryIdCountryId)
                    .HasName("IX_PostalCountryId_CountryId");

                entity.HasIndex(e => e.PostalProvinceIdProvinceId)
                    .HasName("IX_PostalProvinceId_ProvinceId");

                entity.HasIndex(e => e.PostalTownIdTownId)
                    .HasName("IX_PostalTownId_TownId");

                entity.Property(e => e.PostalCountryIdCountryId).HasColumnName("PostalCountryId_CountryId");

                entity.Property(e => e.PostalProvinceIdProvinceId).HasColumnName("PostalProvinceId_ProvinceId");

                entity.Property(e => e.PostalTownIdTownId).HasColumnName("PostalTownId_TownId");

                entity.HasOne(d => d.PostalCountryIdCountry)
                    .WithMany(p => p.EntityAddress)
                    .HasForeignKey(d => d.PostalCountryIdCountryId)
                    .HasConstraintName("FK_dbo.EntityAddress_dbo.Country_PostalCountryId_CountryId");

                entity.HasOne(d => d.PostalProvinceIdProvince)
                    .WithMany(p => p.EntityAddress)
                    .HasForeignKey(d => d.PostalProvinceIdProvinceId)
                    .HasConstraintName("FK_dbo.EntityAddress_dbo.Province_PostalProvinceId_ProvinceId");

                entity.HasOne(d => d.PostalTownIdTown)
                    .WithMany(p => p.EntityAddress)
                    .HasForeignKey(d => d.PostalTownIdTownId)
                    .HasConstraintName("FK_dbo.EntityAddress_dbo.Town_PostalTownId_TownId");
            });

            modelBuilder.Entity<Entry>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandID");

                entity.HasIndex(e => e.EntryTypeTemplateId)
                    .HasName("IX_EntryTypeTemplateID");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.EntryTypeTemplateId).HasColumnName("EntryTypeTemplateID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Entry)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_dbo.Entry_dbo.Brand_BrandID");

                entity.HasOne(d => d.EntryTypeTemplate)
                    .WithMany(p => p.Entry)
                    .HasForeignKey(d => d.EntryTypeTemplateId)
                    .HasConstraintName("FK_dbo.Entry_dbo.EntryTypeTemplate_EntryTypeTemplateID");
            });

            modelBuilder.Entity<EntryAttribute>(entity =>
            {
                entity.HasIndex(e => e.AttributeId)
                    .HasName("IX_AttributeID");

                entity.HasIndex(e => e.EntryId)
                    .HasName("IX_EntryID");

                entity.Property(e => e.EntryAttributeId).HasColumnName("EntryAttributeID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.EntryAttribute)
                    .HasForeignKey(d => d.AttributeId)
                    .HasConstraintName("FK_dbo.EntryAttribute_dbo.Attribute_AttributeID");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.EntryAttribute)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK_dbo.EntryAttribute_dbo.Entry_EntryID");
            });

            modelBuilder.Entity<EntryHeader>(entity =>
            {
                entity.HasIndex(e => e.EntryId)
                    .HasName("IX_EntryID");

                entity.HasIndex(e => e.RouteId)
                    .HasName("IX_RouteID");

                entity.Property(e => e.EntryHeaderId).HasColumnName("EntryHeaderID");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.EntryHeader)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK_dbo.EntryHeader_dbo.Entry_EntryID");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.EntryHeader)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_dbo.EntryHeader_dbo.Route_RouteID");
            });

            modelBuilder.Entity<EntryImage>(entity =>
            {
                entity.HasIndex(e => e.EntryId)
                    .HasName("IX_EntryID");

                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.Property(e => e.EntryImageId).HasColumnName("EntryImageID");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.EntryImage)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK_dbo.EntryImage_dbo.Entry_EntryID");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.EntryImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.EntryImage_dbo.ListingFile_ListingFileId");
            });

            modelBuilder.Entity<EntryPdf>(entity =>
            {
                entity.ToTable("EntryPDF");

                entity.HasIndex(e => e.EntryId)
                    .HasName("IX_EntryID");

                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.Property(e => e.EntryPdfid).HasColumnName("EntryPDFID");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.EntryPdf)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK_dbo.EntryPDF_dbo.Entry_EntryID");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.EntryPdf)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.EntryPDF_dbo.ListingFile_ListingFileId");
            });

            modelBuilder.Entity<EntryType>(entity =>
            {
                entity.Property(e => e.EntryTypeId).HasColumnName("EntryTypeID");
            });

            modelBuilder.Entity<EntryTypeTemplate>(entity =>
            {
                entity.Property(e => e.EntryTypeTemplateId).HasColumnName("EntryTypeTemplateID");
            });

            modelBuilder.Entity<EntryTypeTemplateAttribute>(entity =>
            {
                entity.HasIndex(e => e.AttributeId)
                    .HasName("IX_AttributeID");

                entity.HasIndex(e => e.EntryTypeTemplateId)
                    .HasName("IX_EntryTypeTemplateID");

                entity.Property(e => e.EntryTypeTemplateAttributeId).HasColumnName("EntryTypeTemplateAttributeID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.EntryTypeTemplateId).HasColumnName("EntryTypeTemplateID");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.EntryTypeTemplateAttribute)
                    .HasForeignKey(d => d.AttributeId)
                    .HasConstraintName("FK_dbo.EntryTypeTemplateAttribute_dbo.Attribute_AttributeID");

                entity.HasOne(d => d.EntryTypeTemplate)
                    .WithMany(p => p.EntryTypeTemplateAttribute)
                    .HasForeignKey(d => d.EntryTypeTemplateId)
                    .HasConstraintName("FK_dbo.EntryTypeTemplateAttribute_dbo.EntryTypeTemplate_EntryTypeTemplateID");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasIndex(e => e.EquipmentBaseId)
                    .HasName("IX_EquipmentBaseId");

                entity.HasIndex(e => e.MenuTypeId)
                    .HasName("IX_MenuTypeID");

                entity.HasIndex(e => e.RouteId)
                    .HasName("IX_RouteId");

                entity.Property(e => e.MenuTypeId).HasColumnName("MenuTypeID");

                entity.HasOne(d => d.EquipmentBase)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.EquipmentBaseId)
                    .HasConstraintName("FK_dbo.Equipment_dbo.EquipmentBase_EquipmentBaseId");

                entity.HasOne(d => d.MenuType)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.MenuTypeId)
                    .HasConstraintName("FK_dbo.Equipment_dbo.MenuType_MenuTypeID");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_dbo.Equipment_dbo.Route_RouteId");
            });

            modelBuilder.Entity<EquipmentBase>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandID");

                entity.HasIndex(e => e.EntryTypeId)
                    .HasName("IX_EntryTypeID");

                entity.HasIndex(e => e.SpecificationListingFileId)
                    .HasName("IX_Specification_ListingFileId");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.EntryTypeId).HasColumnName("EntryTypeID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SpecificationId).HasColumnName("SpecificationID");

                entity.Property(e => e.SpecificationListingFileId).HasColumnName("Specification_ListingFileId");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.EquipmentBase)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_dbo.EquipmentBase_dbo.Brand_BrandID");

                entity.HasOne(d => d.EntryType)
                    .WithMany(p => p.EquipmentBase)
                    .HasForeignKey(d => d.EntryTypeId)
                    .HasConstraintName("FK_dbo.EquipmentBase_dbo.EntryType_EntryTypeID");

                entity.HasOne(d => d.SpecificationListingFile)
                    .WithMany(p => p.EquipmentBase)
                    .HasForeignKey(d => d.SpecificationListingFileId)
                    .HasConstraintName("FK_dbo.EquipmentBase_dbo.ListingFile_Specification_ListingFileId");
            });

            modelBuilder.Entity<EquipmentFarm>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);

                entity.Property(e => e.EquipmentId).HasColumnName("EquipmentID");

                entity.Property(e => e.FarmId).HasColumnName("FarmID");
            });

            modelBuilder.Entity<EquipmentImage>(entity =>
            {
                entity.HasIndex(e => e.EquipmentBaseId)
                    .HasName("IX_EquipmentBaseId");

                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasOne(d => d.EquipmentBase)
                    .WithMany(p => p.EquipmentImage)
                    .HasForeignKey(d => d.EquipmentBaseId)
                    .HasConstraintName("FK_dbo.EquipmentImage_dbo.EquipmentBase_EquipmentBaseId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.EquipmentImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.EquipmentImage_dbo.ListingFile_ListingFileId");
            });

            modelBuilder.Entity<EquipmentSpecification>(entity =>
            {
                entity.HasIndex(e => e.EquipmentBaseEquipmentBaseId)
                    .HasName("IX_EquipmentBase_EquipmentBaseId");

                entity.HasIndex(e => e.SpecificationSpecificationId)
                    .HasName("IX_Specification_SpecificationId");

                entity.Property(e => e.EquipmentBaseEquipmentBaseId).HasColumnName("EquipmentBase_EquipmentBaseId");

                entity.Property(e => e.SpecificationSpecificationId).HasColumnName("Specification_SpecificationId");

                entity.HasOne(d => d.EquipmentBaseEquipmentBase)
                    .WithMany(p => p.EquipmentSpecification)
                    .HasForeignKey(d => d.EquipmentBaseEquipmentBaseId)
                    .HasConstraintName("FK_dbo.EquipmentSpecification_dbo.EquipmentBase_EquipmentBase_EquipmentBaseId");

                entity.HasOne(d => d.SpecificationSpecification)
                    .WithMany(p => p.EquipmentSpecification)
                    .HasForeignKey(d => d.SpecificationSpecificationId)
                    .HasConstraintName("FK_dbo.EquipmentSpecification_dbo.Specification_Specification_SpecificationId");
            });

            modelBuilder.Entity<EquipmentTradeAd>(entity =>
            {
                entity.HasIndex(e => e.TradeAdId)
                    .HasName("IX_TradeAdId");

                entity.HasOne(d => d.TradeAd)
                    .WithMany(p => p.EquipmentTradeAd)
                    .HasForeignKey(d => d.TradeAdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.EquipmentTradeAd_dbo.TradeAd_TradeAdId");
            });

            modelBuilder.Entity<Farm>(entity =>
            {
                entity.HasIndex(e => e.InfrastructureId)
                    .HasName("IX_InfrastructureID");

                entity.HasIndex(e => e.RouteRouteId)
                    .HasName("IX_Route_RouteId");

                entity.HasIndex(e => e.WaterRightsId)
                    .HasName("IX_WaterRightsID");

                entity.Property(e => e.FarmId).HasColumnName("FarmID");

                entity.Property(e => e.FarmImageId).HasColumnName("FarmImageID");

                entity.Property(e => e.InfrastructureId).HasColumnName("InfrastructureID");

                entity.Property(e => e.PriceExclVat).HasColumnName("PriceExclVAT");

                entity.Property(e => e.PriceIncVat).HasColumnName("PriceIncVAT");

                entity.Property(e => e.RouteRouteId).HasColumnName("Route_RouteId");

                entity.Property(e => e.WaterRightsId).HasColumnName("WaterRightsID");

                entity.HasOne(d => d.Infrastructure)
                    .WithMany(p => p.Farm)
                    .HasForeignKey(d => d.InfrastructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Farm_dbo.Infrastructure_InfrastructureID");

                entity.HasOne(d => d.RouteRoute)
                    .WithMany(p => p.Farm)
                    .HasForeignKey(d => d.RouteRouteId)
                    .HasConstraintName("FK_dbo.Farm_dbo.Route_Route_RouteId");

                entity.HasOne(d => d.WaterRights)
                    .WithMany(p => p.Farm)
                    .HasForeignKey(d => d.WaterRightsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Farm_dbo.WaterRights_WaterRightsID");
            });

            modelBuilder.Entity<FarmImage>(entity =>
            {
                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.Property(e => e.FarmImageId).HasColumnName("FarmImageID");

                entity.Property(e => e.FarmId).HasColumnName("FarmID");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.FarmImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.FarmImage_dbo.ListingFile_ListingFileId");
            });

            modelBuilder.Entity<FarmInfrastructure>(entity =>
            {
                entity.HasIndex(e => e.InfrastructureId)
                    .HasName("IX_InfrastructureID");

                entity.Property(e => e.FarmInfrastructureId).HasColumnName("FarmInfrastructureID");

                entity.Property(e => e.FarmId).HasColumnName("FarmID");

                entity.Property(e => e.InfrastructureId).HasColumnName("InfrastructureID");

                entity.HasOne(d => d.Infrastructure)
                    .WithMany(p => p.FarmInfrastructure)
                    .HasForeignKey(d => d.InfrastructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FarmInfrastructure_dbo.Infrastructure_InfrastructureID");
            });

            modelBuilder.Entity<FarmType>(entity =>
            {
                entity.Property(e => e.FarmTypeId).HasColumnName("FarmTypeID");

                entity.Property(e => e.FarmId).HasColumnName("FarmID");

                entity.Property(e => e.ListingFileId).HasColumnName("ListingFileID");

                entity.Property(e => e.SubGroupId).HasColumnName("SubGroupID");

                entity.Property(e => e.SuperGroupId).HasColumnName("SuperGroupID");
            });

            modelBuilder.Entity<FarmWaterRight>(entity =>
            {
                entity.HasIndex(e => e.WaterRightId)
                    .HasName("IX_WaterRightID");

                entity.Property(e => e.FarmWaterRightId).HasColumnName("FarmWaterRightID");

                entity.Property(e => e.FarmId).HasColumnName("FarmID");

                entity.Property(e => e.M3Listed).HasColumnName("m3Listed");

                entity.Property(e => e.WaterRightId).HasColumnName("WaterRightID");

                entity.HasOne(d => d.WaterRight)
                    .WithMany(p => p.FarmWaterRight)
                    .HasForeignKey(d => d.WaterRightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FarmWaterRight_dbo.WaterRights_WaterRightID");
            });

            modelBuilder.Entity<Function>(entity =>
            {
                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FunctionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FunctionNo)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<GameAndLivestockTradeAd>(entity =>
            {
                entity.HasIndex(e => e.TradeAdId)
                    .HasName("IX_TradeAdId");

                entity.HasOne(d => d.TradeAd)
                    .WithMany(p => p.GameAndLivestockTradeAd)
                    .HasForeignKey(d => d.TradeAdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GameAndLivestockTradeAd_dbo.TradeAd_TradeAdId");
            });

            modelBuilder.Entity<GroupChatMessage>(entity =>
            {
                entity.HasIndex(e => e.ChatGroupId)
                    .HasName("IX_ChatGroupId");

                entity.HasIndex(e => e.ChatMessageId)
                    .HasName("IX_ChatMessageId");

                entity.HasIndex(e => e.SenderId)
                    .HasName("IX_SenderId");

                entity.HasOne(d => d.ChatGroup)
                    .WithMany(p => p.GroupChatMessage)
                    .HasForeignKey(d => d.ChatGroupId)
                    .HasConstraintName("FK_dbo.GroupChatMessage_dbo.ChatGroup_ChatGroupId");

                entity.HasOne(d => d.ChatMessage)
                    .WithMany(p => p.GroupChatMessage)
                    .HasForeignKey(d => d.ChatMessageId)
                    .HasConstraintName("FK_dbo.GroupChatMessage_dbo.ChatMessage_ChatMessageId");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.GroupChatMessage)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GroupChatMessage_dbo.UserProfile_SenderId");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupId);
            });

            modelBuilder.Entity<GroupSubGroups>(entity =>
            {
                entity.HasKey(e => e.GroupSubGroupId);

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupId");

                entity.HasIndex(e => e.SubGroupId)
                    .HasName("IX_SubGroupId");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupSubGroups)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_dbo.GroupSubGroups_dbo.Groups_GroupId");

                entity.HasOne(d => d.SubGroup)
                    .WithMany(p => p.GroupSubGroups)
                    .HasForeignKey(d => d.SubGroupId)
                    .HasConstraintName("FK_dbo.GroupSubGroups_dbo.SubGroups_SubGroupId");
            });

            modelBuilder.Entity<GroupSuperGroups>(entity =>
            {
                entity.HasKey(e => e.GroupSuperGroupId);

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupId");

                entity.HasIndex(e => e.SuperGroupId)
                    .HasName("IX_SuperGroupId");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupSuperGroups)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_dbo.GroupSuperGroups_dbo.Groups_GroupId");

                entity.HasOne(d => d.SuperGroup)
                    .WithMany(p => p.GroupSuperGroups)
                    .HasForeignKey(d => d.SuperGroupId)
                    .HasConstraintName("FK_dbo.GroupSuperGroups_dbo.SuperGroups_SuperGroupId");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasIndex(e => e.ClassifiedAdId)
                    .HasName("IX_ClassifiedAdId");

                entity.HasOne(d => d.ClassifiedAd)
                    .WithMany(p => p.Image)
                    .HasForeignKey(d => d.ClassifiedAdId)
                    .HasConstraintName("FK_dbo.Image_dbo.ClassifiedAd_ClassifiedAdId");
            });

            modelBuilder.Entity<Infrastructure>(entity =>
            {
                entity.Property(e => e.InfrastructureId).HasColumnName("InfrastructureID");
            });

            modelBuilder.Entity<InfrastructureTradeAd>(entity =>
            {
                entity.HasIndex(e => e.TradeAdId)
                    .HasName("IX_TradeAdId");

                entity.HasOne(d => d.TradeAd)
                    .WithMany(p => p.InfrastructureTradeAd)
                    .HasForeignKey(d => d.TradeAdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.InfrastructureTradeAd_dbo.TradeAd_TradeAdId");
            });

            modelBuilder.Entity<LinkRequest>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandId");

                entity.HasIndex(e => e.LinkRequestTypeId)
                    .HasName("IX_LinkRequestTypeId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Edited).HasColumnType("datetime");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.LinkRequest)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_dbo.LinkRequest_dbo.Brand_BrandId");

                entity.HasOne(d => d.LinkRequestType)
                    .WithMany(p => p.LinkRequest)
                    .HasForeignKey(d => d.LinkRequestTypeId)
                    .HasConstraintName("FK_dbo.LinkRequest_dbo.LinkRequestType_LinkRequestTypeId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.LinkRequest)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.LinkRequest_dbo.Supplier_SupplierId");
            });

            modelBuilder.Entity<ListingEntry>(entity =>
            {
                entity.Property(e => e.ListingEntryDesc).IsRequired();

                entity.Property(e => e.ListingEntryName).IsRequired();
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Manager)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_dbo.Manager_dbo.Brand_BrandId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Manager)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.Manager_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Manager)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Manager_dbo.UserProfile_UserId");
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MarketPdf>(entity =>
            {
                entity.ToTable("MarketPDF");

                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasIndex(e => e.MarketId)
                    .HasName("IX_MarketId");

                entity.Property(e => e.MarketPdfid).HasColumnName("MarketPDFID");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.MarketPdf)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.MarketPDF_dbo.ListingFile_ListingFileId");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.MarketPdf)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_dbo.MarketPDF_dbo.Market_MarketId");
            });

            modelBuilder.Entity<MarketRoute>(entity =>
            {
                entity.HasIndex(e => e.MarketId)
                    .HasName("IX_MarketId");

                entity.HasIndex(e => e.RouteId)
                    .HasName("IX_RouteId");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.MarketRoute)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_dbo.MarketRoute_dbo.Market_MarketId");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.MarketRoute)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_dbo.MarketRoute_dbo.Route_RouteId");
            });

            modelBuilder.Entity<MenuType>(entity =>
            {
                entity.Property(e => e.MenuTypeId).HasColumnName("MenuTypeID");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasIndex(e => e.ImageMessageImageId)
                    .HasName("IX_Image_MessageImageId");

                entity.HasIndex(e => e.RecipientUserId)
                    .HasName("IX_Recipient_UserId");

                entity.HasIndex(e => e.SenderUserId)
                    .HasName("IX_Sender_UserId");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ImageMessageImageId).HasColumnName("Image_MessageImageId");

                entity.Property(e => e.RecipientUserId).HasColumnName("Recipient_UserId");

                entity.Property(e => e.SenderUserId).HasColumnName("Sender_UserId");

                entity.Property(e => e.Subject).IsRequired();

                entity.HasOne(d => d.ImageMessageImage)
                    .WithMany(p => p.Message)
                    .HasForeignKey(d => d.ImageMessageImageId)
                    .HasConstraintName("FK_dbo.Message_dbo.MessageImage_Image_MessageImageId");

                entity.HasOne(d => d.RecipientUser)
                    .WithMany(p => p.MessageRecipientUser)
                    .HasForeignKey(d => d.RecipientUserId)
                    .HasConstraintName("FK_dbo.Message_dbo.UserProfile_Recipient_UserId");

                entity.HasOne(d => d.SenderUser)
                    .WithMany(p => p.MessageSenderUser)
                    .HasForeignKey(d => d.SenderUserId)
                    .HasConstraintName("FK_dbo.Message_dbo.UserProfile_Sender_UserId");
            });

            modelBuilder.Entity<MessageImage>(entity =>
            {
                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.MessageImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.MessageImage_dbo.ListingFile_ListingFileId");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MunicipalDistrict>(entity =>
            {
                entity.HasIndex(e => e.ProvinceId)
                    .HasName("IX_ProvinceId");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.MunicipalDistrict)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_dbo.MunicipalDistrict_dbo.Province_ProvinceId");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasIndex(e => e.NewsCatId)
                    .HasName("IX_NewsCatId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.NewsCat)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.NewsCatId)
                    .HasConstraintName("FK_dbo.News_dbo.NewsCat_NewsCatId");
            });

            modelBuilder.Entity<NewsImage>(entity =>
            {
                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasIndex(e => e.NewsId)
                    .HasName("IX_NewsId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.NewsImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.NewsImage_dbo.ListingFile_ListingFileId");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.NewsImage)
                    .HasForeignKey(d => d.NewsId)
                    .HasConstraintName("FK_dbo.NewsImage_dbo.News_NewsId");
            });

            modelBuilder.Entity<Problem>(entity =>
            {
                entity.HasIndex(e => e.MenuTypeId)
                    .HasName("IX_MenuTypeID");

                entity.HasIndex(e => e.ProblemBaseId)
                    .HasName("IX_ProblemBaseId");

                entity.HasIndex(e => e.RouteId)
                    .HasName("IX_RouteId");

                entity.Property(e => e.MenuTypeId).HasColumnName("MenuTypeID");

                entity.HasOne(d => d.MenuType)
                    .WithMany(p => p.Problem)
                    .HasForeignKey(d => d.MenuTypeId)
                    .HasConstraintName("FK_dbo.Problem_dbo.MenuType_MenuTypeID");

                entity.HasOne(d => d.ProblemBase)
                    .WithMany(p => p.Problem)
                    .HasForeignKey(d => d.ProblemBaseId)
                    .HasConstraintName("FK_dbo.Problem_dbo.ProblemBase_ProblemBaseId");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Problem)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_dbo.Problem_dbo.Route_RouteId");
            });

            modelBuilder.Entity<ProblemAttachment>(entity =>
            {
                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasIndex(e => e.ProblemBaseId)
                    .HasName("IX_ProblemBaseId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.ProblemAttachment)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.ProblemAttachment_dbo.ListingFile_ListingFileId");

                entity.HasOne(d => d.ProblemBase)
                    .WithMany(p => p.ProblemAttachment)
                    .HasForeignKey(d => d.ProblemBaseId)
                    .HasConstraintName("FK_dbo.ProblemAttachment_dbo.ProblemBase_ProblemBaseId");
            });

            modelBuilder.Entity<ProblemBase>(entity =>
            {
                entity.HasIndex(e => e.EntryTypeId)
                    .HasName("IX_EntryTypeID");

                entity.Property(e => e.EntryTypeId).HasColumnName("EntryTypeID");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.EntryType)
                    .WithMany(p => p.ProblemBase)
                    .HasForeignKey(d => d.EntryTypeId)
                    .HasConstraintName("FK_dbo.ProblemBase_dbo.EntryType_EntryTypeID");
            });

            modelBuilder.Entity<ProblemImage>(entity =>
            {
                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasIndex(e => e.ProblemBaseId)
                    .HasName("IX_ProblemBaseId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.ProblemImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.ProblemImage_dbo.ListingFile_ListingFileId");

                entity.HasOne(d => d.ProblemBase)
                    .WithMany(p => p.ProblemImage)
                    .HasForeignKey(d => d.ProblemBaseId)
                    .HasConstraintName("FK_dbo.ProblemImage_dbo.ProblemBase_ProblemBaseId");
            });

            modelBuilder.Entity<ProblemSymptom>(entity =>
            {
                entity.HasIndex(e => e.ProblemProblemId)
                    .HasName("IX_Problem_ProblemId");

                entity.HasIndex(e => e.SymptomSymptomId)
                    .HasName("IX_Symptom_SymptomId");

                entity.Property(e => e.ProblemProblemId).HasColumnName("Problem_ProblemId");

                entity.Property(e => e.SymptomSymptomId).HasColumnName("Symptom_SymptomId");

                entity.HasOne(d => d.ProblemProblem)
                    .WithMany(p => p.ProblemSymptom)
                    .HasForeignKey(d => d.ProblemProblemId)
                    .HasConstraintName("FK_dbo.ProblemSymptom_dbo.Problem_Problem_ProblemId");

                entity.HasOne(d => d.SymptomSymptom)
                    .WithMany(p => p.ProblemSymptom)
                    .HasForeignKey(d => d.SymptomSymptomId)
                    .HasConstraintName("FK_dbo.ProblemSymptom_dbo.Symptom_Symptom_SymptomId");
            });

            modelBuilder.Entity<ProblemType>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.MenuTypeId)
                    .HasName("IX_MenuTypeID");

                entity.HasIndex(e => e.ProductBaseId)
                    .HasName("IX_ProductBaseId");

                entity.HasIndex(e => e.RouteId)
                    .HasName("IX_RouteId");

                entity.Property(e => e.MenuTypeId).HasColumnName("MenuTypeID");

                entity.HasOne(d => d.MenuType)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.MenuTypeId)
                    .HasConstraintName("FK_dbo.Product_dbo.MenuType_MenuTypeID");

                entity.HasOne(d => d.ProductBase)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductBaseId)
                    .HasConstraintName("FK_dbo.Product_dbo.ProductBase_ProductBaseId");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_dbo.Product_dbo.Route_RouteId");
            });

            modelBuilder.Entity<ProductActiveIngredient>(entity =>
            {
                entity.HasIndex(e => e.ActiveIngredientId)
                    .HasName("IX_ActiveIngredientId");

                entity.HasIndex(e => e.ProductBaseId)
                    .HasName("IX_ProductBaseId");

                entity.HasOne(d => d.ActiveIngredient)
                    .WithMany(p => p.ProductActiveIngredient)
                    .HasForeignKey(d => d.ActiveIngredientId)
                    .HasConstraintName("FK_dbo.ProductActiveIngredient_dbo.ActiveIngredient_ActiveIngredientId");

                entity.HasOne(d => d.ProductBase)
                    .WithMany(p => p.ProductActiveIngredient)
                    .HasForeignKey(d => d.ProductBaseId)
                    .HasConstraintName("FK_dbo.ProductActiveIngredient_dbo.ProductBase_ProductBaseId");
            });

            modelBuilder.Entity<ProductAttachment>(entity =>
            {
                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasIndex(e => e.ProductBaseId)
                    .HasName("IX_ProductBaseId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.ProductAttachment)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.ProductAttachment_dbo.ListingFile_ListingFileId");

                entity.HasOne(d => d.ProductBase)
                    .WithMany(p => p.ProductAttachment)
                    .HasForeignKey(d => d.ProductBaseId)
                    .HasConstraintName("FK_dbo.ProductAttachment_dbo.ProductBase_ProductBaseId");
            });

            modelBuilder.Entity<ProductBase>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandID");

                entity.HasIndex(e => e.EntryTypeId)
                    .HasName("IX_EntryTypeID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.BrandProductDisplay)
                    .HasColumnName("brandProductDisplay")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EntryTypeId).HasColumnName("EntryTypeID");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.ProductBase)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_dbo.ProductBase_dbo.Brand_BrandID");

                entity.HasOne(d => d.EntryType)
                    .WithMany(p => p.ProductBase)
                    .HasForeignKey(d => d.EntryTypeId)
                    .HasConstraintName("FK_dbo.ProductBase_dbo.EntryType_EntryTypeID");
            });

            modelBuilder.Entity<ProductBaseRemedyType>(entity =>
            {
                entity.HasIndex(e => e.ProductBaseId)
                    .HasName("IX_ProductBaseId");

                entity.HasIndex(e => e.RemedyTypeId)
                    .HasName("IX_RemedyTypeId");

                entity.HasOne(d => d.ProductBase)
                    .WithMany(p => p.ProductBaseRemedyType)
                    .HasForeignKey(d => d.ProductBaseId)
                    .HasConstraintName("FK_dbo.ProductBaseRemedyType_dbo.ProductBase_ProductBaseId");

                entity.HasOne(d => d.RemedyType)
                    .WithMany(p => p.ProductBaseRemedyType)
                    .HasForeignKey(d => d.RemedyTypeId)
                    .HasConstraintName("FK_dbo.ProductBaseRemedyType_dbo.RemedyType_RemedyTypeId");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasIndex(e => e.ProductBaseId)
                    .HasName("IX_ProductBaseId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.ProductImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.ProductImage_dbo.ListingFile_ListingFileId");

                entity.HasOne(d => d.ProductBase)
                    .WithMany(p => p.ProductImage)
                    .HasForeignKey(d => d.ProductBaseId)
                    .HasConstraintName("FK_dbo.ProductImage_dbo.ProductBase_ProductBaseId");
            });

            modelBuilder.Entity<ProductSpecification>(entity =>
            {
                entity.HasIndex(e => e.ProductBaseId)
                    .HasName("IX_ProductBaseId");

                entity.HasIndex(e => e.SpecificationSpecificationId)
                    .HasName("IX_Specification_SpecificationId");

                entity.Property(e => e.SpecificationSpecificationId).HasColumnName("Specification_SpecificationId");

                entity.HasOne(d => d.ProductBase)
                    .WithMany(p => p.ProductSpecification)
                    .HasForeignKey(d => d.ProductBaseId)
                    .HasConstraintName("FK_dbo.ProductSpecification_dbo.ProductBase_ProductBaseId");

                entity.HasOne(d => d.SpecificationSpecification)
                    .WithMany(p => p.ProductSpecification)
                    .HasForeignKey(d => d.SpecificationSpecificationId)
                    .HasConstraintName("FK_dbo.ProductSpecification_dbo.Specification_Specification_SpecificationId");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<PropertyAdditional>(entity =>
            {
                entity.Property(e => e.PropertyAdditionalId).HasColumnName("PropertyAdditionalID");

                entity.Property(e => e.PropId).HasColumnName("PropID");
            });

            modelBuilder.Entity<PropertyAdditionalImage>(entity =>
            {
                entity.HasKey(e => e.PropAddId);

                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasIndex(e => e.PropertyAdditionalId)
                    .HasName("IX_PropertyAdditionalID");

                entity.Property(e => e.PropAddId).HasColumnName("PropAddID");

                entity.Property(e => e.PropertyAdditionalId).HasColumnName("PropertyAdditionalID");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.PropertyAdditionalImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.PropertyAdditionalImage_dbo.ListingFile_ListingFileId");

                entity.HasOne(d => d.PropertyAdditional)
                    .WithMany(p => p.PropertyAdditionalImage)
                    .HasForeignKey(d => d.PropertyAdditionalId)
                    .HasConstraintName("FK_dbo.PropertyAdditionalImage_dbo.PropertyAdditional_PropertyAdditionalID");
            });

            modelBuilder.Entity<PropertyListing>(entity =>
            {
                entity.HasKey(e => e.PropertyId);

                entity.HasIndex(e => e.PropertyCategoryId)
                    .HasName("IX_PropertyCategory_Id");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.AddressLine1).HasColumnName("Address_Line_1");

                entity.Property(e => e.AddressLine2).HasColumnName("Address_Line_2");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.NoOfBathrooms).HasColumnName("noOfBathrooms");

                entity.Property(e => e.NoOfBedrooms).HasColumnName("noOfBedrooms");

                entity.Property(e => e.NoOfGarages).HasColumnName("noOfGarages");

                entity.Property(e => e.PropertyCategoryId).HasColumnName("PropertyCategory_Id");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.PropertyCategory)
                    .WithMany(p => p.PropertyListing)
                    .HasForeignKey(d => d.PropertyCategoryId)
                    .HasConstraintName("FK_dbo.PropertyListing_dbo.PropertyCategory_PropertyCategory_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PropertyListing)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PropertyListing_dbo.UserProfile_UserId");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_CountryId");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Province)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_dbo.Province_dbo.Country_CountryId");
            });

            modelBuilder.Entity<RelatedBrand>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandId");

                entity.HasIndex(e => e.ChildBrandId)
                    .HasName("IX_ChildBrandId");

                entity.Property(e => e.BrandBrandId).HasColumnName("Brand_BrandId");

                entity.HasOne(d => d.BrandBrand)
                    .WithMany(p => p.RelatedBrandBrandBrand)
                    .HasForeignKey(d => d.BrandBrandId)
                    .HasConstraintName("FK_dbo.RelatedBrand_dbo.Brand_Brand_BrandId");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.RelatedBrandBrand)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RelatedBrand_dbo.Brand_BrandId");

                entity.HasOne(d => d.ChildBrand)
                    .WithMany(p => p.RelatedBrandChildBrand)
                    .HasForeignKey(d => d.ChildBrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RelatedBrand_dbo.Brand_ChildBrandId");
            });

            modelBuilder.Entity<Remedy>(entity =>
            {
                entity.HasIndex(e => e.ProblemId)
                    .HasName("IX_ProblemId");

                entity.HasIndex(e => e.ProductBaseId)
                    .HasName("IX_ProductBaseId");

                entity.HasOne(d => d.Problem)
                    .WithMany(p => p.Remedy)
                    .HasForeignKey(d => d.ProblemId)
                    .HasConstraintName("FK_dbo.Remedy_dbo.Problem_ProblemId");

                entity.HasOne(d => d.ProductBase)
                    .WithMany(p => p.Remedy)
                    .HasForeignKey(d => d.ProductBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Remedy_dbo.ProductBase_ProductBaseId");
            });

            modelBuilder.Entity<Representative>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Representative)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_dbo.Representative_dbo.Brand_BrandId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Representative)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.Representative_dbo.Supplier_SupplierId");
            });

            modelBuilder.Entity<RepresentativeImage>(entity =>
            {
                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasIndex(e => e.RepresentativeId)
                    .HasName("IX_RepresentativeId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.RepresentativeImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.RepresentativeImage_dbo.ListingFile_ListingFileId");

                entity.HasOne(d => d.Representative)
                    .WithMany(p => p.RepresentativeImage)
                    .HasForeignKey(d => d.RepresentativeId)
                    .HasConstraintName("FK_dbo.RepresentativeImage_dbo.Representative_RepresentativeId");
            });

            modelBuilder.Entity<RepresentativeProvince>(entity =>
            {
                entity.HasIndex(e => e.ProvinceId)
                    .HasName("IX_ProvinceId");

                entity.HasIndex(e => e.RepresentativeId)
                    .HasName("IX_RepresentativeId");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.RepresentativeProvince)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_dbo.RepresentativeProvince_dbo.Province_ProvinceId");

                entity.HasOne(d => d.Representative)
                    .WithMany(p => p.RepresentativeProvince)
                    .HasForeignKey(d => d.RepresentativeId)
                    .HasConstraintName("FK_dbo.RepresentativeProvince_dbo.Representative_RepresentativeId");
            });

            modelBuilder.Entity<RoleFunction>(entity =>
            {
                entity.HasIndex(e => e.FunctionId)
                    .HasName("IX_FunctionID");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleID");

                entity.Property(e => e.RoleFunctionId).HasColumnName("RoleFunctionID");

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.RoleFunction)
                    .HasForeignKey(d => d.FunctionId)
                    .HasConstraintName("FK_dbo.RoleFunction_dbo.Function_FunctionID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleFunction)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.RoleFunction_dbo.webpages_Roles_RoleID");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupId");

                entity.HasIndex(e => e.ProblemBaseId)
                    .HasName("IX_ProblemBaseId");

                entity.HasIndex(e => e.SectionId)
                    .HasName("IX_SectionId");

                entity.HasIndex(e => e.SubGroupId)
                    .HasName("IX_SubGroupId");

                entity.HasIndex(e => e.SuperGroupId)
                    .HasName("IX_SuperGroupId");

                entity.Property(e => e.ViewCount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Route)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_dbo.Route_dbo.Groups_GroupId");

                entity.HasOne(d => d.ProblemBase)
                    .WithMany(p => p.Route)
                    .HasForeignKey(d => d.ProblemBaseId)
                    .HasConstraintName("FK_dbo.Route_ProblemBase_dbo.ProblemBaseId");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Route)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_dbo.Route_dbo.Section_SectionId");

                entity.HasOne(d => d.SubGroup)
                    .WithMany(p => p.Route)
                    .HasForeignKey(d => d.SubGroupId)
                    .HasConstraintName("FK_dbo.Route_dbo.SubGroups_SubGroupId");

                entity.HasOne(d => d.SuperGroup)
                    .WithMany(p => p.Route)
                    .HasForeignKey(d => d.SuperGroupId)
                    .HasConstraintName("FK_dbo.Route_dbo.SuperGroups_SuperGroupId");
            });

            modelBuilder.Entity<Specification>(entity =>
            {
                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<SubGroupGroupList>(entity =>
            {
                entity.HasIndex(e => e.ListTypeListTypeId)
                    .HasName("IX_ListType_ListTypeId");

                entity.HasIndex(e => e.SubGroupSubGroupId)
                    .HasName("IX_SubGroup_SubGroupId");

                entity.Property(e => e.ListTypeListTypeId).HasColumnName("ListType_ListTypeId");

                entity.Property(e => e.SubGroupSubGroupId).HasColumnName("SubGroup_SubGroupId");

                entity.HasOne(d => d.ListTypeListType)
                    .WithMany(p => p.SubGroupGroupList)
                    .HasForeignKey(d => d.ListTypeListTypeId)
                    .HasConstraintName("FK_dbo.SubGroupGroupList_dbo.ListType_ListType_ListTypeId");

                entity.HasOne(d => d.SubGroupSubGroup)
                    .WithMany(p => p.SubGroupGroupList)
                    .HasForeignKey(d => d.SubGroupSubGroupId)
                    .HasConstraintName("FK_dbo.SubGroupGroupList_dbo.SubGroups_SubGroup_SubGroupId");
            });

            modelBuilder.Entity<SubGroups>(entity =>
            {
                entity.HasKey(e => e.SubGroupId);
            });

            modelBuilder.Entity<SuperGroups>(entity =>
            {
                entity.HasKey(e => e.SuperGroupId);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_CountryId");

                entity.HasIndex(e => e.ProvinceId)
                    .HasName("IX_ProvinceId");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_dbo.Supplier_dbo.Country_CountryId");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_dbo.Supplier_dbo.Province_ProvinceId");
            });

            modelBuilder.Entity<SupplierBrand>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.SupplierBrand)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SupplierBrand_dbo.Brand_BrandId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierBrand)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SupplierBrand_dbo.Supplier_SupplierId");
            });

            modelBuilder.Entity<SupplierBrand1>(entity =>
            {
                entity.HasKey(e => new { e.SupplierSupplierId, e.BrandBrandId });

                entity.HasIndex(e => e.BrandBrandId)
                    .HasName("IX_Brand_BrandId");

                entity.HasIndex(e => e.SupplierSupplierId)
                    .HasName("IX_Supplier_SupplierId");

                entity.Property(e => e.SupplierSupplierId).HasColumnName("Supplier_SupplierId");

                entity.Property(e => e.BrandBrandId).HasColumnName("Brand_BrandId");

                entity.HasOne(d => d.BrandBrand)
                    .WithMany(p => p.SupplierBrand1)
                    .HasForeignKey(d => d.BrandBrandId)
                    .HasConstraintName("FK_dbo.SupplierBrand1_dbo.Brand_Brand_BrandId");

                entity.HasOne(d => d.SupplierSupplier)
                    .WithMany(p => p.SupplierBrand1)
                    .HasForeignKey(d => d.SupplierSupplierId)
                    .HasConstraintName("FK_dbo.SupplierBrand1_dbo.Supplier_Supplier_SupplierId");
            });

            modelBuilder.Entity<SupplierImage>(entity =>
            {
                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.SupplierImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.SupplierImage_dbo.ListingFile_ListingFileId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierImage)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.SupplierImage_dbo.Supplier_SupplierId");
            });

            modelBuilder.Entity<SupplierMunicipalDistrict>(entity =>
            {
                entity.HasIndex(e => e.MunicipalDistrictId)
                    .HasName("IX_MunicipalDistrictId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasOne(d => d.MunicipalDistrict)
                    .WithMany(p => p.SupplierMunicipalDistrict)
                    .HasForeignKey(d => d.MunicipalDistrictId)
                    .HasConstraintName("FK_dbo.SupplierMunicipalDistrict_dbo.MunicipalDistrict_MunicipalDistrictId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierMunicipalDistrict)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.SupplierMunicipalDistrict_dbo.Supplier_SupplierId");
            });

            modelBuilder.Entity<SupplierProduct>(entity =>
            {
                entity.HasIndex(e => e.RouteRouteId)
                    .HasName("IX_Route_RouteId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.Property(e => e.RouteRouteId).HasColumnName("Route_RouteId");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.SupplierProduct)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK_dbo.SupplierProduct_dbo.Entry_EntryId");

                entity.HasOne(d => d.ProductBase)
                    .WithMany(p => p.SupplierProduct)
                    .HasForeignKey(d => d.ProductBaseId)
                    .HasConstraintName("FK_dbo.SupplierProduct_dbo.ProductBase_ProductBaseId");

                entity.HasOne(d => d.RouteRoute)
                    .WithMany(p => p.SupplierProduct)
                    .HasForeignKey(d => d.RouteRouteId)
                    .HasConstraintName("FK_dbo.SupplierProduct_dbo.Route_Route_RouteId");
            });

            modelBuilder.Entity<SupplierTown>(entity =>
            {
                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.TownId)
                    .HasName("IX_TownId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierTown)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.SupplierTown_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.SupplierTown)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_dbo.SupplierTown_dbo.Town_TownId");
            });

            modelBuilder.Entity<Symptom>(entity =>
            {
                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<TopLevelItem>(entity =>
            {
                entity.HasKey(e => e.Code);
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.HasIndex(e => e.ProvinceProvinceId)
                    .HasName("IX_Province_ProvinceId");

                entity.Property(e => e.ProvinceProvinceId).HasColumnName("Province_ProvinceId");

                entity.HasOne(d => d.ProvinceProvince)
                    .WithMany(p => p.Town)
                    .HasForeignKey(d => d.ProvinceProvinceId)
                    .HasConstraintName("FK_dbo.Town_dbo.Province_ProvinceId_ProvinceId");
            });

            modelBuilder.Entity<Tractor>(entity =>
            {
                entity.HasIndex(e => e.MenuTypeId)
                    .HasName("IX_MenuTypeID");

                entity.HasIndex(e => e.RouteId)
                    .HasName("IX_RouteId");

                entity.HasIndex(e => e.TractorBaseId)
                    .HasName("IX_TractorBaseId");

                entity.Property(e => e.MenuTypeId).HasColumnName("MenuTypeID");

                entity.HasOne(d => d.MenuType)
                    .WithMany(p => p.Tractor)
                    .HasForeignKey(d => d.MenuTypeId)
                    .HasConstraintName("FK_dbo.Tractor_dbo.MenuType_MenuTypeID");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Tractor)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_dbo.Tractor_dbo.Route_RouteId");

                entity.HasOne(d => d.TractorBase)
                    .WithMany(p => p.Tractor)
                    .HasForeignKey(d => d.TractorBaseId)
                    .HasConstraintName("FK_dbo.Tractor_dbo.TractorBase_TractorBaseId");
            });

            modelBuilder.Entity<TractorBase>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandID");

                entity.HasIndex(e => e.EntryTypeId)
                    .HasName("IX_EntryTypeID");

                entity.HasIndex(e => e.SpecificationId)
                    .HasName("IX_SpecificationID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.EntryTypeId).HasColumnName("EntryTypeID");

                entity.Property(e => e.HeightRopsmm).HasColumnName("HeightROPSmm");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PtoPowerkw).HasColumnName("PTO_Powerkw");

                entity.Property(e => e.PtoSpeed).HasColumnName("PTO_Speed");

                entity.Property(e => e.SpecificationId).HasColumnName("SpecificationID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.TractorBase)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_dbo.TractorBase_dbo.Brand_BrandID");

                entity.HasOne(d => d.EntryType)
                    .WithMany(p => p.TractorBase)
                    .HasForeignKey(d => d.EntryTypeId)
                    .HasConstraintName("FK_dbo.TractorBase_dbo.EntryType_EntryTypeID");

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.TractorBase)
                    .HasForeignKey(d => d.SpecificationId)
                    .HasConstraintName("FK_dbo.TractorBase_dbo.ListingFile_SpecificationID");
            });

            modelBuilder.Entity<TractorImage>(entity =>
            {
                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasIndex(e => e.TractorBaseId)
                    .HasName("IX_TractorBaseId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.TractorImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.TractorImage_dbo.ListingFile_ListingFileId");

                entity.HasOne(d => d.TractorBase)
                    .WithMany(p => p.TractorImage)
                    .HasForeignKey(d => d.TractorBaseId)
                    .HasConstraintName("FK_dbo.TractorImage_dbo.TractorBase_TractorBaseId");
            });

            modelBuilder.Entity<TradeAd>(entity =>
            {
                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupId");

                entity.HasIndex(e => e.ProvinceId)
                    .HasName("IX_ProvinceId");

                entity.HasIndex(e => e.SellerId)
                    .HasName("IX_SellerId");

                entity.HasIndex(e => e.SubGroupId)
                    .HasName("IX_SubGroupId");

                entity.HasIndex(e => e.SuperGroupId)
                    .HasName("IX_SuperGroupId");

                entity.HasIndex(e => e.TownId)
                    .HasName("IX_TownId");

                entity.Property(e => e.CompletionDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TradeAd)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TradeAd_dbo.Groups_GroupId");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.TradeAd)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TradeAd_dbo.Province_ProvinceId");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.TradeAd)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TradeAd_dbo.TraderProfileSnapshot_SellerId");

                entity.HasOne(d => d.SubGroup)
                    .WithMany(p => p.TradeAd)
                    .HasForeignKey(d => d.SubGroupId)
                    .HasConstraintName("FK_dbo.TradeAd_dbo.SubGroups_SubGroupId");

                entity.HasOne(d => d.SuperGroup)
                    .WithMany(p => p.TradeAd)
                    .HasForeignKey(d => d.SuperGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TradeAd_dbo.SuperGroups_SuperGroupId");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.TradeAd)
                    .HasForeignKey(d => d.TownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TradeAd_dbo.Town_TownId");
            });

            modelBuilder.Entity<TradeAdContactLog>(entity =>
            {
                entity.HasIndex(e => e.TradeAdId)
                    .HasName("IX_TradeAdId");

                entity.HasIndex(e => e.UserProfileId)
                    .HasName("IX_UserProfileId");

                entity.HasOne(d => d.TradeAd)
                    .WithMany(p => p.TradeAdContactLog)
                    .HasForeignKey(d => d.TradeAdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TradeAdContactLog_dbo.TradeAd_TradeAdId");

                entity.HasOne(d => d.UserProfile)
                    .WithMany(p => p.TradeAdContactLog)
                    .HasForeignKey(d => d.UserProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TradeAdContactLog_dbo.UserProfile_UserProfileId");
            });

            modelBuilder.Entity<TradeAdImage>(entity =>
            {
                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasIndex(e => e.TradeAdId)
                    .HasName("IX_TradeAdId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.TradeAdImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.TradeAdImage_dbo.ListingFile_ListingFileId");

                entity.HasOne(d => d.TradeAd)
                    .WithMany(p => p.TradeAdImage)
                    .HasForeignKey(d => d.TradeAdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TradeAdImage_dbo.TradeAd_TradeAdId");
            });

            modelBuilder.Entity<TradeAdTransaction>(entity =>
            {
                entity.HasIndex(e => e.BuyerId)
                    .HasName("IX_BuyerId");

                entity.HasIndex(e => e.TradeAdId)
                    .HasName("IX_TradeAdId");

                entity.Property(e => e.Accepted).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Buyer)
                    .WithMany(p => p.TradeAdTransaction)
                    .HasForeignKey(d => d.BuyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TradeAdTransaction_dbo.TraderProfileSnapshot_BuyerId");

                entity.HasOne(d => d.TradeAd)
                    .WithMany(p => p.TradeAdTransaction)
                    .HasForeignKey(d => d.TradeAdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TradeAdTransaction_dbo.TradeAd_TradeAdId");
            });

            modelBuilder.Entity<TraderProfileSnapshot>(entity =>
            {
                entity.HasIndex(e => e.BankAccountTypeId)
                    .HasName("IX_BankAccountTypeId");

                entity.HasIndex(e => e.BankId)
                    .HasName("IX_BankId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.HasOne(d => d.BankAccountType)
                    .WithMany(p => p.TraderProfileSnapshot)
                    .HasForeignKey(d => d.BankAccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TraderProfileSnapshot_dbo.BankAccountType_BankAccountTypeId");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.TraderProfileSnapshot)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TraderProfileSnapshot_dbo.Bank_BankId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TraderProfileSnapshot)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TraderProfileSnapshot_dbo.UserProfile_UserId");
            });

            modelBuilder.Entity<TradeSafeLog>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserBankAccount>(entity =>
            {
                entity.HasIndex(e => e.BankAccountTypeId)
                    .HasName("IX_BankAccountTypeId");

                entity.HasIndex(e => e.BankId)
                    .HasName("IX_BankId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.HasOne(d => d.BankAccountType)
                    .WithMany(p => p.UserBankAccount)
                    .HasForeignKey(d => d.BankAccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserBankAccount_dbo.BankAccountType_BankAccountTypeId");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.UserBankAccount)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserBankAccount_dbo.Bank_BankId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserBankAccount)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserBankAccount_dbo.UserProfile_UserId");
            });

            modelBuilder.Entity<UserFavouriteTradeAd>(entity =>
            {
                entity.HasIndex(e => e.TradeAdId)
                    .HasName("IX_TradeAdID");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserID");

                entity.Property(e => e.UserFavouriteTradeAdId).HasColumnName("UserFavouriteTradeAdID");

                entity.Property(e => e.TradeAdId).HasColumnName("TradeAdID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.TradeAd)
                    .WithMany(p => p.UserFavouriteTradeAd)
                    .HasForeignKey(d => d.TradeAdId)
                    .HasConstraintName("FK_dbo.UserFavouriteTradeAd_dbo.TradeAd_TradeAdID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFavouriteTradeAd)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.UserFavouriteTradeAd_dbo.UserProfile_UserID");
            });

            modelBuilder.Entity<UserImage>(entity =>
            {
                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.UserImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.UserImage_dbo.ListingFile_ListingFileId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserImage)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserImage_dbo.UserProfile_UserId");
            });

            modelBuilder.Entity<UserIndustries>(entity =>
            {
                entity.HasKey(e => e.UiId);

                entity.HasIndex(e => e.IndustryGroupId)
                    .HasName("IX_Industry_GroupId");

                entity.HasIndex(e => e.UserUserId)
                    .HasName("IX_User_UserId");

                entity.Property(e => e.UiId).HasColumnName("uiId");

                entity.Property(e => e.ClickCounter).HasDefaultValueSql("((0))");

                entity.Property(e => e.IndustryGroupId).HasColumnName("Industry_GroupId");

                entity.Property(e => e.UserUserId).HasColumnName("User_UserId");

                entity.HasOne(d => d.IndustryGroup)
                    .WithMany(p => p.UserIndustries)
                    .HasForeignKey(d => d.IndustryGroupId)
                    .HasConstraintName("FK_dbo.UserIndustries_dbo.Groups_Industry_GroupId");

                entity.HasOne(d => d.UserUser)
                    .WithMany(p => p.UserIndustries)
                    .HasForeignKey(d => d.UserUserId)
                    .HasConstraintName("FK_dbo.UserIndustries_dbo.UserProfile_User_UserId");
            });

            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.Property(e => e.LogOutTime).HasColumnType("datetime");

                entity.Property(e => e.LoginInTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => e.AddressIdAddressTypeId)
                    .HasName("IX_AddressId_AddressTypeId");

                entity.HasIndex(e => e.ParentUserUserId)
                    .HasName("IX_ParentUser_UserId");

                entity.HasIndex(e => e.UserTypeUserTypeId)
                    .HasName("IX_UserType_UserTypeId");

                entity.Property(e => e.AddressIdAddressTypeId).HasColumnName("AddressId_AddressTypeId");

                entity.Property(e => e.ParentUserUserId).HasColumnName("ParentUser_UserId");

                entity.Property(e => e.UserTypeUserTypeId).HasColumnName("UserType_UserTypeId");

                entity.HasOne(d => d.AddressIdAddressType)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.AddressIdAddressTypeId)
                    .HasConstraintName("FK_dbo.UserProfile_dbo.Address_AddressId_AddressTypeId");

                entity.HasOne(d => d.ParentUserUser)
                    .WithMany(p => p.InverseParentUserUser)
                    .HasForeignKey(d => d.ParentUserUserId)
                    .HasConstraintName("FK_dbo.UserProfile_dbo.UserProfile_ParentUser_UserId");

                entity.HasOne(d => d.UserTypeUserType)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.UserTypeUserTypeId)
                    .HasConstraintName("FK_dbo.UserProfile_dbo.UserType_UserTypeId_UserTypeId");
            });

            modelBuilder.Entity<UserProfileChatMessage>(entity =>
            {
                entity.HasIndex(e => e.ChatMessageId)
                    .HasName("IX_ChatMessageId");

                entity.HasIndex(e => e.ReceiverId)
                    .HasName("IX_ReceiverId");

                entity.HasIndex(e => e.SenderId)
                    .HasName("IX_SenderId");

                entity.Property(e => e.ReceiverClearedDate).HasColumnType("datetime");

                entity.Property(e => e.SenderClearedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ChatMessage)
                    .WithMany(p => p.UserProfileChatMessage)
                    .HasForeignKey(d => d.ChatMessageId)
                    .HasConstraintName("FK_dbo.UserProfileChatMessage_dbo.ChatMessage_ChatMessageId");

                entity.HasOne(d => d.Receiver)
                    .WithMany(p => p.UserProfileChatMessageReceiver)
                    .HasForeignKey(d => d.ReceiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserProfileChatMessage_dbo.UserProfile_ReceiverId");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.UserProfileChatMessageSender)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserProfileChatMessage_dbo.UserProfile_SenderId");
            });

            modelBuilder.Entity<UserRoute>(entity =>
            {
                entity.HasIndex(e => e.RouteId)
                    .HasName("IX_RouteId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.ViewCount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.UserRoute)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_dbo.UserRoute_dbo.Route_RouteId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoute)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.UserRoute_dbo.UserProfile_UserId");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.HasIndex(e => e.AccessLevelAccessTypeId)
                    .HasName("IX_AccessLevel_AccessTypeId");

                entity.HasIndex(e => e.EmployeeTypeEmployeeTypeId)
                    .HasName("IX_EmployeeType_EmployeeTypeId");

                entity.HasIndex(e => e.ProfileTypeProfileTypeId)
                    .HasName("IX_ProfileType_ProfileTypeId");

                entity.Property(e => e.AccessLevelAccessTypeId).HasColumnName("AccessLevel_AccessTypeId");

                entity.Property(e => e.EmployeeTypeEmployeeTypeId).HasColumnName("EmployeeType_EmployeeTypeId");

                entity.Property(e => e.ProfileTypeProfileTypeId).HasColumnName("ProfileType_ProfileTypeId");

                entity.HasOne(d => d.AccessLevelAccessType)
                    .WithMany(p => p.UserType)
                    .HasForeignKey(d => d.AccessLevelAccessTypeId)
                    .HasConstraintName("FK_dbo.UserType_dbo.AccessType_AccessLevel_AccessTypeId");

                entity.HasOne(d => d.EmployeeTypeEmployeeType)
                    .WithMany(p => p.UserType)
                    .HasForeignKey(d => d.EmployeeTypeEmployeeTypeId)
                    .HasConstraintName("FK_dbo.UserType_dbo.EmployeeType_EmployeeType_EmployeeTypeId");

                entity.HasOne(d => d.ProfileTypeProfileType)
                    .WithMany(p => p.UserType)
                    .HasForeignKey(d => d.ProfileTypeProfileTypeId)
                    .HasConstraintName("FK_dbo.UserType_dbo.ProfileType_ProfileType_ProfileTypeId");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasIndex(e => e.MenuTypeId)
                    .HasName("IX_MenuTypeID");

                entity.HasIndex(e => e.RouteId)
                    .HasName("IX_RouteId");

                entity.HasIndex(e => e.VehicleBaseId)
                    .HasName("IX_VehicleBaseId");

                entity.Property(e => e.MenuTypeId).HasColumnName("MenuTypeID");

                entity.HasOne(d => d.MenuType)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.MenuTypeId)
                    .HasConstraintName("FK_dbo.Vehicle_dbo.MenuType_MenuTypeID");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_dbo.Vehicle_dbo.Route_RouteId");

                entity.HasOne(d => d.VehicleBase)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.VehicleBaseId)
                    .HasConstraintName("FK_dbo.Vehicle_dbo.VehicleBase_VehicleBaseId");
            });

            modelBuilder.Entity<VehicleBase>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandID");

                entity.HasIndex(e => e.EntryTypeId)
                    .HasName("IX_EntryTypeID");

                entity.HasIndex(e => e.SpecificationId)
                    .HasName("IX_SpecificationID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.EntryTypeId).HasColumnName("EntryTypeID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SpecificationId).HasColumnName("SpecificationID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.VehicleBase)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_dbo.VehicleBase_dbo.Brand_BrandID");

                entity.HasOne(d => d.EntryType)
                    .WithMany(p => p.VehicleBase)
                    .HasForeignKey(d => d.EntryTypeId)
                    .HasConstraintName("FK_dbo.VehicleBase_dbo.EntryType_EntryTypeID");

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.VehicleBase)
                    .HasForeignKey(d => d.SpecificationId)
                    .HasConstraintName("FK_dbo.VehicleBase_dbo.ListingFile_SpecificationID");
            });

            modelBuilder.Entity<VehicleImage>(entity =>
            {
                entity.HasIndex(e => e.ListingFileId)
                    .HasName("IX_ListingFileId");

                entity.HasIndex(e => e.VehicleBaseId)
                    .HasName("IX_VehicleBaseId");

                entity.HasOne(d => d.ListingFile)
                    .WithMany(p => p.VehicleImage)
                    .HasForeignKey(d => d.ListingFileId)
                    .HasConstraintName("FK_dbo.VehicleImage_dbo.ListingFile_ListingFileId");

                entity.HasOne(d => d.VehicleBase)
                    .WithMany(p => p.VehicleImage)
                    .HasForeignKey(d => d.VehicleBaseId)
                    .HasConstraintName("FK_dbo.VehicleImage_dbo.VehicleBase_VehicleBaseId");
            });

            modelBuilder.Entity<VehicleTradeAd>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_BrandId");

                entity.HasIndex(e => e.TradeAdId)
                    .HasName("IX_TradeAdId");

                entity.Property(e => e.IsOther).HasColumnName("isOther");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.VehicleTradeAd)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_dbo.VehicleTradeAd_dbo.Brand_BrandId");

                entity.HasOne(d => d.TradeAd)
                    .WithMany(p => p.VehicleTradeAd)
                    .HasForeignKey(d => d.TradeAdId)
                    .HasConstraintName("FK_dbo.VehicleTradeAd_dbo.TradeAd_TradeAdId");
            });

            modelBuilder.Entity<WaterRights>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<WebpagesMembership>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("webpages_Membership");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.ConfirmationToken).HasMaxLength(128);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordFailureDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordVerificationToken).HasMaxLength(128);

                entity.Property(e => e.PasswordVerificationTokenExpirationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WebpagesOauthMembership>(entity =>
            {
                entity.HasKey(e => new { e.Provider, e.ProviderUserId });

                entity.ToTable("webpages_OAuthMembership");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.Provider).HasMaxLength(30);

                entity.Property(e => e.ProviderUserId).HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebpagesOauthMembership)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_webpages_OAuthMembership_UserProfile");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.WebpagesOauthMembership)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.webpages_OAuthMembership_dbo.webpages_Membership_UserId");
            });

            modelBuilder.Entity<WebpagesRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("webpages_Roles");

                entity.Property(e => e.RoleName).HasMaxLength(256);
            });

            modelBuilder.Entity<WebpagesUsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("webpages_UsersInRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.WebpagesUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.webpages_UsersInRoles_dbo.webpages_Roles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebpagesUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.webpages_UsersInRoles_dbo.webpages_Membership_UserId");
            });
        }
    }
}
