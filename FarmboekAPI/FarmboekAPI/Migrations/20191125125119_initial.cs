using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FarmboekAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "__MigrationHistory",
            //    columns: table => new
            //    {
            //        MigrationId = table.Column<string>(maxLength: 150, nullable: false),
            //        ContextKey = table.Column<string>(maxLength: 300, nullable: false),
            //        Model = table.Column<byte[]>(nullable: false),
            //        ProductVersion = table.Column<string>(maxLength: 32, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK___MigrationHistory", x => new { x.MigrationId, x.ContextKey });
            //    });

            //    migrationBuilder.CreateTable(
            //        name: "AccessType",
            //        columns: table => new
            //        {
            //            AccessTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_AccessType", x => x.AccessTypeId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ActiveIngredient",
            //        columns: table => new
            //        {
            //            ActiveIngredientId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Code = table.Column<string>(nullable: false),
            //            Name = table.Column<string>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ActiveIngredient", x => x.ActiveIngredientId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Agency",
            //        columns: table => new
            //        {
            //            AgencyId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            AgencyName = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Agency", x => x.AgencyId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "AspNetRoles",
            //        columns: table => new
            //        {
            //            Id = table.Column<string>(nullable: false),
            //            Name = table.Column<string>(maxLength: 256, nullable: true),
            //            NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
            //            ConcurrencyStamp = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_AspNetRoles", x => x.Id);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "AspNetUsers",
            //        columns: table => new
            //        {
            //            Id = table.Column<string>(nullable: false),
            //            UserName = table.Column<string>(maxLength: 256, nullable: true),
            //            NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
            //            Email = table.Column<string>(maxLength: 256, nullable: true),
            //            NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
            //            EmailConfirmed = table.Column<bool>(nullable: false),
            //            PasswordHash = table.Column<string>(nullable: true),
            //            SecurityStamp = table.Column<string>(nullable: true),
            //            ConcurrencyStamp = table.Column<string>(nullable: true),
            //            PhoneNumber = table.Column<string>(nullable: true),
            //            PhoneNumberConfirmed = table.Column<bool>(nullable: false),
            //            TwoFactorEnabled = table.Column<bool>(nullable: false),
            //            LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
            //            LockoutEnabled = table.Column<bool>(nullable: false),
            //            AccessFailedCount = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Attribute",
            //        columns: table => new
            //        {
            //            AttributeID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Key = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Attribute", x => x.AttributeID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "AuctionCategory",
            //        columns: table => new
            //        {
            //            AuctionCategoryId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            CategoryName = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_AuctionCategory", x => x.AuctionCategoryId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Bank",
            //        columns: table => new
            //        {
            //            BankId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true),
            //            Code = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Bank", x => x.BankId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "BankAccountType",
            //        columns: table => new
            //        {
            //            BankAccountTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true),
            //            Desc = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_BankAccountType", x => x.BankAccountTypeId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "BusinessEntityBase",
            //        columns: table => new
            //        {
            //            BusinessEntityBaseId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_BusinessEntityBase", x => x.BusinessEntityBaseId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "BusinessEntityType",
            //        columns: table => new
            //        {
            //            BusinessEntityTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_BusinessEntityType", x => x.BusinessEntityTypeId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "BusinessType",
            //        columns: table => new
            //        {
            //            BusinessTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true),
            //            Description = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_BusinessType", x => x.BusinessTypeId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "BussinessProfile",
            //        columns: table => new
            //        {
            //            BusinessId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            CountryID = table.Column<int>(nullable: false),
            //            BusinessName = table.Column<string>(maxLength: 100, nullable: false),
            //            Address1 = table.Column<string>(maxLength: 100, nullable: false),
            //            Address2 = table.Column<string>(maxLength: 100, nullable: false),
            //            AreaCode = table.Column<string>(maxLength: 100, nullable: false),
            //            ProvinceID = table.Column<int>(nullable: false),
            //            TownID = table.Column<int>(nullable: false),
            //            PostalAddress1 = table.Column<string>(maxLength: 100, nullable: true),
            //            PostalAddress2 = table.Column<string>(maxLength: 100, nullable: true),
            //            PostCode = table.Column<string>(maxLength: 100, nullable: true),
            //            WorkTel = table.Column<string>(maxLength: 100, nullable: false),
            //            WorkFax = table.Column<string>(maxLength: 100, nullable: true),
            //            CellNo = table.Column<string>(maxLength: 100, nullable: true),
            //            PrimaryActivityID = table.Column<int>(nullable: false),
            //            BusinessTypeID = table.Column<int>(nullable: false),
            //            RegistrationNo = table.Column<string>(maxLength: 100, nullable: false),
            //            VatNo = table.Column<string>(maxLength: 100, nullable: true),
            //            AccountHolder = table.Column<string>(maxLength: 100, nullable: true),
            //            AccountNumber = table.Column<string>(maxLength: 100, nullable: true),
            //            BankID = table.Column<int>(nullable: false),
            //            BranchCode = table.Column<string>(maxLength: 100, nullable: true),
            //            AccountTypeID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_BussinessProfile", x => x.BusinessId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "CensoredWord",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Text = table.Column<string>(nullable: true),
            //            DateUpdated = table.Column<DateTime>(type: "datetime", nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_CensoredWord", x => x.Id);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ClassifiedAdRegion",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true),
            //            Desc = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ClassifiedAdRegion", x => x.Id);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ClassifiedsCategories",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true),
            //            Desc = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ClassifiedsCategories", x => x.Id);
            //        });

            //migrationBuilder.CreateTable(
            //    name: "Comments",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MediaId = table.Column<int>(nullable: false),
            //        UserId = table.Column<int>(nullable: false),
            //        Comment = table.Column<string>(nullable: true),
            //        CommentDate = table.Column<DateTime>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Comments", x => x.Id);
            //    });

            //    migrationBuilder.CreateTable(
            //        name: "CompanyType",
            //        columns: table => new
            //        {
            //            CompanyTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_CompanyType", x => x.CompanyTypeId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Contact",
            //        columns: table => new
            //        {
            //            ContactId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            FullName = table.Column<string>(nullable: true),
            //            TelNumber = table.Column<string>(nullable: true),
            //            CellNumber = table.Column<string>(nullable: true),
            //            Email = table.Column<string>(nullable: true),
            //            Website = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Contact", x => x.ContactId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Country",
            //        columns: table => new
            //        {
            //            CountryId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            CountryName = table.Column<string>(nullable: true),
            //            CountryCode = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Country", x => x.CountryId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EmployeeType",
            //        columns: table => new
            //        {
            //            EmployeeTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EmployeeType", x => x.EmployeeTypeId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EntryType",
            //        columns: table => new
            //        {
            //            EntryTypeID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Type = table.Column<string>(nullable: true),
            //            Subtype = table.Column<string>(nullable: true),
            //            Key = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EntryType", x => x.EntryTypeID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EntryTypeTemplate",
            //        columns: table => new
            //        {
            //            EntryTypeTemplateID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EntryTypeTemplate", x => x.EntryTypeTemplateID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EquipmentFarm",
            //        columns: table => new
            //        {
            //            EquipmentID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Title = table.Column<string>(nullable: true),
            //            Description = table.Column<string>(nullable: true),
            //            FarmID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EquipmentFarm", x => x.EquipmentID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "FarmType",
            //        columns: table => new
            //        {
            //            FarmTypeID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            FarmID = table.Column<int>(nullable: false),
            //            IndustryHa = table.Column<string>(nullable: true),
            //            Drainage = table.Column<string>(nullable: true),
            //            Irrigation = table.Column<string>(nullable: true),
            //            Fencing = table.Column<string>(nullable: true),
            //            Description = table.Column<string>(nullable: true),
            //            SuperGroupID = table.Column<int>(nullable: false),
            //            SuperGroupName = table.Column<string>(nullable: true),
            //            SubGroupID = table.Column<int>(nullable: false),
            //            SubGroupName = table.Column<string>(nullable: true),
            //            ListingFileID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_FarmType", x => x.FarmTypeID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Function",
            //        columns: table => new
            //        {
            //            FunctionID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            FunctionNo = table.Column<string>(maxLength: 30, nullable: false),
            //            FunctionName = table.Column<string>(maxLength: 50, nullable: false),
            //            Category = table.Column<string>(maxLength: 50, nullable: false),
            //            FunctionDescription = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Function", x => x.FunctionID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "GroupList",
            //        columns: table => new
            //        {
            //            GroupListId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            GroupListName = table.Column<string>(nullable: true),
            //            GroupListDesc = table.Column<string>(nullable: true),
            //            IsCommercial = table.Column<bool>(nullable: false),
            //            IsInformation = table.Column<bool>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_GroupList", x => x.GroupListId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Groups",
            //        columns: table => new
            //        {
            //            GroupId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            GroupName = table.Column<string>(nullable: true),
            //            GroupDesc = table.Column<string>(nullable: true),
            //            IsCommercial = table.Column<bool>(nullable: false),
            //            IsInformation = table.Column<bool>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Groups", x => x.GroupId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Infrastructure",
            //        columns: table => new
            //        {
            //            InfrastructureID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Infrastructure", x => x.InfrastructureID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Institution",
            //        columns: table => new
            //        {
            //            InstitutionId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Institution", x => x.InstitutionId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Likes",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            MediaId = table.Column<int>(nullable: false),
            //            UserId = table.Column<int>(nullable: false),
            //            DateLiked = table.Column<DateTime>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Likes", x => x.Id);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "LinkRequestType",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_LinkRequestType", x => x.Id);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ListingEntry",
            //        columns: table => new
            //        {
            //            ListingEntryId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ListingEntryName = table.Column<string>(nullable: false),
            //            ListingEntryDesc = table.Column<string>(nullable: false),
            //            IsInformation = table.Column<bool>(nullable: false),
            //            IsCommercial = table.Column<bool>(nullable: false),
            //            Price = table.Column<double>(nullable: false),
            //            ActiveIngredient = table.Column<string>(nullable: true),
            //            Remedy = table.Column<string>(nullable: true),
            //            Rating = table.Column<int>(nullable: false),
            //            ExernalLink = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ListingEntry", x => x.ListingEntryId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ListingFile",
            //        columns: table => new
            //        {
            //            ListingFileId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            FilePath = table.Column<string>(nullable: true),
            //            FileDescription = table.Column<string>(nullable: true),
            //            OriginalFilename = table.Column<string>(nullable: true),
            //            FileType = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ListingFile", x => x.ListingFileId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ListType",
            //        columns: table => new
            //        {
            //            ListTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ListTypeName = table.Column<string>(nullable: true),
            //            ListTypeDesc = table.Column<string>(nullable: true),
            //            HasPrice = table.Column<bool>(nullable: false),
            //            HasActiveIngredient = table.Column<bool>(nullable: false),
            //            HasRemedy = table.Column<bool>(nullable: false),
            //            HasRating = table.Column<bool>(nullable: false),
            //            HasExternalLink = table.Column<bool>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ListType", x => x.ListTypeId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ManagementGroup",
            //        columns: table => new
            //        {
            //            ManagementGroupId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true),
            //            Description = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ManagementGroup", x => x.ManagementGroupId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Market",
            //        columns: table => new
            //        {
            //            MarketId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Code = table.Column<string>(nullable: true),
            //            StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //            EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //            Active = table.Column<bool>(nullable: false),
            //            Category = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Market", x => x.MarketId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Media",
            //        columns: table => new
            //        {
            //            MediaId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Description = table.Column<string>(nullable: true),
            //            Title = table.Column<string>(nullable: true),
            //            Url = table.Column<string>(nullable: true),
            //            IsActive = table.Column<bool>(nullable: false),
            //            ImageUrl = table.Column<string>(nullable: true),
            //            CatagoryId = table.Column<int>(nullable: false),
            //            WebLink = table.Column<string>(nullable: true),
            //            YoutubeLink = table.Column<string>(nullable: true),
            //            MediaDate = table.Column<DateTime>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Media", x => x.MediaId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "MenuType",
            //        columns: table => new
            //        {
            //            MenuTypeID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true),
            //            Key = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_MenuType", x => x.MenuTypeID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "NewsCat",
            //        columns: table => new
            //        {
            //            NewsCatId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Description = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_NewsCat", x => x.NewsCatId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Page",
            //        columns: table => new
            //        {
            //            PageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            PageName = table.Column<string>(nullable: true),
            //            PageTitle = table.Column<string>(nullable: true),
            //            PageSubTitle = table.Column<string>(nullable: true),
            //            PageContent = table.Column<string>(nullable: true),
            //            PagePath = table.Column<string>(nullable: true),
            //            PageKeyWords = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Page", x => x.PageId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ProblemType",
            //        columns: table => new
            //        {
            //            ProblemTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ProblemType", x => x.ProblemTypeId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ProductType",
            //        columns: table => new
            //        {
            //            ProductTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ProductType", x => x.ProductTypeId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ProfileType",
            //        columns: table => new
            //        {
            //            ProfileTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ProfileType", x => x.ProfileTypeId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "PropertyAdditional",
            //        columns: table => new
            //        {
            //            PropertyAdditionalID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            PropertyId = table.Column<int>(nullable: false),
            //            PropID = table.Column<int>(nullable: false),
            //            Description = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_PropertyAdditional", x => x.PropertyAdditionalID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "PropertyCategory",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true),
            //            Desc = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_PropertyCategory", x => x.Id);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "RemedyType",
            //        columns: table => new
            //        {
            //            RemedyTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Description = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_RemedyType", x => x.RemedyTypeId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Section",
            //        columns: table => new
            //        {
            //            SectionId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            SectionName = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Section", x => x.SectionId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Setting",
            //        columns: table => new
            //        {
            //            SettingId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Key = table.Column<string>(nullable: true),
            //            Value = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Setting", x => x.SettingId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Shares",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            MediaId = table.Column<int>(nullable: false),
            //            UserId = table.Column<int>(nullable: false),
            //            DateShared = table.Column<DateTime>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Shares", x => x.Id);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "SocialMediaCatagories",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Description = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_SocialMediaCatagories", x => x.Id);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Specification",
            //        columns: table => new
            //        {
            //            SpecificationId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Code = table.Column<string>(nullable: false),
            //            Text = table.Column<string>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Specification", x => x.SpecificationId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "SubGroups",
            //        columns: table => new
            //        {
            //            SubGroupId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            SubGroupName = table.Column<string>(nullable: true),
            //            SubGroupDesc = table.Column<string>(nullable: true),
            //            IsCommercial = table.Column<bool>(nullable: false),
            //            IsInformation = table.Column<bool>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_SubGroups", x => x.SubGroupId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "SuperGroups",
            //        columns: table => new
            //        {
            //            SuperGroupId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            SuperGroupName = table.Column<string>(nullable: true),
            //            SuperGroupDesc = table.Column<string>(nullable: true),
            //            IsCommercial = table.Column<bool>(nullable: false),
            //            IsInformation = table.Column<bool>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_SuperGroups", x => x.SuperGroupId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Symptom",
            //        columns: table => new
            //        {
            //            SymptomId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Code = table.Column<string>(nullable: false),
            //            Text = table.Column<string>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Symptom", x => x.SymptomId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "TopLevelItem",
            //        columns: table => new
            //        {
            //            Code = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1")
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_TopLevelItem", x => x.Code);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "TradeSafeLog",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Message = table.Column<string>(nullable: true),
            //            Created = table.Column<DateTime>(type: "datetime", nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_TradeSafeLog", x => x.Id);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "UserLog",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Firstname = table.Column<string>(nullable: true),
            //            Lastname = table.Column<string>(nullable: true),
            //            Username = table.Column<string>(nullable: true),
            //            LoginInTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //            Status = table.Column<string>(nullable: true),
            //            LogOutTime = table.Column<DateTime>(type: "datetime", nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_UserLog", x => x.Id);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "UserWeatherSetting",
            //        columns: table => new
            //        {
            //            UserWeatherSettingId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            UserId = table.Column<int>(nullable: false),
            //            DefaultLongitude = table.Column<string>(nullable: true),
            //            DefaultLatitude = table.Column<string>(nullable: true),
            //            LocationName = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_UserWeatherSetting", x => x.UserWeatherSettingId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "WaterRights",
            //        columns: table => new
            //        {
            //            ID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_WaterRights", x => x.ID);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "webpages_Membership",
            //        columns: table => new
            //        {
            //            UserId = table.Column<int>(nullable: false),
            //            CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //            ConfirmationToken = table.Column<string>(maxLength: 128, nullable: true),
            //            IsConfirmed = table.Column<bool>(nullable: true),
            //            LastPasswordFailureDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //            PasswordFailuresSinceLastSuccess = table.Column<int>(nullable: false),
            //            Password = table.Column<string>(maxLength: 128, nullable: false),
            //            PasswordChangedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //            PasswordSalt = table.Column<string>(maxLength: 128, nullable: false),
            //            PasswordVerificationToken = table.Column<string>(maxLength: 128, nullable: true),
            //            PasswordVerificationTokenExpirationDate = table.Column<DateTime>(type: "datetime", nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_webpages_Membership", x => x.UserId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "webpages_Roles",
            //        columns: table => new
            //        {
            //            RoleId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            RoleName = table.Column<string>(maxLength: 256, nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_webpages_Roles", x => x.RoleId);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "AspNetRoleClaims",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            RoleId = table.Column<string>(nullable: false),
            //            ClaimType = table.Column<string>(nullable: true),
            //            ClaimValue = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
            //                column: x => x.RoleId,
            //                principalTable: "AspNetRoles",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "AspNetUserClaims",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            UserId = table.Column<string>(nullable: false),
            //            ClaimType = table.Column<string>(nullable: true),
            //            ClaimValue = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
            //                column: x => x.UserId,
            //                principalTable: "AspNetUsers",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "AspNetUserLogins",
            //        columns: table => new
            //        {
            //            LoginProvider = table.Column<string>(nullable: false),
            //            ProviderKey = table.Column<string>(nullable: false),
            //            ProviderDisplayName = table.Column<string>(nullable: true),
            //            UserId = table.Column<string>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
            //            table.ForeignKey(
            //                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
            //                column: x => x.UserId,
            //                principalTable: "AspNetUsers",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "AspNetUserRoles",
            //        columns: table => new
            //        {
            //            UserId = table.Column<string>(nullable: false),
            //            RoleId = table.Column<string>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
            //            table.ForeignKey(
            //                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
            //                column: x => x.RoleId,
            //                principalTable: "AspNetRoles",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
            //                column: x => x.UserId,
            //                principalTable: "AspNetUsers",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "AspNetUserTokens",
            //        columns: table => new
            //        {
            //            UserId = table.Column<string>(nullable: false),
            //            LoginProvider = table.Column<string>(nullable: false),
            //            Name = table.Column<string>(nullable: false),
            //            Value = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
            //            table.ForeignKey(
            //                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //                column: x => x.UserId,
            //                principalTable: "AspNetUsers",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Brand",
            //        columns: table => new
            //        {
            //            BrandId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true),
            //            Description = table.Column<string>(nullable: true),
            //            Summary = table.Column<string>(nullable: true),
            //            Address = table.Column<string>(nullable: true),
            //            ContactId = table.Column<int>(nullable: true),
            //            AccountNo = table.Column<string>(nullable: true),
            //            IsActive = table.Column<bool>(nullable: false),
            //            HasPaid = table.Column<bool>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Brand", x => x.BrandId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Brand_dbo.Contact_ContactId",
            //                column: x => x.ContactId,
            //                principalTable: "Contact",
            //                principalColumn: "ContactId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Province",
            //        columns: table => new
            //        {
            //            ProvinceId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            CountryId = table.Column<int>(nullable: false),
            //            ProvinceName = table.Column<string>(nullable: true),
            //            ProvinceCode = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Province", x => x.ProvinceId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Province_dbo.Country_CountryId",
            //                column: x => x.CountryId,
            //                principalTable: "Country",
            //                principalColumn: "CountryId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ProblemBase",
            //        columns: table => new
            //        {
            //            ProblemBaseId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: false),
            //            Information = table.Column<string>(nullable: true),
            //            Symptoms = table.Column<string>(nullable: true),
            //            Morbidity = table.Column<string>(nullable: true),
            //            Epidemiology = table.Column<string>(nullable: true),
            //            EntryTypeID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ProblemBase", x => x.ProblemBaseId);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProblemBase_dbo.EntryType_EntryTypeID",
            //                column: x => x.EntryTypeID,
            //                principalTable: "EntryType",
            //                principalColumn: "EntryTypeID",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EntryTypeTemplateAttribute",
            //        columns: table => new
            //        {
            //            EntryTypeTemplateAttributeID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            EntryTypeTemplateID = table.Column<int>(nullable: false),
            //            AttributeID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EntryTypeTemplateAttribute", x => x.EntryTypeTemplateAttributeID);
            //            table.ForeignKey(
            //                name: "FK_dbo.EntryTypeTemplateAttribute_dbo.Attribute_AttributeID",
            //                column: x => x.AttributeID,
            //                principalTable: "Attribute",
            //                principalColumn: "AttributeID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.EntryTypeTemplateAttribute_dbo.EntryTypeTemplate_EntryTypeTemplateID",
            //                column: x => x.EntryTypeTemplateID,
            //                principalTable: "EntryTypeTemplate",
            //                principalColumn: "EntryTypeTemplateID",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "FarmInfrastructure",
            //        columns: table => new
            //        {
            //            FarmInfrastructureID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            InfrastructureID = table.Column<int>(nullable: false),
            //            FarmID = table.Column<int>(nullable: false),
            //            InfrastructureName = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_FarmInfrastructure", x => x.FarmInfrastructureID);
            //            table.ForeignKey(
            //                name: "FK_dbo.FarmInfrastructure_dbo.Infrastructure_InfrastructureID",
            //                column: x => x.InfrastructureID,
            //                principalTable: "Infrastructure",
            //                principalColumn: "InfrastructureID",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "BusinessEntityImage",
            //        columns: table => new
            //        {
            //            BusinessEntityImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            BusinessEntityBaseId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_BusinessEntityImage", x => x.BusinessEntityImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.BusinessEntityImage_dbo.BusinessEntityBase_BusinessEntityBaseId",
            //                column: x => x.BusinessEntityBaseId,
            //                principalTable: "BusinessEntityBase",
            //                principalColumn: "BusinessEntityBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.BusinessEntityImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ChatMessage",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Text = table.Column<string>(nullable: true),
            //            SentDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //            SeenDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //            ListingFileImageId = table.Column<int>(nullable: true),
            //            ListingFileVideoId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ChatMessage", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.ChatMessage_dbo.ListingFile_ListingFileImageId",
            //                column: x => x.ListingFileImageId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.ChatMessage_dbo.ListingFile_ListingFileVideoId",
            //                column: x => x.ListingFileVideoId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "FarmImage",
            //        columns: table => new
            //        {
            //            FarmImageID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            FarmID = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_FarmImage", x => x.FarmImageID);
            //            table.ForeignKey(
            //                name: "FK_dbo.FarmImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "MessageImage",
            //        columns: table => new
            //        {
            //            MessageImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            MessageId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_MessageImage", x => x.MessageImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.MessageImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "MarketPDF",
            //        columns: table => new
            //        {
            //            MarketPDFID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            MarketId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_MarketPDF", x => x.MarketPDFID);
            //            table.ForeignKey(
            //                name: "FK_dbo.MarketPDF_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.MarketPDF_dbo.Market_MarketId",
            //                column: x => x.MarketId,
            //                principalTable: "Market",
            //                principalColumn: "MarketId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "News",
            //        columns: table => new
            //        {
            //            NewsId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Author = table.Column<string>(nullable: true),
            //            Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //            Headline = table.Column<string>(nullable: true),
            //            Body = table.Column<string>(nullable: true),
            //            Link = table.Column<string>(nullable: true),
            //            Active = table.Column<bool>(nullable: false),
            //            NewsCatId = table.Column<int>(nullable: false),
            //            Intro = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_News", x => x.NewsId);
            //            table.ForeignKey(
            //                name: "FK_dbo.News_dbo.NewsCat_NewsCatId",
            //                column: x => x.NewsCatId,
            //                principalTable: "NewsCat",
            //                principalColumn: "NewsCatId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "UserType",
            //        columns: table => new
            //        {
            //            UserTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            AccessLevel_AccessTypeId = table.Column<int>(nullable: true),
            //            EmployeeType_EmployeeTypeId = table.Column<int>(nullable: true),
            //            ProfileType_ProfileTypeId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_UserType", x => x.UserTypeId);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserType_dbo.AccessType_AccessLevel_AccessTypeId",
            //                column: x => x.AccessLevel_AccessTypeId,
            //                principalTable: "AccessType",
            //                principalColumn: "AccessTypeId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserType_dbo.EmployeeType_EmployeeType_EmployeeTypeId",
            //                column: x => x.EmployeeType_EmployeeTypeId,
            //                principalTable: "EmployeeType",
            //                principalColumn: "EmployeeTypeId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserType_dbo.ProfileType_ProfileType_ProfileTypeId",
            //                column: x => x.ProfileType_ProfileTypeId,
            //                principalTable: "ProfileType",
            //                principalColumn: "ProfileTypeId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "PropertyAdditionalImage",
            //        columns: table => new
            //        {
            //            PropAddID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            PropertyAdditionalID = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_PropertyAdditionalImage", x => x.PropAddID);
            //            table.ForeignKey(
            //                name: "FK_dbo.PropertyAdditionalImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.PropertyAdditionalImage_dbo.PropertyAdditional_PropertyAdditionalID",
            //                column: x => x.PropertyAdditionalID,
            //                principalTable: "PropertyAdditional",
            //                principalColumn: "PropertyAdditionalID",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "GroupSubGroups",
            //        columns: table => new
            //        {
            //            GroupSubGroupId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Code = table.Column<string>(nullable: true),
            //            GroupId = table.Column<int>(nullable: false),
            //            SubGroupId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_GroupSubGroups", x => x.GroupSubGroupId);
            //            table.ForeignKey(
            //                name: "FK_dbo.GroupSubGroups_dbo.Groups_GroupId",
            //                column: x => x.GroupId,
            //                principalTable: "Groups",
            //                principalColumn: "GroupId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.GroupSubGroups_dbo.SubGroups_SubGroupId",
            //                column: x => x.SubGroupId,
            //                principalTable: "SubGroups",
            //                principalColumn: "SubGroupId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "SubGroupGroupList",
            //        columns: table => new
            //        {
            //            SubGroupGroupListId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ListType_ListTypeId = table.Column<int>(nullable: true),
            //            SubGroup_SubGroupId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_SubGroupGroupList", x => x.SubGroupGroupListId);
            //            table.ForeignKey(
            //                name: "FK_dbo.SubGroupGroupList_dbo.ListType_ListType_ListTypeId",
            //                column: x => x.ListType_ListTypeId,
            //                principalTable: "ListType",
            //                principalColumn: "ListTypeId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.SubGroupGroupList_dbo.SubGroups_SubGroup_SubGroupId",
            //                column: x => x.SubGroup_SubGroupId,
            //                principalTable: "SubGroups",
            //                principalColumn: "SubGroupId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "GroupSuperGroups",
            //        columns: table => new
            //        {
            //            GroupSuperGroupId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Code = table.Column<string>(nullable: true),
            //            SuperGroupId = table.Column<int>(nullable: false),
            //            GroupId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_GroupSuperGroups", x => x.GroupSuperGroupId);
            //            table.ForeignKey(
            //                name: "FK_dbo.GroupSuperGroups_dbo.Groups_GroupId",
            //                column: x => x.GroupId,
            //                principalTable: "Groups",
            //                principalColumn: "GroupId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.GroupSuperGroups_dbo.SuperGroups_SuperGroupId",
            //                column: x => x.SuperGroupId,
            //                principalTable: "SuperGroups",
            //                principalColumn: "SuperGroupId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "FarmWaterRight",
            //        columns: table => new
            //        {
            //            FarmWaterRightID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            FarmID = table.Column<int>(nullable: false),
            //            WaterRightID = table.Column<int>(nullable: false),
            //            WaterRightName = table.Column<string>(nullable: true),
            //            HaListed = table.Column<string>(nullable: true),
            //            m3Listed = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_FarmWaterRight", x => x.FarmWaterRightID);
            //            table.ForeignKey(
            //                name: "FK_dbo.FarmWaterRight_dbo.WaterRights_WaterRightID",
            //                column: x => x.WaterRightID,
            //                principalTable: "WaterRights",
            //                principalColumn: "ID",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "RoleFunction",
            //        columns: table => new
            //        {
            //            RoleFunctionID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            FunctionID = table.Column<int>(nullable: false),
            //            RoleID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_RoleFunction", x => x.RoleFunctionID);
            //            table.ForeignKey(
            //                name: "FK_dbo.RoleFunction_dbo.Function_FunctionID",
            //                column: x => x.FunctionID,
            //                principalTable: "Function",
            //                principalColumn: "FunctionID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.RoleFunction_dbo.webpages_Roles_RoleID",
            //                column: x => x.RoleID,
            //                principalTable: "webpages_Roles",
            //                principalColumn: "RoleId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "webpages_UsersInRoles",
            //        columns: table => new
            //        {
            //            UserId = table.Column<int>(nullable: false),
            //            RoleId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_webpages_UsersInRoles", x => new { x.UserId, x.RoleId });
            //            table.ForeignKey(
            //                name: "FK_dbo.webpages_UsersInRoles_dbo.webpages_Roles_RoleId",
            //                column: x => x.RoleId,
            //                principalTable: "webpages_Roles",
            //                principalColumn: "RoleId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.webpages_UsersInRoles_dbo.webpages_Membership_UserId",
            //                column: x => x.UserId,
            //                principalTable: "webpages_Membership",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "BrandImage",
            //        columns: table => new
            //        {
            //            BrandImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            BrandId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_BrandImage", x => x.BrandImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.BrandImage_dbo.Brand_BrandId",
            //                column: x => x.BrandId,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.BrandImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "CombineBase",
            //        columns: table => new
            //        {
            //            CombineBaseId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            EntryTypeID = table.Column<int>(nullable: false),
            //            BrandID = table.Column<int>(nullable: true),
            //            Name = table.Column<string>(nullable: false),
            //            EngineMake = table.Column<string>(nullable: true),
            //            EngineModel = table.Column<string>(nullable: true),
            //            EngineType = table.Column<string>(nullable: true),
            //            Aspiration = table.Column<string>(nullable: true),
            //            EnginePowerkW = table.Column<string>(nullable: true),
            //            MaxPowerEngineSpeedrpm = table.Column<string>(nullable: true),
            //            Displacementcm3 = table.Column<string>(nullable: true),
            //            NoOfCylinders = table.Column<string>(nullable: true),
            //            FueltankCapacitylitres = table.Column<string>(nullable: true),
            //            Transmission = table.Column<string>(nullable: true),
            //            GroundSpeed1stkmPerh = table.Column<string>(nullable: true),
            //            GroundSpeed2ndkmPerh = table.Column<string>(nullable: true),
            //            GroundSpeed3rdkmPerh = table.Column<string>(nullable: true),
            //            GroundSpeed4thkmPerh = table.Column<string>(nullable: true),
            //            AutoHeaderHeightControl = table.Column<string>(nullable: true),
            //            LateralFloat = table.Column<string>(nullable: true),
            //            AutoFloat = table.Column<string>(nullable: true),
            //            ReelAndPickupDrive = table.Column<string>(nullable: true),
            //            ThreshingSystem = table.Column<string>(nullable: true),
            //            ThreshingConcavesWrapAngle = table.Column<string>(nullable: true),
            //            ThreshingConcavesWrapAngleExtension = table.Column<string>(nullable: true),
            //            ThreshingConcavesAdjustment = table.Column<string>(nullable: true),
            //            SeperationConcavesGratesPerRotor = table.Column<string>(nullable: true),
            //            SeperationConcavesWrapAngel = table.Column<string>(nullable: true),
            //            DischargeBeater = table.Column<string>(nullable: true),
            //            TotalSeperationAream2 = table.Column<string>(nullable: true),
            //            SelfLevelingShoe = table.Column<string>(nullable: true),
            //            PreCleaningSystem = table.Column<string>(nullable: true),
            //            RemoteSieveSettings = table.Column<string>(nullable: true),
            //            ShoeSystem = table.Column<string>(nullable: true),
            //            SieveAream2 = table.Column<string>(nullable: true),
            //            CleaningFanSpeedrpm = table.Column<string>(nullable: true),
            //            GrainTankCapacitylitres = table.Column<string>(nullable: true),
            //            UnloadingTubeLengthm = table.Column<string>(nullable: true),
            //            UnloadingTubeLengthExtm = table.Column<string>(nullable: true),
            //            UnloadingSpeedlitersPersec = table.Column<string>(nullable: true),
            //            TyreSizeFront = table.Column<string>(nullable: true),
            //            TyreSizeRear = table.Column<string>(nullable: true),
            //            OverallLenghtm = table.Column<string>(nullable: true),
            //            StandardWidthm = table.Column<string>(nullable: true),
            //            HeightCabm = table.Column<string>(nullable: true),
            //            Wheelbasem = table.Column<string>(nullable: true),
            //            TurningRadiusm = table.Column<string>(nullable: true),
            //            Weightkg = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_CombineBase", x => x.CombineBaseId);
            //            table.ForeignKey(
            //                name: "FK_dbo.CombineBase_dbo.Brand_BrandID",
            //                column: x => x.BrandID,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.CombineBase_dbo.EntryType_EntryTypeID",
            //                column: x => x.EntryTypeID,
            //                principalTable: "EntryType",
            //                principalColumn: "EntryTypeID",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Entry",
            //        columns: table => new
            //        {
            //            EntryID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true),
            //            IsBrowseBy = table.Column<bool>(nullable: false),
            //            IsInfo = table.Column<bool>(nullable: false),
            //            BrandID = table.Column<int>(nullable: true),
            //            EntryTypeTemplateID = table.Column<int>(nullable: true),
            //            Range = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Entry", x => x.EntryID);
            //            table.ForeignKey(
            //                name: "FK_dbo.Entry_dbo.Brand_BrandID",
            //                column: x => x.BrandID,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Entry_dbo.EntryTypeTemplate_EntryTypeTemplateID",
            //                column: x => x.EntryTypeTemplateID,
            //                principalTable: "EntryTypeTemplate",
            //                principalColumn: "EntryTypeTemplateID",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EquipmentBase",
            //        columns: table => new
            //        {
            //            EquipmentBaseId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: false),
            //            Information = table.Column<string>(nullable: true),
            //            SpecificationID = table.Column<int>(nullable: true),
            //            EntryTypeID = table.Column<int>(nullable: false),
            //            BrandID = table.Column<int>(nullable: true),
            //            Specification_ListingFileId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EquipmentBase", x => x.EquipmentBaseId);
            //            table.ForeignKey(
            //                name: "FK_dbo.EquipmentBase_dbo.Brand_BrandID",
            //                column: x => x.BrandID,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.EquipmentBase_dbo.EntryType_EntryTypeID",
            //                column: x => x.EntryTypeID,
            //                principalTable: "EntryType",
            //                principalColumn: "EntryTypeID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.EquipmentBase_dbo.ListingFile_Specification_ListingFileId",
            //                column: x => x.Specification_ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ProductBase",
            //        columns: table => new
            //        {
            //            ProductBaseId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: false),
            //            Information = table.Column<string>(nullable: true),
            //            Formulation = table.Column<string>(nullable: true),
            //            Registration = table.Column<string>(nullable: true),
            //            Concentration = table.Column<string>(nullable: true),
            //            EntryTypeID = table.Column<int>(nullable: false),
            //            BrandID = table.Column<int>(nullable: false),
            //            Range = table.Column<string>(nullable: true),
            //            brandProductDisplay = table.Column<bool>(nullable: true, defaultValueSql: "((1))")
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ProductBase", x => x.ProductBaseId);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProductBase_dbo.Brand_BrandID",
            //                column: x => x.BrandID,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProductBase_dbo.EntryType_EntryTypeID",
            //                column: x => x.EntryTypeID,
            //                principalTable: "EntryType",
            //                principalColumn: "EntryTypeID",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "RelatedBrand",
            //        columns: table => new
            //        {
            //            RelatedBrandId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            BrandId = table.Column<int>(nullable: false),
            //            ChildBrandId = table.Column<int>(nullable: false),
            //            Brand_BrandId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_RelatedBrand", x => x.RelatedBrandId);
            //            table.ForeignKey(
            //                name: "FK_dbo.RelatedBrand_dbo.Brand_Brand_BrandId",
            //                column: x => x.Brand_BrandId,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.RelatedBrand_dbo.Brand_BrandId",
            //                column: x => x.BrandId,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.RelatedBrand_dbo.Brand_ChildBrandId",
            //                column: x => x.ChildBrandId,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "TractorBase",
            //        columns: table => new
            //        {
            //            TractorBaseId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: false),
            //            EngineMake = table.Column<string>(nullable: true),
            //            EngineModel = table.Column<string>(nullable: true),
            //            EngineType = table.Column<string>(nullable: true),
            //            Aspiration = table.Column<string>(nullable: true),
            //            EnginePowerkw = table.Column<string>(nullable: true),
            //            MaxPowerEngineSpeedrpm = table.Column<string>(nullable: true),
            //            MaxTorque = table.Column<string>(nullable: true),
            //            MaxTorqueEngineSpeedrpm = table.Column<string>(nullable: true),
            //            PTO_Powerkw = table.Column<string>(nullable: true),
            //            Displacementcm3 = table.Column<string>(nullable: true),
            //            NoOfCylinders = table.Column<string>(nullable: true),
            //            PTO_Speed = table.Column<string>(nullable: true),
            //            FueltankCapacity = table.Column<string>(nullable: true),
            //            PumpFlowStandardlpm = table.Column<string>(nullable: true),
            //            PumpFlowOptionlpm = table.Column<string>(nullable: true),
            //            LiftCapacitykg = table.Column<string>(nullable: true),
            //            Drive = table.Column<string>(nullable: true),
            //            TransmissionSpeeds = table.Column<string>(nullable: true),
            //            Cab = table.Column<string>(nullable: true),
            //            TyreSizeFront = table.Column<string>(nullable: true),
            //            TyreSizeRear = table.Column<string>(nullable: true),
            //            OverallLenghtmm = table.Column<string>(nullable: true),
            //            StandardWidthmm = table.Column<string>(nullable: true),
            //            HeightROPSmm = table.Column<string>(nullable: true),
            //            HeightCabmm = table.Column<string>(nullable: true),
            //            Wheelbasemm = table.Column<string>(nullable: true),
            //            GroundClearancemm = table.Column<string>(nullable: true),
            //            TrackWidthMinmm = table.Column<string>(nullable: true),
            //            TrackWidthMaxmm = table.Column<string>(nullable: true),
            //            TurningRadiusmm = table.Column<string>(nullable: true),
            //            Weightkg = table.Column<string>(nullable: true),
            //            TransmissionType = table.Column<string>(nullable: true),
            //            DiffLock = table.Column<string>(nullable: true),
            //            SpecificationID = table.Column<int>(nullable: true),
            //            BrandID = table.Column<int>(nullable: true),
            //            EntryTypeID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_TractorBase", x => x.TractorBaseId);
            //            table.ForeignKey(
            //                name: "FK_dbo.TractorBase_dbo.Brand_BrandID",
            //                column: x => x.BrandID,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.TractorBase_dbo.EntryType_EntryTypeID",
            //                column: x => x.EntryTypeID,
            //                principalTable: "EntryType",
            //                principalColumn: "EntryTypeID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.TractorBase_dbo.ListingFile_SpecificationID",
            //                column: x => x.SpecificationID,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "VehicleBase",
            //        columns: table => new
            //        {
            //            VehicleBaseId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: false),
            //            Range = table.Column<string>(nullable: true),
            //            Model = table.Column<string>(nullable: true),
            //            Segment = table.Column<string>(nullable: true),
            //            Doors = table.Column<string>(nullable: true),
            //            BodyShape = table.Column<string>(nullable: true),
            //            EngineSizeLitre = table.Column<string>(nullable: true),
            //            CylinderLayout = table.Column<string>(nullable: true),
            //            Cylinders = table.Column<string>(nullable: true),
            //            FuelType = table.Column<string>(nullable: true),
            //            PowerMaximumTotal = table.Column<string>(nullable: true),
            //            PowerPeakRevs = table.Column<string>(nullable: true),
            //            TorquePeakRevs = table.Column<string>(nullable: true),
            //            TorqueMaximumTotal = table.Column<string>(nullable: true),
            //            TorqueMaximumDetail = table.Column<string>(nullable: true),
            //            TorqueOverBoost = table.Column<string>(nullable: true),
            //            TorqueOverBoostPeakRevs = table.Column<string>(nullable: true),
            //            Acceleration0100kmh = table.Column<string>(nullable: true),
            //            MaximumTopSpeed = table.Column<string>(nullable: true),
            //            DrivenWheelsQuantity = table.Column<string>(nullable: true),
            //            GearRatiosQuantity = table.Column<string>(nullable: true),
            //            GearShift = table.Column<string>(nullable: true),
            //            TransmissionType = table.Column<string>(nullable: true),
            //            BrandID = table.Column<int>(nullable: true),
            //            EntryTypeID = table.Column<int>(nullable: false),
            //            SpecificationID = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_VehicleBase", x => x.VehicleBaseId);
            //            table.ForeignKey(
            //                name: "FK_dbo.VehicleBase_dbo.Brand_BrandID",
            //                column: x => x.BrandID,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.VehicleBase_dbo.EntryType_EntryTypeID",
            //                column: x => x.EntryTypeID,
            //                principalTable: "EntryType",
            //                principalColumn: "EntryTypeID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.VehicleBase_dbo.ListingFile_SpecificationID",
            //                column: x => x.SpecificationID,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "MunicipalDistrict",
            //        columns: table => new
            //        {
            //            MunicipalDistrictId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ProvinceId = table.Column<int>(nullable: false),
            //            Key = table.Column<string>(nullable: true),
            //            Name = table.Column<string>(nullable: true),
            //            Code = table.Column<string>(nullable: true),
            //            Latitude = table.Column<double>(nullable: true),
            //            Longitude = table.Column<double>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_MunicipalDistrict", x => x.MunicipalDistrictId);
            //            table.ForeignKey(
            //                name: "FK_dbo.MunicipalDistrict_dbo.Province_ProvinceId",
            //                column: x => x.ProvinceId,
            //                principalTable: "Province",
            //                principalColumn: "ProvinceId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Supplier",
            //        columns: table => new
            //        {
            //            SupplierId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            SupplierName = table.Column<string>(nullable: true),
            //            SupplierDesc = table.Column<string>(nullable: true),
            //            SupplierAddress1 = table.Column<string>(nullable: true),
            //            SupplierAddress2 = table.Column<string>(nullable: true),
            //            SupplierCity = table.Column<string>(nullable: true),
            //            ProvinceId = table.Column<int>(nullable: true),
            //            CountryId = table.Column<int>(nullable: true),
            //            SupplierPostCode = table.Column<string>(nullable: true),
            //            SupplierTel1 = table.Column<string>(nullable: true),
            //            SupplierTel2 = table.Column<string>(nullable: true),
            //            AccountNo = table.Column<string>(nullable: true),
            //            IsActive = table.Column<bool>(nullable: false),
            //            HasPaid = table.Column<bool>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Supplier", x => x.SupplierId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Supplier_dbo.Country_CountryId",
            //                column: x => x.CountryId,
            //                principalTable: "Country",
            //                principalColumn: "CountryId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Supplier_dbo.Province_ProvinceId",
            //                column: x => x.ProvinceId,
            //                principalTable: "Province",
            //                principalColumn: "ProvinceId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Town",
            //        columns: table => new
            //        {
            //            TownId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            TownName = table.Column<string>(nullable: true),
            //            TownCode = table.Column<string>(nullable: true),
            //            Province_ProvinceId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Town", x => x.TownId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Town_dbo.Province_ProvinceId_ProvinceId",
            //                column: x => x.Province_ProvinceId,
            //                principalTable: "Province",
            //                principalColumn: "ProvinceId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ProblemAttachment",
            //        columns: table => new
            //        {
            //            ProblemAttachmentId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ProblemBaseId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ProblemAttachment", x => x.ProblemAttachmentId);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProblemAttachment_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProblemAttachment_dbo.ProblemBase_ProblemBaseId",
            //                column: x => x.ProblemBaseId,
            //                principalTable: "ProblemBase",
            //                principalColumn: "ProblemBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ProblemImage",
            //        columns: table => new
            //        {
            //            ProblemImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ProblemBaseId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ProblemImage", x => x.ProblemImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProblemImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProblemImage_dbo.ProblemBase_ProblemBaseId",
            //                column: x => x.ProblemBaseId,
            //                principalTable: "ProblemBase",
            //                principalColumn: "ProblemBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Route",
            //        columns: table => new
            //        {
            //            RouteId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            SuperGroupId = table.Column<int>(nullable: false),
            //            GroupId = table.Column<int>(nullable: true),
            //            SubGroupId = table.Column<int>(nullable: true),
            //            SectionId = table.Column<int>(nullable: true),
            //            ViewCount = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
            //            ProblemBaseId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Route", x => x.RouteId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Route_dbo.Groups_GroupId",
            //                column: x => x.GroupId,
            //                principalTable: "Groups",
            //                principalColumn: "GroupId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Route_ProblemBase_dbo.ProblemBaseId",
            //                column: x => x.ProblemBaseId,
            //                principalTable: "ProblemBase",
            //                principalColumn: "ProblemBaseId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Route_dbo.Section_SectionId",
            //                column: x => x.SectionId,
            //                principalTable: "Section",
            //                principalColumn: "SectionId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Route_dbo.SubGroups_SubGroupId",
            //                column: x => x.SubGroupId,
            //                principalTable: "SubGroups",
            //                principalColumn: "SubGroupId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Route_dbo.SuperGroups_SuperGroupId",
            //                column: x => x.SuperGroupId,
            //                principalTable: "SuperGroups",
            //                principalColumn: "SuperGroupId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "NewsImage",
            //        columns: table => new
            //        {
            //            NewsImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            NewsId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_NewsImage", x => x.NewsImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.NewsImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.NewsImage_dbo.News_NewsId",
            //                column: x => x.NewsId,
            //                principalTable: "News",
            //                principalColumn: "NewsId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "CombineImage",
            //        columns: table => new
            //        {
            //            CombineImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            CombineBaseId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_CombineImage", x => x.CombineImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.CombineImage_dbo.CombineBase_CombineBaseId",
            //                column: x => x.CombineBaseId,
            //                principalTable: "CombineBase",
            //                principalColumn: "CombineBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.CombineImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EntryAttribute",
            //        columns: table => new
            //        {
            //            EntryAttributeID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            EntryID = table.Column<int>(nullable: false),
            //            AttributeID = table.Column<int>(nullable: false),
            //            Value = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EntryAttribute", x => x.EntryAttributeID);
            //            table.ForeignKey(
            //                name: "FK_dbo.EntryAttribute_dbo.Attribute_AttributeID",
            //                column: x => x.AttributeID,
            //                principalTable: "Attribute",
            //                principalColumn: "AttributeID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.EntryAttribute_dbo.Entry_EntryID",
            //                column: x => x.EntryID,
            //                principalTable: "Entry",
            //                principalColumn: "EntryID",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EntryImage",
            //        columns: table => new
            //        {
            //            EntryImageID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            EntryID = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EntryImage", x => x.EntryImageID);
            //            table.ForeignKey(
            //                name: "FK_dbo.EntryImage_dbo.Entry_EntryID",
            //                column: x => x.EntryID,
            //                principalTable: "Entry",
            //                principalColumn: "EntryID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.EntryImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EntryPDF",
            //        columns: table => new
            //        {
            //            EntryPDFID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            EntryID = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EntryPDF", x => x.EntryPDFID);
            //            table.ForeignKey(
            //                name: "FK_dbo.EntryPDF_dbo.Entry_EntryID",
            //                column: x => x.EntryID,
            //                principalTable: "Entry",
            //                principalColumn: "EntryID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.EntryPDF_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EquipmentImage",
            //        columns: table => new
            //        {
            //            EquipmentImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            EquipmentBaseId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EquipmentImage", x => x.EquipmentImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.EquipmentImage_dbo.EquipmentBase_EquipmentBaseId",
            //                column: x => x.EquipmentBaseId,
            //                principalTable: "EquipmentBase",
            //                principalColumn: "EquipmentBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.EquipmentImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EquipmentSpecification",
            //        columns: table => new
            //        {
            //            EquipmentSpecificationId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            EquipmentBase_EquipmentBaseId = table.Column<int>(nullable: false),
            //            Specification_SpecificationId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EquipmentSpecification", x => x.EquipmentSpecificationId);
            //            table.ForeignKey(
            //                name: "FK_dbo.EquipmentSpecification_dbo.EquipmentBase_EquipmentBase_EquipmentBaseId",
            //                column: x => x.EquipmentBase_EquipmentBaseId,
            //                principalTable: "EquipmentBase",
            //                principalColumn: "EquipmentBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.EquipmentSpecification_dbo.Specification_Specification_SpecificationId",
            //                column: x => x.Specification_SpecificationId,
            //                principalTable: "Specification",
            //                principalColumn: "SpecificationId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ProductActiveIngredient",
            //        columns: table => new
            //        {
            //            ProductActiveIngredientId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ProductBaseId = table.Column<int>(nullable: false),
            //            ActiveIngredientId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ProductActiveIngredient", x => x.ProductActiveIngredientId);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProductActiveIngredient_dbo.ActiveIngredient_ActiveIngredientId",
            //                column: x => x.ActiveIngredientId,
            //                principalTable: "ActiveIngredient",
            //                principalColumn: "ActiveIngredientId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProductActiveIngredient_dbo.ProductBase_ProductBaseId",
            //                column: x => x.ProductBaseId,
            //                principalTable: "ProductBase",
            //                principalColumn: "ProductBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ProductAttachment",
            //        columns: table => new
            //        {
            //            ProductAttachmentId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ProductBaseId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ProductAttachment", x => x.ProductAttachmentId);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProductAttachment_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProductAttachment_dbo.ProductBase_ProductBaseId",
            //                column: x => x.ProductBaseId,
            //                principalTable: "ProductBase",
            //                principalColumn: "ProductBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ProductBaseRemedyType",
            //        columns: table => new
            //        {
            //            ProductBaseRemedyTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ProductBaseId = table.Column<int>(nullable: false),
            //            RemedyTypeId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ProductBaseRemedyType", x => x.ProductBaseRemedyTypeId);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProductBaseRemedyType_dbo.ProductBase_ProductBaseId",
            //                column: x => x.ProductBaseId,
            //                principalTable: "ProductBase",
            //                principalColumn: "ProductBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProductBaseRemedyType_dbo.RemedyType_RemedyTypeId",
            //                column: x => x.RemedyTypeId,
            //                principalTable: "RemedyType",
            //                principalColumn: "RemedyTypeId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ProductImage",
            //        columns: table => new
            //        {
            //            ProductImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ProductBaseId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ProductImage", x => x.ProductImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProductImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProductImage_dbo.ProductBase_ProductBaseId",
            //                column: x => x.ProductBaseId,
            //                principalTable: "ProductBase",
            //                principalColumn: "ProductBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ProductSpecification",
            //        columns: table => new
            //        {
            //            ProductSpecificationId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ProductBaseId = table.Column<int>(nullable: false),
            //            Specification_SpecificationId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ProductSpecification", x => x.ProductSpecificationId);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProductSpecification_dbo.ProductBase_ProductBaseId",
            //                column: x => x.ProductBaseId,
            //                principalTable: "ProductBase",
            //                principalColumn: "ProductBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProductSpecification_dbo.Specification_Specification_SpecificationId",
            //                column: x => x.Specification_SpecificationId,
            //                principalTable: "Specification",
            //                principalColumn: "SpecificationId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "TractorImage",
            //        columns: table => new
            //        {
            //            TractorImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            TractorBaseId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_TractorImage", x => x.TractorImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.TractorImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.TractorImage_dbo.TractorBase_TractorBaseId",
            //                column: x => x.TractorBaseId,
            //                principalTable: "TractorBase",
            //                principalColumn: "TractorBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "VehicleImage",
            //        columns: table => new
            //        {
            //            VehicleImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            VehicleBaseId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_VehicleImage", x => x.VehicleImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.VehicleImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.VehicleImage_dbo.VehicleBase_VehicleBaseId",
            //                column: x => x.VehicleBaseId,
            //                principalTable: "VehicleBase",
            //                principalColumn: "VehicleBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Advertisement",
            //        columns: table => new
            //        {
            //            AdvertisementId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Code = table.Column<string>(nullable: true),
            //            StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //            EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //            TopLevelItem = table.Column<bool>(nullable: false),
            //            Active = table.Column<bool>(nullable: false),
            //            RankId = table.Column<int>(nullable: false),
            //            AdvertisementLink = table.Column<string>(nullable: true),
            //            SupplierId = table.Column<int>(nullable: true),
            //            BrandId = table.Column<int>(nullable: true),
            //            LoadCounter = table.Column<int>(nullable: false),
            //            ClickCounter = table.Column<int>(nullable: false),
            //            TotalLoadCounter = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
            //            Home = table.Column<bool>(nullable: false),
            //            SupplierBrandHome = table.Column<bool>(nullable: false),
            //            PhonePage = table.Column<bool>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Advertisement", x => x.AdvertisementId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Advertisement_dbo.Brand_BrandId",
            //                column: x => x.BrandId,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Advertisement_dbo.Supplier_SupplierId",
            //                column: x => x.SupplierId,
            //                principalTable: "Supplier",
            //                principalColumn: "SupplierId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "LinkRequest",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            SupplierId = table.Column<int>(nullable: true),
            //            BrandId = table.Column<int>(nullable: true),
            //            Requestor = table.Column<string>(nullable: true),
            //            RequestGuid = table.Column<Guid>(nullable: false),
            //            LinkRequestTypeId = table.Column<int>(nullable: false),
            //            Created = table.Column<DateTime>(type: "datetime", nullable: false),
            //            Edited = table.Column<DateTime>(type: "datetime", nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_LinkRequest", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.LinkRequest_dbo.Brand_BrandId",
            //                column: x => x.BrandId,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.LinkRequest_dbo.LinkRequestType_LinkRequestTypeId",
            //                column: x => x.LinkRequestTypeId,
            //                principalTable: "LinkRequestType",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.LinkRequest_dbo.Supplier_SupplierId",
            //                column: x => x.SupplierId,
            //                principalTable: "Supplier",
            //                principalColumn: "SupplierId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Representative",
            //        columns: table => new
            //        {
            //            RepresentativeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: false),
            //            Number = table.Column<string>(nullable: true),
            //            Website = table.Column<string>(nullable: true),
            //            Email = table.Column<string>(nullable: true),
            //            City = table.Column<string>(nullable: true),
            //            BrandId = table.Column<int>(nullable: true),
            //            SupplierId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Representative", x => x.RepresentativeId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Representative_dbo.Brand_BrandId",
            //                column: x => x.BrandId,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Representative_dbo.Supplier_SupplierId",
            //                column: x => x.SupplierId,
            //                principalTable: "Supplier",
            //                principalColumn: "SupplierId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "SupplierBrand",
            //        columns: table => new
            //        {
            //            SupplierBrandId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            BrandId = table.Column<int>(nullable: false),
            //            SupplierId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_SupplierBrand", x => x.SupplierBrandId);
            //            table.ForeignKey(
            //                name: "FK_dbo.SupplierBrand_dbo.Brand_BrandId",
            //                column: x => x.BrandId,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.SupplierBrand_dbo.Supplier_SupplierId",
            //                column: x => x.SupplierId,
            //                principalTable: "Supplier",
            //                principalColumn: "SupplierId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "SupplierBrand1",
            //        columns: table => new
            //        {
            //            Supplier_SupplierId = table.Column<int>(nullable: false),
            //            Brand_BrandId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_SupplierBrand1", x => new { x.Supplier_SupplierId, x.Brand_BrandId });
            //            table.ForeignKey(
            //                name: "FK_dbo.SupplierBrand1_dbo.Brand_Brand_BrandId",
            //                column: x => x.Brand_BrandId,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.SupplierBrand1_dbo.Supplier_Supplier_SupplierId",
            //                column: x => x.Supplier_SupplierId,
            //                principalTable: "Supplier",
            //                principalColumn: "SupplierId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "SupplierImage",
            //        columns: table => new
            //        {
            //            SupplierImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            SupplierId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_SupplierImage", x => x.SupplierImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.SupplierImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.SupplierImage_dbo.Supplier_SupplierId",
            //                column: x => x.SupplierId,
            //                principalTable: "Supplier",
            //                principalColumn: "SupplierId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "SupplierMunicipalDistrict",
            //        columns: table => new
            //        {
            //            SupplierMunicipalDistrictId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            SupplierId = table.Column<int>(nullable: false),
            //            MunicipalDistrictId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_SupplierMunicipalDistrict", x => x.SupplierMunicipalDistrictId);
            //            table.ForeignKey(
            //                name: "FK_dbo.SupplierMunicipalDistrict_dbo.MunicipalDistrict_MunicipalDistrictId",
            //                column: x => x.MunicipalDistrictId,
            //                principalTable: "MunicipalDistrict",
            //                principalColumn: "MunicipalDistrictId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.SupplierMunicipalDistrict_dbo.Supplier_SupplierId",
            //                column: x => x.SupplierId,
            //                principalTable: "Supplier",
            //                principalColumn: "SupplierId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Address",
            //        columns: table => new
            //        {
            //            AddressTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            PostalCountryId_CountryId = table.Column<int>(nullable: true),
            //            PostalProvinceId_ProvinceId = table.Column<int>(nullable: true),
            //            PostalTownId_TownId = table.Column<int>(nullable: true),
            //            CellNumber = table.Column<string>(nullable: true),
            //            PostalAddress = table.Column<string>(nullable: true),
            //            ResidentialAddress = table.Column<string>(nullable: true),
            //            UserId = table.Column<int>(nullable: false, defaultValueSql: "((0))")
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Address", x => x.AddressTypeId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Address_dbo.Country_PostalCountryId_CountryId",
            //                column: x => x.PostalCountryId_CountryId,
            //                principalTable: "Country",
            //                principalColumn: "CountryId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Address_dbo.Province_PostalProvinceId_ProvinceId",
            //                column: x => x.PostalProvinceId_ProvinceId,
            //                principalTable: "Province",
            //                principalColumn: "ProvinceId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Address_dbo.Town_PostalTownId_TownId",
            //                column: x => x.PostalTownId_TownId,
            //                principalTable: "Town",
            //                principalColumn: "TownId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Branch",
            //        columns: table => new
            //        {
            //            BranchId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            BranchName = table.Column<string>(nullable: true),
            //            ProvinceId = table.Column<int>(nullable: false),
            //            TownId = table.Column<int>(nullable: false),
            //            Suburb = table.Column<string>(nullable: true),
            //            Address_Line1 = table.Column<string>(nullable: true),
            //            Address_Line2 = table.Column<string>(nullable: true),
            //            PostalCode = table.Column<string>(nullable: true),
            //            ContactNumber = table.Column<string>(nullable: true),
            //            Website = table.Column<string>(nullable: true),
            //            Email = table.Column<string>(nullable: true),
            //            AgencyId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Branch", x => x.BranchId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Branch_dbo.Agency_AgencyId",
            //                column: x => x.AgencyId,
            //                principalTable: "Agency",
            //                principalColumn: "AgencyId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Branch_dbo.Province_ProvinceId",
            //                column: x => x.ProvinceId,
            //                principalTable: "Province",
            //                principalColumn: "ProvinceId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Branch_dbo.Town_TownId",
            //                column: x => x.TownId,
            //                principalTable: "Town",
            //                principalColumn: "TownId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EntityAddress",
            //        columns: table => new
            //        {
            //            AddressTypeId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            CellNumber = table.Column<string>(nullable: true),
            //            PostalAddress = table.Column<string>(nullable: true),
            //            ResidentialAddress = table.Column<string>(nullable: true),
            //            PostalCountryId_CountryId = table.Column<int>(nullable: true),
            //            PostalProvinceId_ProvinceId = table.Column<int>(nullable: true),
            //            PostalTownId_TownId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EntityAddress", x => x.AddressTypeId);
            //            table.ForeignKey(
            //                name: "FK_dbo.EntityAddress_dbo.Country_PostalCountryId_CountryId",
            //                column: x => x.PostalCountryId_CountryId,
            //                principalTable: "Country",
            //                principalColumn: "CountryId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.EntityAddress_dbo.Province_PostalProvinceId_ProvinceId",
            //                column: x => x.PostalProvinceId_ProvinceId,
            //                principalTable: "Province",
            //                principalColumn: "ProvinceId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.EntityAddress_dbo.Town_PostalTownId_TownId",
            //                column: x => x.PostalTownId_TownId,
            //                principalTable: "Town",
            //                principalColumn: "TownId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "SupplierTown",
            //        columns: table => new
            //        {
            //            SupplierTownId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            SupplierId = table.Column<int>(nullable: false),
            //            TownId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_SupplierTown", x => x.SupplierTownId);
            //            table.ForeignKey(
            //                name: "FK_dbo.SupplierTown_dbo.Supplier_SupplierId",
            //                column: x => x.SupplierId,
            //                principalTable: "Supplier",
            //                principalColumn: "SupplierId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.SupplierTown_dbo.Town_TownId",
            //                column: x => x.TownId,
            //                principalTable: "Town",
            //                principalColumn: "TownId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "BusinessEntity",
            //        columns: table => new
            //        {
            //            BusinessEntityId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            BusinessEntityBaseId = table.Column<int>(nullable: false),
            //            RouteId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_BusinessEntity", x => x.BusinessEntityId);
            //            table.ForeignKey(
            //                name: "FK_dbo.BusinessEntity_dbo.BusinessEntityBase_BusinessEntityBaseId",
            //                column: x => x.BusinessEntityBaseId,
            //                principalTable: "BusinessEntityBase",
            //                principalColumn: "BusinessEntityBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.BusinessEntity_dbo.Route_RouteId",
            //                column: x => x.RouteId,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Combine",
            //        columns: table => new
            //        {
            //            CombineId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            CombineBaseId = table.Column<int>(nullable: false),
            //            RouteId = table.Column<int>(nullable: false),
            //            MenuTypeID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Combine", x => x.CombineId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Combine_dbo.CombineBase_CombineBaseId",
            //                column: x => x.CombineBaseId,
            //                principalTable: "CombineBase",
            //                principalColumn: "CombineBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Combine_dbo.MenuType_MenuTypeID",
            //                column: x => x.MenuTypeID,
            //                principalTable: "MenuType",
            //                principalColumn: "MenuTypeID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Combine_dbo.Route_RouteId",
            //                column: x => x.RouteId,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EntryHeader",
            //        columns: table => new
            //        {
            //            EntryHeaderID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            EntryID = table.Column<int>(nullable: false),
            //            RouteID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EntryHeader", x => x.EntryHeaderID);
            //            table.ForeignKey(
            //                name: "FK_dbo.EntryHeader_dbo.Entry_EntryID",
            //                column: x => x.EntryID,
            //                principalTable: "Entry",
            //                principalColumn: "EntryID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.EntryHeader_dbo.Route_RouteID",
            //                column: x => x.RouteID,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Equipment",
            //        columns: table => new
            //        {
            //            EquipmentId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            EquipmentBaseId = table.Column<int>(nullable: false),
            //            RouteId = table.Column<int>(nullable: false),
            //            MenuTypeID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Equipment", x => x.EquipmentId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Equipment_dbo.EquipmentBase_EquipmentBaseId",
            //                column: x => x.EquipmentBaseId,
            //                principalTable: "EquipmentBase",
            //                principalColumn: "EquipmentBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Equipment_dbo.MenuType_MenuTypeID",
            //                column: x => x.MenuTypeID,
            //                principalTable: "MenuType",
            //                principalColumn: "MenuTypeID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Equipment_dbo.Route_RouteId",
            //                column: x => x.RouteId,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Farm",
            //        columns: table => new
            //        {
            //            FarmID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            FarmName = table.Column<string>(nullable: true),
            //            Muncipality = table.Column<string>(nullable: true),
            //            PropertySize = table.Column<string>(nullable: true),
            //            FarmNumber = table.Column<int>(nullable: false),
            //            Latitude = table.Column<string>(nullable: true),
            //            Longitude = table.Column<string>(nullable: true),
            //            NearestTown = table.Column<string>(nullable: true),
            //            Description = table.Column<string>(nullable: true),
            //            AddPrimary = table.Column<int>(nullable: false),
            //            PrimaryBedrooms = table.Column<int>(nullable: false),
            //            PrimaryBathrooms = table.Column<int>(nullable: false),
            //            PrimaryInfo = table.Column<string>(nullable: true),
            //            AddSecondary = table.Column<int>(nullable: false),
            //            SecondaryBedrooms = table.Column<int>(nullable: false),
            //            SecondaryBathrooms = table.Column<int>(nullable: false),
            //            SecondaryInfo = table.Column<string>(nullable: true),
            //            AddWorkers = table.Column<int>(nullable: false),
            //            WorkersBedrooms = table.Column<int>(nullable: false),
            //            WorkersBathrooms = table.Column<int>(nullable: false),
            //            WorkersInfo = table.Column<string>(nullable: true),
            //            FarmImageID = table.Column<int>(nullable: false),
            //            WaterRightsID = table.Column<int>(nullable: false),
            //            InfrastructureID = table.Column<int>(nullable: false),
            //            UserId = table.Column<int>(nullable: false),
            //            PriceIncVAT = table.Column<double>(nullable: false),
            //            PriceExclVAT = table.Column<double>(nullable: false),
            //            Route_RouteId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Farm", x => x.FarmID);
            //            table.ForeignKey(
            //                name: "FK_dbo.Farm_dbo.Infrastructure_InfrastructureID",
            //                column: x => x.InfrastructureID,
            //                principalTable: "Infrastructure",
            //                principalColumn: "InfrastructureID",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Farm_dbo.Route_Route_RouteId",
            //                column: x => x.Route_RouteId,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Farm_dbo.WaterRights_WaterRightsID",
            //                column: x => x.WaterRightsID,
            //                principalTable: "WaterRights",
            //                principalColumn: "ID",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "MarketRoute",
            //        columns: table => new
            //        {
            //            MarketRouteId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            MarketId = table.Column<int>(nullable: false),
            //            RouteId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_MarketRoute", x => x.MarketRouteId);
            //            table.ForeignKey(
            //                name: "FK_dbo.MarketRoute_dbo.Market_MarketId",
            //                column: x => x.MarketId,
            //                principalTable: "Market",
            //                principalColumn: "MarketId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.MarketRoute_dbo.Route_RouteId",
            //                column: x => x.RouteId,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Problem",
            //        columns: table => new
            //        {
            //            ProblemId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ProblemBaseId = table.Column<int>(nullable: false),
            //            MenuTypeID = table.Column<int>(nullable: false),
            //            RouteId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Problem", x => x.ProblemId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Problem_dbo.MenuType_MenuTypeID",
            //                column: x => x.MenuTypeID,
            //                principalTable: "MenuType",
            //                principalColumn: "MenuTypeID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Problem_dbo.ProblemBase_ProblemBaseId",
            //                column: x => x.ProblemBaseId,
            //                principalTable: "ProblemBase",
            //                principalColumn: "ProblemBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Problem_dbo.Route_RouteId",
            //                column: x => x.RouteId,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Product",
            //        columns: table => new
            //        {
            //            ProductId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ProductBaseId = table.Column<int>(nullable: false),
            //            RouteId = table.Column<int>(nullable: false),
            //            MenuTypeID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Product", x => x.ProductId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Product_dbo.MenuType_MenuTypeID",
            //                column: x => x.MenuTypeID,
            //                principalTable: "MenuType",
            //                principalColumn: "MenuTypeID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Product_dbo.ProductBase_ProductBaseId",
            //                column: x => x.ProductBaseId,
            //                principalTable: "ProductBase",
            //                principalColumn: "ProductBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Product_dbo.Route_RouteId",
            //                column: x => x.RouteId,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "SupplierProduct",
            //        columns: table => new
            //        {
            //            SupplierProductId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ProductBaseId = table.Column<int>(nullable: true),
            //            EntryId = table.Column<int>(nullable: true),
            //            SupplierId = table.Column<int>(nullable: false),
            //            BrandId = table.Column<int>(nullable: false),
            //            Name = table.Column<string>(nullable: true),
            //            Display = table.Column<bool>(nullable: false),
            //            Route_RouteId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_SupplierProduct", x => x.SupplierProductId);
            //            table.ForeignKey(
            //                name: "FK_dbo.SupplierProduct_dbo.Entry_EntryId",
            //                column: x => x.EntryId,
            //                principalTable: "Entry",
            //                principalColumn: "EntryID",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.SupplierProduct_dbo.ProductBase_ProductBaseId",
            //                column: x => x.ProductBaseId,
            //                principalTable: "ProductBase",
            //                principalColumn: "ProductBaseId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.SupplierProduct_dbo.Route_Route_RouteId",
            //                column: x => x.Route_RouteId,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Tractor",
            //        columns: table => new
            //        {
            //            TractorId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            TractorBaseId = table.Column<int>(nullable: false),
            //            RouteId = table.Column<int>(nullable: false),
            //            MenuTypeID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Tractor", x => x.TractorId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Tractor_dbo.MenuType_MenuTypeID",
            //                column: x => x.MenuTypeID,
            //                principalTable: "MenuType",
            //                principalColumn: "MenuTypeID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Tractor_dbo.Route_RouteId",
            //                column: x => x.RouteId,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Tractor_dbo.TractorBase_TractorBaseId",
            //                column: x => x.TractorBaseId,
            //                principalTable: "TractorBase",
            //                principalColumn: "TractorBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Vehicle",
            //        columns: table => new
            //        {
            //            VehicleId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            VehicleBaseId = table.Column<int>(nullable: false),
            //            RouteId = table.Column<int>(nullable: false),
            //            MenuTypeID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Vehicle_dbo.MenuType_MenuTypeID",
            //                column: x => x.MenuTypeID,
            //                principalTable: "MenuType",
            //                principalColumn: "MenuTypeID",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Vehicle_dbo.Route_RouteId",
            //                column: x => x.RouteId,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Vehicle_dbo.VehicleBase_VehicleBaseId",
            //                column: x => x.VehicleBaseId,
            //                principalTable: "VehicleBase",
            //                principalColumn: "VehicleBaseId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "AdvertisementImage",
            //        columns: table => new
            //        {
            //            AdvertisementImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            AdvertisementId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_AdvertisementImage", x => x.AdvertisementImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.AdvertisementImage_dbo.Advertisement_AdvertisementId",
            //                column: x => x.AdvertisementId,
            //                principalTable: "Advertisement",
            //                principalColumn: "AdvertisementId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.AdvertisementImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "AdvertisementRoute",
            //        columns: table => new
            //        {
            //            AdvertisementRouteId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            AdvertisementId = table.Column<int>(nullable: false),
            //            RouteId = table.Column<int>(nullable: false),
            //            loadCounter = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_AdvertisementRoute", x => x.AdvertisementRouteId);
            //            table.ForeignKey(
            //                name: "FK_dbo.AdvertisementRoute_dbo.Advertisement_AdvertisementId",
            //                column: x => x.AdvertisementId,
            //                principalTable: "Advertisement",
            //                principalColumn: "AdvertisementId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.AdvertisementRoute_dbo.Route_RouteId",
            //                column: x => x.RouteId,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "RepresentativeImage",
            //        columns: table => new
            //        {
            //            RepresentativeImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            RepresentativeId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_RepresentativeImage", x => x.RepresentativeImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.RepresentativeImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.RepresentativeImage_dbo.Representative_RepresentativeId",
            //                column: x => x.RepresentativeId,
            //                principalTable: "Representative",
            //                principalColumn: "RepresentativeId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "RepresentativeProvince",
            //        columns: table => new
            //        {
            //            RepresentativeProvinceId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            RepresentativeId = table.Column<int>(nullable: false),
            //            ProvinceId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_RepresentativeProvince", x => x.RepresentativeProvinceId);
            //            table.ForeignKey(
            //                name: "FK_dbo.RepresentativeProvince_dbo.Province_ProvinceId",
            //                column: x => x.ProvinceId,
            //                principalTable: "Province",
            //                principalColumn: "ProvinceId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.RepresentativeProvince_dbo.Representative_RepresentativeId",
            //                column: x => x.RepresentativeId,
            //                principalTable: "Representative",
            //                principalColumn: "RepresentativeId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "UserProfile",
            //        columns: table => new
            //        {
            //            UserId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            UserTypeName = table.Column<string>(nullable: true),
            //            Email = table.Column<string>(nullable: true),
            //            UserName = table.Column<string>(nullable: true),
            //            IsAdministrator = table.Column<bool>(nullable: false),
            //            FirstName = table.Column<string>(nullable: true),
            //            LastName = table.Column<string>(nullable: true),
            //            TermsAndConditions = table.Column<bool>(nullable: false),
            //            UserType_UserTypeId = table.Column<int>(nullable: true),
            //            IsSubUser = table.Column<bool>(nullable: false),
            //            ParentUser_UserId = table.Column<int>(nullable: true),
            //            AddressId_AddressTypeId = table.Column<int>(nullable: true),
            //            SouthAfricanIdNumber = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_UserProfile", x => x.UserId);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserProfile_dbo.Address_AddressId_AddressTypeId",
            //                column: x => x.AddressId_AddressTypeId,
            //                principalTable: "Address",
            //                principalColumn: "AddressTypeId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserProfile_dbo.UserProfile_ParentUser_UserId",
            //                column: x => x.ParentUser_UserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserProfile_dbo.UserType_UserTypeId_UserTypeId",
            //                column: x => x.UserType_UserTypeId,
            //                principalTable: "UserType",
            //                principalColumn: "UserTypeId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Entity",
            //        columns: table => new
            //        {
            //            EntityId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            CompanyName = table.Column<string>(nullable: true),
            //            Email = table.Column<string>(nullable: true),
            //            CompanyRegistrationId = table.Column<string>(nullable: true),
            //            SARSnumber = table.Column<string>(nullable: true),
            //            VATnumber = table.Column<string>(nullable: true),
            //            CompanyTypeId_CompanyTypeId = table.Column<int>(nullable: true),
            //            EntityAddress_AddressTypeId = table.Column<int>(nullable: true),
            //            UserTypeId_UserTypeId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Entity", x => x.EntityId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Entity_dbo.CompanyType_CompanyTypeId_CompanyTypeId",
            //                column: x => x.CompanyTypeId_CompanyTypeId,
            //                principalTable: "CompanyType",
            //                principalColumn: "CompanyTypeId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Entity_dbo.EntityAddress_EntityAddress_AddressTypeId",
            //                column: x => x.EntityAddress_AddressTypeId,
            //                principalTable: "EntityAddress",
            //                principalColumn: "AddressTypeId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Entity_dbo.UserType_UserTypeId_UserTypeId",
            //                column: x => x.UserTypeId_UserTypeId,
            //                principalTable: "UserType",
            //                principalColumn: "UserTypeId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "BusinessEntityTypeAssignment",
            //        columns: table => new
            //        {
            //            BusinessEntityTypeAssignmentId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            BusinessEntityId = table.Column<int>(nullable: false),
            //            BusinessEntityTypeId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_BusinessEntityTypeAssignment", x => x.BusinessEntityTypeAssignmentId);
            //            table.ForeignKey(
            //                name: "FK_dbo.BusinessEntityTypeAssignment_dbo.BusinessEntity_BusinessEntityId",
            //                column: x => x.BusinessEntityId,
            //                principalTable: "BusinessEntity",
            //                principalColumn: "BusinessEntityId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.BusinessEntityTypeAssignment_dbo.BusinessEntityType_BusinessEntityTypeId",
            //                column: x => x.BusinessEntityTypeId,
            //                principalTable: "BusinessEntityType",
            //                principalColumn: "BusinessEntityTypeId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ProblemSymptom",
            //        columns: table => new
            //        {
            //            ProblemSymptomId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Problem_ProblemId = table.Column<int>(nullable: false),
            //            Symptom_SymptomId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ProblemSymptom", x => x.ProblemSymptomId);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProblemSymptom_dbo.Problem_Problem_ProblemId",
            //                column: x => x.Problem_ProblemId,
            //                principalTable: "Problem",
            //                principalColumn: "ProblemId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.ProblemSymptom_dbo.Symptom_Symptom_SymptomId",
            //                column: x => x.Symptom_SymptomId,
            //                principalTable: "Symptom",
            //                principalColumn: "SymptomId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Remedy",
            //        columns: table => new
            //        {
            //            RemedyId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ProblemId = table.Column<int>(nullable: false),
            //            ProductBaseId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Remedy", x => x.RemedyId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Remedy_dbo.Problem_ProblemId",
            //                column: x => x.ProblemId,
            //                principalTable: "Problem",
            //                principalColumn: "ProblemId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Remedy_dbo.ProductBase_ProductBaseId",
            //                column: x => x.ProductBaseId,
            //                principalTable: "ProductBase",
            //                principalColumn: "ProductBaseId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Auctions",
            //        columns: table => new
            //        {
            //            AuctionId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            AuctionTitle = table.Column<string>(nullable: true),
            //            ProvinceId = table.Column<int>(nullable: false),
            //            TownId = table.Column<int>(nullable: false),
            //            AuctionCategoryId = table.Column<int>(nullable: false),
            //            AuctionDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //            UserId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Auctions", x => x.AuctionId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Auctions_dbo.AuctionCategory_AuctionCategoryId",
            //                column: x => x.AuctionCategoryId,
            //                principalTable: "AuctionCategory",
            //                principalColumn: "AuctionCategoryId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Auctions_dbo.Province_ProvinceId",
            //                column: x => x.ProvinceId,
            //                principalTable: "Province",
            //                principalColumn: "ProvinceId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Auctions_dbo.Town_TownId",
            //                column: x => x.TownId,
            //                principalTable: "Town",
            //                principalColumn: "TownId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Auctions_dbo.UserProfile_UserId",
            //                column: x => x.UserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ChatGroup",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(nullable: true),
            //            CreatedUserId = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
            //            RouteId = table.Column<int>(nullable: false, defaultValueSql: "((0))")
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ChatGroup", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.ChatGroup_dbo.UserProfile_CreatedUserId",
            //                column: x => x.CreatedUserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.ChatGroup_dbo.Route_RouteId",
            //                column: x => x.RouteId,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ClassifiedAd",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Title = table.Column<string>(nullable: false),
            //            Desc = table.Column<string>(nullable: false),
            //            Price = table.Column<double>(nullable: false),
            //            Date = table.Column<DateTime>(type: "datetime", nullable: false),
            //            ClassifiedAdCategory_Id = table.Column<int>(nullable: false),
            //            ClassifiedAdRegion_Id = table.Column<int>(nullable: false),
            //            User_UserId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ClassifiedAd", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.ClassifiedAd_dbo.ClassifiedsCategories_ClassifiedAdCategory_Id",
            //                column: x => x.ClassifiedAdCategory_Id,
            //                principalTable: "ClassifiedsCategories",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.ClassifiedAd_dbo.ClassifiedAdRegion_ClassifiedAdRegion_Id",
            //                column: x => x.ClassifiedAdRegion_Id,
            //                principalTable: "ClassifiedAdRegion",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.ClassifiedAd_dbo.UserProfile_User_UserId",
            //                column: x => x.User_UserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Manager",
            //        columns: table => new
            //        {
            //            ManagerID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            SupplierId = table.Column<int>(nullable: true),
            //            UserId = table.Column<int>(nullable: true),
            //            BrandId = table.Column<int>(nullable: true),
            //            isActive = table.Column<bool>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Manager", x => x.ManagerID);
            //            table.ForeignKey(
            //                name: "FK_dbo.Manager_dbo.Brand_BrandId",
            //                column: x => x.BrandId,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Manager_dbo.Supplier_SupplierId",
            //                column: x => x.SupplierId,
            //                principalTable: "Supplier",
            //                principalColumn: "SupplierId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Manager_dbo.UserProfile_UserId",
            //                column: x => x.UserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Message",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Date = table.Column<DateTime>(type: "datetime", nullable: false),
            //            Subject = table.Column<string>(nullable: false),
            //            Content = table.Column<string>(nullable: false),
            //            Status = table.Column<int>(nullable: false),
            //            IsSystem = table.Column<bool>(nullable: false),
            //            SenderDeleted = table.Column<bool>(nullable: false),
            //            RecipientDeleted = table.Column<bool>(nullable: false),
            //            IsInfoMessage = table.Column<bool>(nullable: false),
            //            Image_MessageImageId = table.Column<int>(nullable: true),
            //            Recipient_UserId = table.Column<int>(nullable: false),
            //            Sender_UserId = table.Column<int>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Message", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.Message_dbo.MessageImage_Image_MessageImageId",
            //                column: x => x.Image_MessageImageId,
            //                principalTable: "MessageImage",
            //                principalColumn: "MessageImageId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.Message_dbo.UserProfile_Recipient_UserId",
            //                column: x => x.Recipient_UserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.Message_dbo.UserProfile_Sender_UserId",
            //                column: x => x.Sender_UserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "PropertyListing",
            //        columns: table => new
            //        {
            //            PropertyId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Title = table.Column<string>(nullable: true),
            //            Desc = table.Column<string>(nullable: true),
            //            ProvinceId = table.Column<int>(nullable: false),
            //            TownId = table.Column<int>(nullable: false),
            //            Suburb = table.Column<string>(nullable: true),
            //            Address_Line_1 = table.Column<string>(nullable: true),
            //            Address_Line_2 = table.Column<string>(nullable: true),
            //            PostalCode = table.Column<int>(nullable: false),
            //            ListingType = table.Column<string>(nullable: true),
            //            ListingPrice = table.Column<int>(nullable: false),
            //            StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //            EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //            UserId = table.Column<int>(nullable: false),
            //            PropertyCategory_Id = table.Column<int>(nullable: false),
            //            noOfBedrooms = table.Column<int>(nullable: false),
            //            noOfBathrooms = table.Column<int>(nullable: false),
            //            noOfGarages = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_PropertyListing", x => x.PropertyId);
            //            table.ForeignKey(
            //                name: "FK_dbo.PropertyListing_dbo.PropertyCategory_PropertyCategory_Id",
            //                column: x => x.PropertyCategory_Id,
            //                principalTable: "PropertyCategory",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.PropertyListing_dbo.UserProfile_UserId",
            //                column: x => x.UserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "TraderProfileSnapshot",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Email = table.Column<string>(nullable: true),
            //            IdNumber = table.Column<string>(nullable: true),
            //            AccountNumber = table.Column<string>(nullable: true),
            //            UserId = table.Column<int>(nullable: false),
            //            BankId = table.Column<int>(nullable: false),
            //            BankAccountTypeId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_TraderProfileSnapshot", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.TraderProfileSnapshot_dbo.BankAccountType_BankAccountTypeId",
            //                column: x => x.BankAccountTypeId,
            //                principalTable: "BankAccountType",
            //                principalColumn: "BankAccountTypeId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.TraderProfileSnapshot_dbo.Bank_BankId",
            //                column: x => x.BankId,
            //                principalTable: "Bank",
            //                principalColumn: "BankId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.TraderProfileSnapshot_dbo.UserProfile_UserId",
            //                column: x => x.UserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "UserBankAccount",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            AccountNumber = table.Column<string>(nullable: true),
            //            UserId = table.Column<int>(nullable: false),
            //            BankId = table.Column<int>(nullable: false),
            //            BankAccountTypeId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_UserBankAccount", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserBankAccount_dbo.BankAccountType_BankAccountTypeId",
            //                column: x => x.BankAccountTypeId,
            //                principalTable: "BankAccountType",
            //                principalColumn: "BankAccountTypeId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserBankAccount_dbo.Bank_BankId",
            //                column: x => x.BankId,
            //                principalTable: "Bank",
            //                principalColumn: "BankId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserBankAccount_dbo.UserProfile_UserId",
            //                column: x => x.UserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "UserImage",
            //        columns: table => new
            //        {
            //            UserImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            UserId = table.Column<int>(nullable: false),
            //            ListingFileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_UserImage", x => x.UserImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserImage_dbo.UserProfile_UserId",
            //                column: x => x.UserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "UserIndustries",
            //        columns: table => new
            //        {
            //            uiId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Active = table.Column<bool>(nullable: false),
            //            Answered = table.Column<bool>(nullable: false),
            //            Industry_GroupId = table.Column<int>(nullable: true),
            //            User_UserId = table.Column<int>(nullable: true),
            //            GetInfo = table.Column<bool>(nullable: false),
            //            ClickCounter = table.Column<int>(nullable: false, defaultValueSql: "((0))")
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_UserIndustries", x => x.uiId);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserIndustries_dbo.Groups_Industry_GroupId",
            //                column: x => x.Industry_GroupId,
            //                principalTable: "Groups",
            //                principalColumn: "GroupId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserIndustries_dbo.UserProfile_User_UserId",
            //                column: x => x.User_UserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "UserProfileChatMessage",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ChatMessageId = table.Column<int>(nullable: false),
            //            SenderId = table.Column<int>(nullable: false),
            //            ReceiverId = table.Column<int>(nullable: false),
            //            SenderClearedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //            ReceiverClearedDate = table.Column<DateTime>(type: "datetime", nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_UserProfileChatMessage", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserProfileChatMessage_dbo.ChatMessage_ChatMessageId",
            //                column: x => x.ChatMessageId,
            //                principalTable: "ChatMessage",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserProfileChatMessage_dbo.UserProfile_ReceiverId",
            //                column: x => x.ReceiverId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserProfileChatMessage_dbo.UserProfile_SenderId",
            //                column: x => x.SenderId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "UserRoute",
            //        columns: table => new
            //        {
            //            UserRouteId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            UserId = table.Column<int>(nullable: false),
            //            RouteId = table.Column<int>(nullable: false),
            //            ViewCount = table.Column<int>(nullable: false, defaultValueSql: "((0))")
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_UserRoute", x => x.UserRouteId);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserRoute_dbo.Route_RouteId",
            //                column: x => x.RouteId,
            //                principalTable: "Route",
            //                principalColumn: "RouteId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserRoute_dbo.UserProfile_UserId",
            //                column: x => x.UserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "webpages_OAuthMembership",
            //        columns: table => new
            //        {
            //            Provider = table.Column<string>(maxLength: 30, nullable: false),
            //            ProviderUserId = table.Column<string>(maxLength: 100, nullable: false),
            //            UserId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_webpages_OAuthMembership", x => new { x.Provider, x.ProviderUserId });
            //            table.ForeignKey(
            //                name: "FK_webpages_OAuthMembership_UserProfile",
            //                column: x => x.UserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.webpages_OAuthMembership_dbo.webpages_Membership_UserId",
            //                column: x => x.UserId,
            //                principalTable: "webpages_Membership",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "AuctionItems",
            //        columns: table => new
            //        {
            //            AuctionItemId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ItemName = table.Column<string>(nullable: true),
            //            AuctionId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_AuctionItems", x => x.AuctionItemId);
            //            table.ForeignKey(
            //                name: "FK_dbo.AuctionItems_dbo.Auctions_AuctionId",
            //                column: x => x.AuctionId,
            //                principalTable: "Auctions",
            //                principalColumn: "AuctionId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "ChatGroupUserBan",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ChatGroupId = table.Column<int>(nullable: false),
            //            UserProfileId = table.Column<int>(nullable: false),
            //            CreatedUserId = table.Column<int>(nullable: false),
            //            CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_ChatGroupUserBan", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.ChatGroupUserBan_dbo.ChatGroup_ChatGroupId",
            //                column: x => x.ChatGroupId,
            //                principalTable: "ChatGroup",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.ChatGroupUserBan_dbo.UserProfile_CreatedUserId",
            //                column: x => x.CreatedUserId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.ChatGroupUserBan_dbo.UserProfile_UserProfileId",
            //                column: x => x.UserProfileId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "GroupChatMessage",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            SenderId = table.Column<int>(nullable: false),
            //            ChatMessageId = table.Column<int>(nullable: false),
            //            ChatGroupId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_GroupChatMessage", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.GroupChatMessage_dbo.ChatGroup_ChatGroupId",
            //                column: x => x.ChatGroupId,
            //                principalTable: "ChatGroup",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.GroupChatMessage_dbo.ChatMessage_ChatMessageId",
            //                column: x => x.ChatMessageId,
            //                principalTable: "ChatMessage",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.GroupChatMessage_dbo.UserProfile_SenderId",
            //                column: x => x.SenderId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Image",
            //        columns: table => new
            //        {
            //            ImageId = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ImagePath = table.Column<string>(nullable: true),
            //            ImageDescription = table.Column<string>(nullable: true),
            //            ClassifiedAdId = table.Column<int>(nullable: false),
            //            AdvertisementId = table.Column<int>(nullable: false),
            //            OriginalFilename = table.Column<string>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Image", x => x.ImageId);
            //            table.ForeignKey(
            //                name: "FK_dbo.Image_dbo.ClassifiedAd_ClassifiedAdId",
            //                column: x => x.ClassifiedAdId,
            //                principalTable: "ClassifiedAd",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "TradeAd",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Headline = table.Column<string>(nullable: true),
            //            Description = table.Column<string>(nullable: true),
            //            AdditionalInformation = table.Column<string>(nullable: true),
            //            Price = table.Column<double>(nullable: false),
            //            PriceIncludesVat = table.Column<bool>(nullable: false),
            //            Created = table.Column<DateTime>(type: "datetime", nullable: false),
            //            Slug = table.Column<string>(nullable: true),
            //            Status = table.Column<int>(nullable: false),
            //            AcceptTradeSafe = table.Column<bool>(nullable: false),
            //            FeeAllocation = table.Column<int>(nullable: true),
            //            SellerId = table.Column<int>(nullable: false),
            //            ProvinceId = table.Column<int>(nullable: false),
            //            TownId = table.Column<int>(nullable: false),
            //            SuperGroupId = table.Column<int>(nullable: false),
            //            GroupId = table.Column<int>(nullable: false),
            //            SubGroupId = table.Column<int>(nullable: true),
            //            CompletionDays = table.Column<int>(nullable: false, defaultValueSql: "((0))")
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_TradeAd", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.TradeAd_dbo.Groups_GroupId",
            //                column: x => x.GroupId,
            //                principalTable: "Groups",
            //                principalColumn: "GroupId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.TradeAd_dbo.Province_ProvinceId",
            //                column: x => x.ProvinceId,
            //                principalTable: "Province",
            //                principalColumn: "ProvinceId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.TradeAd_dbo.TraderProfileSnapshot_SellerId",
            //                column: x => x.SellerId,
            //                principalTable: "TraderProfileSnapshot",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.TradeAd_dbo.SubGroups_SubGroupId",
            //                column: x => x.SubGroupId,
            //                principalTable: "SubGroups",
            //                principalColumn: "SubGroupId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.TradeAd_dbo.SuperGroups_SuperGroupId",
            //                column: x => x.SuperGroupId,
            //                principalTable: "SuperGroups",
            //                principalColumn: "SuperGroupId",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.TradeAd_dbo.Town_TownId",
            //                column: x => x.TownId,
            //                principalTable: "Town",
            //                principalColumn: "TownId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "CropTradeAd",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            CropType = table.Column<string>(nullable: true),
            //            Grade = table.Column<string>(nullable: true),
            //            Packaging = table.Column<string>(nullable: true),
            //            Quantity = table.Column<int>(nullable: false),
            //            TradeAdId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_CropTradeAd", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.CropTradeAd_dbo.TradeAd_TradeAdId",
            //                column: x => x.TradeAdId,
            //                principalTable: "TradeAd",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "EquipmentTradeAd",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Model = table.Column<string>(nullable: true),
            //            Brand = table.Column<string>(nullable: true),
            //            YearModel = table.Column<int>(nullable: false),
            //            Hours = table.Column<int>(nullable: false),
            //            Kilowatt = table.Column<int>(nullable: false),
            //            Condition = table.Column<string>(nullable: true),
            //            TradeAdId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_EquipmentTradeAd", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.EquipmentTradeAd_dbo.TradeAd_TradeAdId",
            //                column: x => x.TradeAdId,
            //                principalTable: "TradeAd",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "GameAndLivestockTradeAd",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            AnimalType = table.Column<string>(nullable: true),
            //            Breed = table.Column<string>(nullable: true),
            //            Quantity = table.Column<int>(nullable: false),
            //            TradeAdId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_GameAndLivestockTradeAd", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.GameAndLivestockTradeAd_dbo.TradeAd_TradeAdId",
            //                column: x => x.TradeAdId,
            //                principalTable: "TradeAd",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "InfrastructureTradeAd",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ProductName = table.Column<string>(nullable: true),
            //            Brand = table.Column<string>(nullable: true),
            //            TradeAdId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_InfrastructureTradeAd", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.InfrastructureTradeAd_dbo.TradeAd_TradeAdId",
            //                column: x => x.TradeAdId,
            //                principalTable: "TradeAd",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "TradeAdContactLog",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            TradeAdId = table.Column<int>(nullable: false),
            //            UserProfileId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_TradeAdContactLog", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.TradeAdContactLog_dbo.TradeAd_TradeAdId",
            //                column: x => x.TradeAdId,
            //                principalTable: "TradeAd",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.TradeAdContactLog_dbo.UserProfile_UserProfileId",
            //                column: x => x.UserProfileId,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "TradeAdImage",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            ListingFileId = table.Column<int>(nullable: false),
            //            TradeAdId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_TradeAdImage", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.TradeAdImage_dbo.ListingFile_ListingFileId",
            //                column: x => x.ListingFileId,
            //                principalTable: "ListingFile",
            //                principalColumn: "ListingFileId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.TradeAdImage_dbo.TradeAd_TradeAdId",
            //                column: x => x.TradeAdId,
            //                principalTable: "TradeAd",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "TradeAdTransaction",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            TradeSafeId = table.Column<string>(nullable: true),
            //            Step = table.Column<string>(nullable: true),
            //            TradeSafeReference = table.Column<Guid>(nullable: true),
            //            OfferAmount = table.Column<double>(nullable: false),
            //            Created = table.Column<DateTime>(type: "datetime", nullable: false),
            //            Accepted = table.Column<DateTime>(type: "datetime", nullable: true),
            //            Updated = table.Column<DateTime>(type: "datetime", nullable: true),
            //            TradeAdId = table.Column<int>(nullable: false),
            //            BuyerId = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_TradeAdTransaction", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.TradeAdTransaction_dbo.TraderProfileSnapshot_BuyerId",
            //                column: x => x.BuyerId,
            //                principalTable: "TraderProfileSnapshot",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Restrict);
            //            table.ForeignKey(
            //                name: "FK_dbo.TradeAdTransaction_dbo.TradeAd_TradeAdId",
            //                column: x => x.TradeAdId,
            //                principalTable: "TradeAd",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Restrict);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "UserFavouriteTradeAd",
            //        columns: table => new
            //        {
            //            UserFavouriteTradeAdID = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            UserID = table.Column<int>(nullable: false),
            //            TradeAdID = table.Column<int>(nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_UserFavouriteTradeAd", x => x.UserFavouriteTradeAdID);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserFavouriteTradeAd_dbo.TradeAd_TradeAdID",
            //                column: x => x.TradeAdID,
            //                principalTable: "TradeAd",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.UserFavouriteTradeAd_dbo.UserProfile_UserID",
            //                column: x => x.UserID,
            //                principalTable: "UserProfile",
            //                principalColumn: "UserId",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "VehicleTradeAd",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Range = table.Column<string>(nullable: true),
            //            Model = table.Column<string>(nullable: true),
            //            YearModel = table.Column<int>(nullable: false),
            //            Colour = table.Column<string>(nullable: true),
            //            Mileage = table.Column<int>(nullable: false),
            //            ServiceHistory = table.Column<bool>(nullable: false),
            //            BrandId = table.Column<int>(nullable: false),
            //            TradeAdId = table.Column<int>(nullable: false),
            //            isOther = table.Column<bool>(nullable: true)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_VehicleTradeAd", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_dbo.VehicleTradeAd_dbo.Brand_BrandId",
            //                column: x => x.BrandId,
            //                principalTable: "Brand",
            //                principalColumn: "BrandId",
            //                onDelete: ReferentialAction.Cascade);
            //            table.ForeignKey(
            //                name: "FK_dbo.VehicleTradeAd_dbo.TradeAd_TradeAdId",
            //                column: x => x.TradeAdId,
            //                principalTable: "TradeAd",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //        });

            //    migrationBuilder.CreateIndex(
            //        name: "IX_PostalCountryId_CountryId",
            //        table: "Address",
            //        column: "PostalCountryId_CountryId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_PostalProvinceId_ProvinceId",
            //        table: "Address",
            //        column: "PostalProvinceId_ProvinceId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_PostalTownId_TownId",
            //        table: "Address",
            //        column: "PostalTownId_TownId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandId",
            //        table: "Advertisement",
            //        column: "BrandId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SupplierId",
            //        table: "Advertisement",
            //        column: "SupplierId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_AdvertisementId",
            //        table: "AdvertisementImage",
            //        column: "AdvertisementId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "AdvertisementImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_AdvertisementId",
            //        table: "AdvertisementRoute",
            //        column: "AdvertisementId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RouteId",
            //        table: "AdvertisementRoute",
            //        column: "RouteId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_AspNetRoleClaims_RoleId",
            //        table: "AspNetRoleClaims",
            //        column: "RoleId");

            //    migrationBuilder.CreateIndex(
            //        name: "RoleNameIndex",
            //        table: "AspNetRoles",
            //        column: "NormalizedName",
            //        unique: true,
            //        filter: "[NormalizedName] IS NOT NULL");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_AspNetUserClaims_UserId",
            //        table: "AspNetUserClaims",
            //        column: "UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_AspNetUserLogins_UserId",
            //        table: "AspNetUserLogins",
            //        column: "UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_AspNetUserRoles_RoleId",
            //        table: "AspNetUserRoles",
            //        column: "RoleId");

            //    migrationBuilder.CreateIndex(
            //        name: "EmailIndex",
            //        table: "AspNetUsers",
            //        column: "NormalizedEmail");

            //    migrationBuilder.CreateIndex(
            //        name: "UserNameIndex",
            //        table: "AspNetUsers",
            //        column: "NormalizedUserName",
            //        unique: true,
            //        filter: "[NormalizedUserName] IS NOT NULL");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_AuctionId",
            //        table: "AuctionItems",
            //        column: "AuctionId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_AuctionCategoryId",
            //        table: "Auctions",
            //        column: "AuctionCategoryId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProvinceId",
            //        table: "Auctions",
            //        column: "ProvinceId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TownId",
            //        table: "Auctions",
            //        column: "TownId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserId",
            //        table: "Auctions",
            //        column: "UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_AgencyId",
            //        table: "Branch",
            //        column: "AgencyId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProvinceId",
            //        table: "Branch",
            //        column: "ProvinceId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TownId",
            //        table: "Branch",
            //        column: "TownId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ContactId",
            //        table: "Brand",
            //        column: "ContactId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandId",
            //        table: "BrandImage",
            //        column: "BrandId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "BrandImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BusinessEntityBaseId",
            //        table: "BusinessEntity",
            //        column: "BusinessEntityBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RouteId",
            //        table: "BusinessEntity",
            //        column: "RouteId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BusinessEntityBaseId",
            //        table: "BusinessEntityImage",
            //        column: "BusinessEntityBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "BusinessEntityImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BusinessEntityId",
            //        table: "BusinessEntityTypeAssignment",
            //        column: "BusinessEntityId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BusinessEntityTypeId",
            //        table: "BusinessEntityTypeAssignment",
            //        column: "BusinessEntityTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_CreatedUserId",
            //        table: "ChatGroup",
            //        column: "CreatedUserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RouteId",
            //        table: "ChatGroup",
            //        column: "RouteId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ChatGroupId",
            //        table: "ChatGroupUserBan",
            //        column: "ChatGroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_CreatedUserId",
            //        table: "ChatGroupUserBan",
            //        column: "CreatedUserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserProfileId",
            //        table: "ChatGroupUserBan",
            //        column: "UserProfileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileImageId",
            //        table: "ChatMessage",
            //        column: "ListingFileImageId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileVideoId",
            //        table: "ChatMessage",
            //        column: "ListingFileVideoId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ClassifiedAdCategory_Id",
            //        table: "ClassifiedAd",
            //        column: "ClassifiedAdCategory_Id");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ClassifiedAdRegion_Id",
            //        table: "ClassifiedAd",
            //        column: "ClassifiedAdRegion_Id");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_User_UserId",
            //        table: "ClassifiedAd",
            //        column: "User_UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_CombineBaseId",
            //        table: "Combine",
            //        column: "CombineBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_MenuTypeID",
            //        table: "Combine",
            //        column: "MenuTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RouteId",
            //        table: "Combine",
            //        column: "RouteId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandID",
            //        table: "CombineBase",
            //        column: "BrandID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EntryTypeID",
            //        table: "CombineBase",
            //        column: "EntryTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_CombineBaseId",
            //        table: "CombineImage",
            //        column: "CombineBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "CombineImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TradeAdId",
            //        table: "CropTradeAd",
            //        column: "TradeAdId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_CompanyTypeId_CompanyTypeId",
            //        table: "Entity",
            //        column: "CompanyTypeId_CompanyTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EntityAddress_AddressTypeId",
            //        table: "Entity",
            //        column: "EntityAddress_AddressTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserTypeId_UserTypeId",
            //        table: "Entity",
            //        column: "UserTypeId_UserTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_PostalCountryId_CountryId",
            //        table: "EntityAddress",
            //        column: "PostalCountryId_CountryId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_PostalProvinceId_ProvinceId",
            //        table: "EntityAddress",
            //        column: "PostalProvinceId_ProvinceId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_PostalTownId_TownId",
            //        table: "EntityAddress",
            //        column: "PostalTownId_TownId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandID",
            //        table: "Entry",
            //        column: "BrandID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EntryTypeTemplateID",
            //        table: "Entry",
            //        column: "EntryTypeTemplateID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_AttributeID",
            //        table: "EntryAttribute",
            //        column: "AttributeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EntryID",
            //        table: "EntryAttribute",
            //        column: "EntryID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EntryID",
            //        table: "EntryHeader",
            //        column: "EntryID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RouteID",
            //        table: "EntryHeader",
            //        column: "RouteID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EntryID",
            //        table: "EntryImage",
            //        column: "EntryID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "EntryImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EntryID",
            //        table: "EntryPDF",
            //        column: "EntryID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "EntryPDF",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_AttributeID",
            //        table: "EntryTypeTemplateAttribute",
            //        column: "AttributeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EntryTypeTemplateID",
            //        table: "EntryTypeTemplateAttribute",
            //        column: "EntryTypeTemplateID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EquipmentBaseId",
            //        table: "Equipment",
            //        column: "EquipmentBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_MenuTypeID",
            //        table: "Equipment",
            //        column: "MenuTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RouteId",
            //        table: "Equipment",
            //        column: "RouteId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandID",
            //        table: "EquipmentBase",
            //        column: "BrandID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EntryTypeID",
            //        table: "EquipmentBase",
            //        column: "EntryTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Specification_ListingFileId",
            //        table: "EquipmentBase",
            //        column: "Specification_ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EquipmentBaseId",
            //        table: "EquipmentImage",
            //        column: "EquipmentBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "EquipmentImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EquipmentBase_EquipmentBaseId",
            //        table: "EquipmentSpecification",
            //        column: "EquipmentBase_EquipmentBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Specification_SpecificationId",
            //        table: "EquipmentSpecification",
            //        column: "Specification_SpecificationId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TradeAdId",
            //        table: "EquipmentTradeAd",
            //        column: "TradeAdId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_InfrastructureID",
            //        table: "Farm",
            //        column: "InfrastructureID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Route_RouteId",
            //        table: "Farm",
            //        column: "Route_RouteId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_WaterRightsID",
            //        table: "Farm",
            //        column: "WaterRightsID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "FarmImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_InfrastructureID",
            //        table: "FarmInfrastructure",
            //        column: "InfrastructureID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_WaterRightID",
            //        table: "FarmWaterRight",
            //        column: "WaterRightID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TradeAdId",
            //        table: "GameAndLivestockTradeAd",
            //        column: "TradeAdId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ChatGroupId",
            //        table: "GroupChatMessage",
            //        column: "ChatGroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ChatMessageId",
            //        table: "GroupChatMessage",
            //        column: "ChatMessageId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SenderId",
            //        table: "GroupChatMessage",
            //        column: "SenderId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_GroupId",
            //        table: "GroupSubGroups",
            //        column: "GroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SubGroupId",
            //        table: "GroupSubGroups",
            //        column: "SubGroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_GroupId",
            //        table: "GroupSuperGroups",
            //        column: "GroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SuperGroupId",
            //        table: "GroupSuperGroups",
            //        column: "SuperGroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ClassifiedAdId",
            //        table: "Image",
            //        column: "ClassifiedAdId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TradeAdId",
            //        table: "InfrastructureTradeAd",
            //        column: "TradeAdId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandId",
            //        table: "LinkRequest",
            //        column: "BrandId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_LinkRequestTypeId",
            //        table: "LinkRequest",
            //        column: "LinkRequestTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SupplierId",
            //        table: "LinkRequest",
            //        column: "SupplierId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandId",
            //        table: "Manager",
            //        column: "BrandId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SupplierId",
            //        table: "Manager",
            //        column: "SupplierId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserId",
            //        table: "Manager",
            //        column: "UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "MarketPDF",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_MarketId",
            //        table: "MarketPDF",
            //        column: "MarketId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_MarketId",
            //        table: "MarketRoute",
            //        column: "MarketId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RouteId",
            //        table: "MarketRoute",
            //        column: "RouteId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Image_MessageImageId",
            //        table: "Message",
            //        column: "Image_MessageImageId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Recipient_UserId",
            //        table: "Message",
            //        column: "Recipient_UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Sender_UserId",
            //        table: "Message",
            //        column: "Sender_UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "MessageImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProvinceId",
            //        table: "MunicipalDistrict",
            //        column: "ProvinceId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_NewsCatId",
            //        table: "News",
            //        column: "NewsCatId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "NewsImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_NewsId",
            //        table: "NewsImage",
            //        column: "NewsId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_MenuTypeID",
            //        table: "Problem",
            //        column: "MenuTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProblemBaseId",
            //        table: "Problem",
            //        column: "ProblemBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RouteId",
            //        table: "Problem",
            //        column: "RouteId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "ProblemAttachment",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProblemBaseId",
            //        table: "ProblemAttachment",
            //        column: "ProblemBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EntryTypeID",
            //        table: "ProblemBase",
            //        column: "EntryTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "ProblemImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProblemBaseId",
            //        table: "ProblemImage",
            //        column: "ProblemBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Problem_ProblemId",
            //        table: "ProblemSymptom",
            //        column: "Problem_ProblemId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Symptom_SymptomId",
            //        table: "ProblemSymptom",
            //        column: "Symptom_SymptomId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_MenuTypeID",
            //        table: "Product",
            //        column: "MenuTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProductBaseId",
            //        table: "Product",
            //        column: "ProductBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RouteId",
            //        table: "Product",
            //        column: "RouteId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ActiveIngredientId",
            //        table: "ProductActiveIngredient",
            //        column: "ActiveIngredientId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProductBaseId",
            //        table: "ProductActiveIngredient",
            //        column: "ProductBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "ProductAttachment",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProductBaseId",
            //        table: "ProductAttachment",
            //        column: "ProductBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandID",
            //        table: "ProductBase",
            //        column: "BrandID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EntryTypeID",
            //        table: "ProductBase",
            //        column: "EntryTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProductBaseId",
            //        table: "ProductBaseRemedyType",
            //        column: "ProductBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RemedyTypeId",
            //        table: "ProductBaseRemedyType",
            //        column: "RemedyTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "ProductImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProductBaseId",
            //        table: "ProductImage",
            //        column: "ProductBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProductBaseId",
            //        table: "ProductSpecification",
            //        column: "ProductBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Specification_SpecificationId",
            //        table: "ProductSpecification",
            //        column: "Specification_SpecificationId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "PropertyAdditionalImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_PropertyAdditionalID",
            //        table: "PropertyAdditionalImage",
            //        column: "PropertyAdditionalID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_PropertyCategory_Id",
            //        table: "PropertyListing",
            //        column: "PropertyCategory_Id");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserId",
            //        table: "PropertyListing",
            //        column: "UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_CountryId",
            //        table: "Province",
            //        column: "CountryId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RelatedBrand_Brand_BrandId",
            //        table: "RelatedBrand",
            //        column: "Brand_BrandId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandId",
            //        table: "RelatedBrand",
            //        column: "BrandId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ChildBrandId",
            //        table: "RelatedBrand",
            //        column: "ChildBrandId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProblemId",
            //        table: "Remedy",
            //        column: "ProblemId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProductBaseId",
            //        table: "Remedy",
            //        column: "ProductBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandId",
            //        table: "Representative",
            //        column: "BrandId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SupplierId",
            //        table: "Representative",
            //        column: "SupplierId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "RepresentativeImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RepresentativeId",
            //        table: "RepresentativeImage",
            //        column: "RepresentativeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProvinceId",
            //        table: "RepresentativeProvince",
            //        column: "ProvinceId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RepresentativeId",
            //        table: "RepresentativeProvince",
            //        column: "RepresentativeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_FunctionID",
            //        table: "RoleFunction",
            //        column: "FunctionID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RoleID",
            //        table: "RoleFunction",
            //        column: "RoleID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_GroupId",
            //        table: "Route",
            //        column: "GroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProblemBaseId",
            //        table: "Route",
            //        column: "ProblemBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SectionId",
            //        table: "Route",
            //        column: "SectionId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SubGroupId",
            //        table: "Route",
            //        column: "SubGroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SuperGroupId",
            //        table: "Route",
            //        column: "SuperGroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListType_ListTypeId",
            //        table: "SubGroupGroupList",
            //        column: "ListType_ListTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SubGroup_SubGroupId",
            //        table: "SubGroupGroupList",
            //        column: "SubGroup_SubGroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_CountryId",
            //        table: "Supplier",
            //        column: "CountryId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProvinceId",
            //        table: "Supplier",
            //        column: "ProvinceId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandId",
            //        table: "SupplierBrand",
            //        column: "BrandId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SupplierId",
            //        table: "SupplierBrand",
            //        column: "SupplierId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Brand_BrandId",
            //        table: "SupplierBrand1",
            //        column: "Brand_BrandId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Supplier_SupplierId",
            //        table: "SupplierBrand1",
            //        column: "Supplier_SupplierId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "SupplierImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SupplierId",
            //        table: "SupplierImage",
            //        column: "SupplierId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_MunicipalDistrictId",
            //        table: "SupplierMunicipalDistrict",
            //        column: "MunicipalDistrictId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SupplierId",
            //        table: "SupplierMunicipalDistrict",
            //        column: "SupplierId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SupplierProduct_EntryId",
            //        table: "SupplierProduct",
            //        column: "EntryId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SupplierProduct_ProductBaseId",
            //        table: "SupplierProduct",
            //        column: "ProductBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Route_RouteId",
            //        table: "SupplierProduct",
            //        column: "Route_RouteId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SupplierId",
            //        table: "SupplierProduct",
            //        column: "SupplierId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SupplierId",
            //        table: "SupplierTown",
            //        column: "SupplierId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TownId",
            //        table: "SupplierTown",
            //        column: "TownId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Province_ProvinceId",
            //        table: "Town",
            //        column: "Province_ProvinceId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_MenuTypeID",
            //        table: "Tractor",
            //        column: "MenuTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RouteId",
            //        table: "Tractor",
            //        column: "RouteId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TractorBaseId",
            //        table: "Tractor",
            //        column: "TractorBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandID",
            //        table: "TractorBase",
            //        column: "BrandID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EntryTypeID",
            //        table: "TractorBase",
            //        column: "EntryTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SpecificationID",
            //        table: "TractorBase",
            //        column: "SpecificationID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "TractorImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TractorBaseId",
            //        table: "TractorImage",
            //        column: "TractorBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_GroupId",
            //        table: "TradeAd",
            //        column: "GroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProvinceId",
            //        table: "TradeAd",
            //        column: "ProvinceId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SellerId",
            //        table: "TradeAd",
            //        column: "SellerId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SubGroupId",
            //        table: "TradeAd",
            //        column: "SubGroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SuperGroupId",
            //        table: "TradeAd",
            //        column: "SuperGroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TownId",
            //        table: "TradeAd",
            //        column: "TownId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TradeAdId",
            //        table: "TradeAdContactLog",
            //        column: "TradeAdId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserProfileId",
            //        table: "TradeAdContactLog",
            //        column: "UserProfileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "TradeAdImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TradeAdId",
            //        table: "TradeAdImage",
            //        column: "TradeAdId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BuyerId",
            //        table: "TradeAdTransaction",
            //        column: "BuyerId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TradeAdId",
            //        table: "TradeAdTransaction",
            //        column: "TradeAdId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BankAccountTypeId",
            //        table: "TraderProfileSnapshot",
            //        column: "BankAccountTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BankId",
            //        table: "TraderProfileSnapshot",
            //        column: "BankId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserId",
            //        table: "TraderProfileSnapshot",
            //        column: "UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BankAccountTypeId",
            //        table: "UserBankAccount",
            //        column: "BankAccountTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BankId",
            //        table: "UserBankAccount",
            //        column: "BankId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserId",
            //        table: "UserBankAccount",
            //        column: "UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TradeAdID",
            //        table: "UserFavouriteTradeAd",
            //        column: "TradeAdID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserID",
            //        table: "UserFavouriteTradeAd",
            //        column: "UserID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "UserImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserId",
            //        table: "UserImage",
            //        column: "UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Industry_GroupId",
            //        table: "UserIndustries",
            //        column: "Industry_GroupId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_User_UserId",
            //        table: "UserIndustries",
            //        column: "User_UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_AddressId_AddressTypeId",
            //        table: "UserProfile",
            //        column: "AddressId_AddressTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ParentUser_UserId",
            //        table: "UserProfile",
            //        column: "ParentUser_UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserType_UserTypeId",
            //        table: "UserProfile",
            //        column: "UserType_UserTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ChatMessageId",
            //        table: "UserProfileChatMessage",
            //        column: "ChatMessageId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ReceiverId",
            //        table: "UserProfileChatMessage",
            //        column: "ReceiverId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SenderId",
            //        table: "UserProfileChatMessage",
            //        column: "SenderId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RouteId",
            //        table: "UserRoute",
            //        column: "RouteId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserId",
            //        table: "UserRoute",
            //        column: "UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_AccessLevel_AccessTypeId",
            //        table: "UserType",
            //        column: "AccessLevel_AccessTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EmployeeType_EmployeeTypeId",
            //        table: "UserType",
            //        column: "EmployeeType_EmployeeTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ProfileType_ProfileTypeId",
            //        table: "UserType",
            //        column: "ProfileType_ProfileTypeId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_MenuTypeID",
            //        table: "Vehicle",
            //        column: "MenuTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RouteId",
            //        table: "Vehicle",
            //        column: "RouteId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_VehicleBaseId",
            //        table: "Vehicle",
            //        column: "VehicleBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandID",
            //        table: "VehicleBase",
            //        column: "BrandID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_EntryTypeID",
            //        table: "VehicleBase",
            //        column: "EntryTypeID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_SpecificationID",
            //        table: "VehicleBase",
            //        column: "SpecificationID");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ListingFileId",
            //        table: "VehicleImage",
            //        column: "ListingFileId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_VehicleBaseId",
            //        table: "VehicleImage",
            //        column: "VehicleBaseId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_BrandId",
            //        table: "VehicleTradeAd",
            //        column: "BrandId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TradeAdId",
            //        table: "VehicleTradeAd",
            //        column: "TradeAdId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserId",
            //        table: "webpages_OAuthMembership",
            //        column: "UserId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_RoleId",
            //        table: "webpages_UsersInRoles",
            //        column: "RoleId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_UserId",
            //        table: "webpages_UsersInRoles",
            //        column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__MigrationHistory");

            migrationBuilder.DropTable(
                name: "AdvertisementImage");

            migrationBuilder.DropTable(
                name: "AdvertisementRoute");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AuctionItems");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "BrandImage");

            migrationBuilder.DropTable(
                name: "BusinessEntityImage");

            migrationBuilder.DropTable(
                name: "BusinessEntityTypeAssignment");

            migrationBuilder.DropTable(
                name: "BusinessType");

            migrationBuilder.DropTable(
                name: "BussinessProfile");

            migrationBuilder.DropTable(
                name: "CensoredWord");

            migrationBuilder.DropTable(
                name: "ChatGroupUserBan");

            migrationBuilder.DropTable(
                name: "Combine");

            migrationBuilder.DropTable(
                name: "CombineImage");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CropTradeAd");

            migrationBuilder.DropTable(
                name: "Entity");

            migrationBuilder.DropTable(
                name: "EntryAttribute");

            migrationBuilder.DropTable(
                name: "EntryHeader");

            migrationBuilder.DropTable(
                name: "EntryImage");

            migrationBuilder.DropTable(
                name: "EntryPDF");

            migrationBuilder.DropTable(
                name: "EntryTypeTemplateAttribute");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "EquipmentFarm");

            migrationBuilder.DropTable(
                name: "EquipmentImage");

            migrationBuilder.DropTable(
                name: "EquipmentSpecification");

            migrationBuilder.DropTable(
                name: "EquipmentTradeAd");

            migrationBuilder.DropTable(
                name: "Farm");

            migrationBuilder.DropTable(
                name: "FarmImage");

            migrationBuilder.DropTable(
                name: "FarmInfrastructure");

            migrationBuilder.DropTable(
                name: "FarmType");

            migrationBuilder.DropTable(
                name: "FarmWaterRight");

            migrationBuilder.DropTable(
                name: "GameAndLivestockTradeAd");

            migrationBuilder.DropTable(
                name: "GroupChatMessage");

            migrationBuilder.DropTable(
                name: "GroupList");

            migrationBuilder.DropTable(
                name: "GroupSubGroups");

            migrationBuilder.DropTable(
                name: "GroupSuperGroups");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "InfrastructureTradeAd");

            migrationBuilder.DropTable(
                name: "Institution");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "LinkRequest");

            migrationBuilder.DropTable(
                name: "ListingEntry");

            migrationBuilder.DropTable(
                name: "ManagementGroup");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "MarketPDF");

            migrationBuilder.DropTable(
                name: "MarketRoute");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "NewsImage");

            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "ProblemAttachment");

            migrationBuilder.DropTable(
                name: "ProblemImage");

            migrationBuilder.DropTable(
                name: "ProblemSymptom");

            migrationBuilder.DropTable(
                name: "ProblemType");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductActiveIngredient");

            migrationBuilder.DropTable(
                name: "ProductAttachment");

            migrationBuilder.DropTable(
                name: "ProductBaseRemedyType");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "ProductSpecification");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "PropertyAdditionalImage");

            migrationBuilder.DropTable(
                name: "PropertyListing");

            migrationBuilder.DropTable(
                name: "RelatedBrand");

            migrationBuilder.DropTable(
                name: "Remedy");

            migrationBuilder.DropTable(
                name: "RepresentativeImage");

            migrationBuilder.DropTable(
                name: "RepresentativeProvince");

            migrationBuilder.DropTable(
                name: "RoleFunction");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "Shares");

            migrationBuilder.DropTable(
                name: "SocialMediaCatagories");

            migrationBuilder.DropTable(
                name: "SubGroupGroupList");

            migrationBuilder.DropTable(
                name: "SupplierBrand");

            migrationBuilder.DropTable(
                name: "SupplierBrand1");

            migrationBuilder.DropTable(
                name: "SupplierImage");

            migrationBuilder.DropTable(
                name: "SupplierMunicipalDistrict");

            migrationBuilder.DropTable(
                name: "SupplierProduct");

            migrationBuilder.DropTable(
                name: "SupplierTown");

            migrationBuilder.DropTable(
                name: "TopLevelItem");

            migrationBuilder.DropTable(
                name: "Tractor");

            migrationBuilder.DropTable(
                name: "TractorImage");

            migrationBuilder.DropTable(
                name: "TradeAdContactLog");

            migrationBuilder.DropTable(
                name: "TradeAdImage");

            migrationBuilder.DropTable(
                name: "TradeAdTransaction");

            migrationBuilder.DropTable(
                name: "TradeSafeLog");

            migrationBuilder.DropTable(
                name: "UserBankAccount");

            migrationBuilder.DropTable(
                name: "UserFavouriteTradeAd");

            migrationBuilder.DropTable(
                name: "UserImage");

            migrationBuilder.DropTable(
                name: "UserIndustries");

            migrationBuilder.DropTable(
                name: "UserLog");

            migrationBuilder.DropTable(
                name: "UserProfileChatMessage");

            migrationBuilder.DropTable(
                name: "UserRoute");

            migrationBuilder.DropTable(
                name: "UserWeatherSetting");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "VehicleImage");

            migrationBuilder.DropTable(
                name: "VehicleTradeAd");

            migrationBuilder.DropTable(
                name: "webpages_OAuthMembership");

            migrationBuilder.DropTable(
                name: "webpages_UsersInRoles");

            migrationBuilder.DropTable(
                name: "Advertisement");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Auctions");

            migrationBuilder.DropTable(
                name: "Agency");

            migrationBuilder.DropTable(
                name: "BusinessEntity");

            migrationBuilder.DropTable(
                name: "BusinessEntityType");

            migrationBuilder.DropTable(
                name: "CombineBase");

            migrationBuilder.DropTable(
                name: "CompanyType");

            migrationBuilder.DropTable(
                name: "EntityAddress");

            migrationBuilder.DropTable(
                name: "Attribute");

            migrationBuilder.DropTable(
                name: "EquipmentBase");

            migrationBuilder.DropTable(
                name: "Infrastructure");

            migrationBuilder.DropTable(
                name: "WaterRights");

            migrationBuilder.DropTable(
                name: "ChatGroup");

            migrationBuilder.DropTable(
                name: "ClassifiedAd");

            migrationBuilder.DropTable(
                name: "LinkRequestType");

            migrationBuilder.DropTable(
                name: "Market");

            migrationBuilder.DropTable(
                name: "MessageImage");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Symptom");

            migrationBuilder.DropTable(
                name: "ActiveIngredient");

            migrationBuilder.DropTable(
                name: "RemedyType");

            migrationBuilder.DropTable(
                name: "Specification");

            migrationBuilder.DropTable(
                name: "PropertyAdditional");

            migrationBuilder.DropTable(
                name: "PropertyCategory");

            migrationBuilder.DropTable(
                name: "Problem");

            migrationBuilder.DropTable(
                name: "Representative");

            migrationBuilder.DropTable(
                name: "Function");

            migrationBuilder.DropTable(
                name: "ListType");

            migrationBuilder.DropTable(
                name: "MunicipalDistrict");

            migrationBuilder.DropTable(
                name: "Entry");

            migrationBuilder.DropTable(
                name: "ProductBase");

            migrationBuilder.DropTable(
                name: "TractorBase");

            migrationBuilder.DropTable(
                name: "ChatMessage");

            migrationBuilder.DropTable(
                name: "VehicleBase");

            migrationBuilder.DropTable(
                name: "TradeAd");

            migrationBuilder.DropTable(
                name: "webpages_Roles");

            migrationBuilder.DropTable(
                name: "webpages_Membership");

            migrationBuilder.DropTable(
                name: "AuctionCategory");

            migrationBuilder.DropTable(
                name: "BusinessEntityBase");

            migrationBuilder.DropTable(
                name: "ClassifiedsCategories");

            migrationBuilder.DropTable(
                name: "ClassifiedAdRegion");

            migrationBuilder.DropTable(
                name: "NewsCat");

            migrationBuilder.DropTable(
                name: "MenuType");

            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "EntryTypeTemplate");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "ListingFile");

            migrationBuilder.DropTable(
                name: "TraderProfileSnapshot");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "ProblemBase");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "SubGroups");

            migrationBuilder.DropTable(
                name: "SuperGroups");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "BankAccountType");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "EntryType");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DropTable(
                name: "Town");

            migrationBuilder.DropTable(
                name: "AccessType");

            migrationBuilder.DropTable(
                name: "EmployeeType");

            migrationBuilder.DropTable(
                name: "ProfileType");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
