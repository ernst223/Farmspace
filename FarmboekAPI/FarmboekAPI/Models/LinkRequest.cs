using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class LinkRequest
    {
        public int Id { get; set; }
        public int? SupplierId { get; set; }
        public int? BrandId { get; set; }
        public string Requestor { get; set; }
        public Guid RequestGuid { get; set; }
        public int LinkRequestTypeId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Edited { get; set; }

        public Brand Brand { get; set; }
        public LinkRequestType LinkRequestType { get; set; }
        public Supplier Supplier { get; set; }
    }
}
