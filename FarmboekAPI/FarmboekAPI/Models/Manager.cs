using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Manager
    {
        public int ManagerId { get; set; }
        public int? SupplierId { get; set; }
        public int? UserId { get; set; }
        public int? BrandId { get; set; }
        public bool IsActive { get; set; }

        public Brand Brand { get; set; }
        public Supplier Supplier { get; set; }
        public UserProfile User { get; set; }
    }
}
