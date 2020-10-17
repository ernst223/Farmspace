using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class UserProfile
    {
        public UserProfile()
        {
            Auctions = new HashSet<Auctions>();
            ChatGroup = new HashSet<ChatGroup>();
            ChatGroupUserBanCreatedUser = new HashSet<ChatGroupUserBan>();
            ChatGroupUserBanUserProfile = new HashSet<ChatGroupUserBan>();
            ClassifiedAd = new HashSet<ClassifiedAd>();
            GroupChatMessage = new HashSet<GroupChatMessage>();
            InverseParentUserUser = new HashSet<UserProfile>();
            Manager = new HashSet<Manager>();
            MessageRecipientUser = new HashSet<Message>();
            MessageSenderUser = new HashSet<Message>();
            PropertyListing = new HashSet<PropertyListing>();
            TradeAdContactLog = new HashSet<TradeAdContactLog>();
            TraderProfileSnapshot = new HashSet<TraderProfileSnapshot>();
            UserBankAccount = new HashSet<UserBankAccount>();
            UserFavouriteTradeAd = new HashSet<UserFavouriteTradeAd>();
            UserImage = new HashSet<UserImage>();
            UserIndustries = new HashSet<UserIndustries>();
            UserProfileChatMessageReceiver = new HashSet<UserProfileChatMessage>();
            UserProfileChatMessageSender = new HashSet<UserProfileChatMessage>();
            UserRoute = new HashSet<UserRoute>();
            WebpagesOauthMembership = new HashSet<WebpagesOauthMembership>();
        }

        public int UserId { get; set; }
        public string UserTypeName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public bool IsAdministrator { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool TermsAndConditions { get; set; }
        public int? UserTypeUserTypeId { get; set; }
        public bool IsSubUser { get; set; }
        public int? ParentUserUserId { get; set; }
        public int? AddressIdAddressTypeId { get; set; }
        public string SouthAfricanIdNumber { get; set; }

        public Address AddressIdAddressType { get; set; }
        public UserProfile ParentUserUser { get; set; }
        public UserType UserTypeUserType { get; set; }
        public ICollection<Auctions> Auctions { get; set; }
        public ICollection<ChatGroup> ChatGroup { get; set; }
        public ICollection<ChatGroupUserBan> ChatGroupUserBanCreatedUser { get; set; }
        public ICollection<ChatGroupUserBan> ChatGroupUserBanUserProfile { get; set; }
        public ICollection<ClassifiedAd> ClassifiedAd { get; set; }
        public ICollection<GroupChatMessage> GroupChatMessage { get; set; }
        public ICollection<UserProfile> InverseParentUserUser { get; set; }
        public ICollection<Manager> Manager { get; set; }
        public ICollection<Message> MessageRecipientUser { get; set; }
        public ICollection<Message> MessageSenderUser { get; set; }
        public ICollection<PropertyListing> PropertyListing { get; set; }
        public ICollection<TradeAdContactLog> TradeAdContactLog { get; set; }
        public ICollection<TraderProfileSnapshot> TraderProfileSnapshot { get; set; }
        public ICollection<UserBankAccount> UserBankAccount { get; set; }
        public ICollection<UserFavouriteTradeAd> UserFavouriteTradeAd { get; set; }
        public ICollection<UserImage> UserImage { get; set; }
        public ICollection<UserIndustries> UserIndustries { get; set; }
        public ICollection<UserProfileChatMessage> UserProfileChatMessageReceiver { get; set; }
        public ICollection<UserProfileChatMessage> UserProfileChatMessageSender { get; set; }
        public ICollection<UserRoute> UserRoute { get; set; }
        public ICollection<WebpagesOauthMembership> WebpagesOauthMembership { get; set; }
    }
}
