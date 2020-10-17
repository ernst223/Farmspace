using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class GroupChatMessage
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ChatMessageId { get; set; }
        public int ChatGroupId { get; set; }

        public ChatGroup ChatGroup { get; set; }
        public ChatMessage ChatMessage { get; set; }
        public UserProfile Sender { get; set; }
    }
}
