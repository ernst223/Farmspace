using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class MessageImage
    {
        public MessageImage()
        {
            Message = new HashSet<Message>();
        }

        public int MessageImageId { get; set; }
        public int MessageId { get; set; }
        public int ListingFileId { get; set; }

        public ListingFile ListingFile { get; set; }
        public ICollection<Message> Message { get; set; }
    }
}
