using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ChatGroupUserBan
    {
        public int Id { get; set; }
        public int ChatGroupId { get; set; }
        public int UserProfileId { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public ChatGroup ChatGroup { get; set; }
        public UserProfile CreatedUser { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
