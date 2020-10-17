using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class LinkRequestType
    {
        public LinkRequestType()
        {
            LinkRequest = new HashSet<LinkRequest>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<LinkRequest> LinkRequest { get; set; }
    }
}
