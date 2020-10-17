using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public int Status { get; set; }
        public bool IsSystem { get; set; }
        public bool SenderDeleted { get; set; }
        public bool RecipientDeleted { get; set; }
        public bool IsInfoMessage { get; set; }
        public int? ImageMessageImageId { get; set; }
        public int RecipientUserId { get; set; }
        public int? SenderUserId { get; set; }

        public MessageImage ImageMessageImage { get; set; }
        public UserProfile RecipientUser { get; set; }
        public UserProfile SenderUser { get; set; }
    }
}
