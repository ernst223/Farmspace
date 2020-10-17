using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class WebpagesMembership
    {
        public WebpagesMembership()
        {
            WebpagesOauthMembership = new HashSet<WebpagesOauthMembership>();
            WebpagesUsersInRoles = new HashSet<WebpagesUsersInRoles>();
        }

        public int UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ConfirmationToken { get; set; }
        public bool? IsConfirmed { get; set; }
        public DateTime? LastPasswordFailureDate { get; set; }
        public int PasswordFailuresSinceLastSuccess { get; set; }
        public string Password { get; set; }
        public DateTime? PasswordChangedDate { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordVerificationToken { get; set; }
        public DateTime? PasswordVerificationTokenExpirationDate { get; set; }

        public ICollection<WebpagesOauthMembership> WebpagesOauthMembership { get; set; }
        public ICollection<WebpagesUsersInRoles> WebpagesUsersInRoles { get; set; }
    }
}
