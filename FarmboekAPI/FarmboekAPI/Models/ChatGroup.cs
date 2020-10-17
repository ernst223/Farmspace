using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ChatGroup
    {
        public ChatGroup()
        {
            ChatGroupUserBan = new HashSet<ChatGroupUserBan>();
            GroupChatMessage = new HashSet<GroupChatMessage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatedUserId { get; set; }
        public int RouteId { get; set; }

        public UserProfile CreatedUser { get; set; }
        public Route Route { get; set; }
        public ICollection<ChatGroupUserBan> ChatGroupUserBan { get; set; }
        public ICollection<GroupChatMessage> GroupChatMessage { get; set; }
    }
}
