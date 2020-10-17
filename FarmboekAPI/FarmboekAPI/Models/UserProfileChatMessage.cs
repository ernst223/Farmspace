using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class UserProfileChatMessage
    {
        public int Id { get; set; }
        public int ChatMessageId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public DateTime? SenderClearedDate { get; set; }
        public DateTime? ReceiverClearedDate { get; set; }

        public ChatMessage ChatMessage { get; set; }
        public UserProfile Receiver { get; set; }
        public UserProfile Sender { get; set; }
    }
}
