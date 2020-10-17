using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ChatMessage
    {
        public ChatMessage()
        {
            GroupChatMessage = new HashSet<GroupChatMessage>();
            UserProfileChatMessage = new HashSet<UserProfileChatMessage>();
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime? SeenDate { get; set; }
        public int? ListingFileImageId { get; set; }
        public int? ListingFileVideoId { get; set; }

        public ListingFile ListingFileImage { get; set; }
        public ListingFile ListingFileVideo { get; set; }
        public ICollection<GroupChatMessage> GroupChatMessage { get; set; }
        public ICollection<UserProfileChatMessage> UserProfileChatMessage { get; set; }
    }
}
