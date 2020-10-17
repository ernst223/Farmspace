using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int ProductBaseId { get; set; }
        public int RouteId { get; set; }
        public int MenuTypeId { get; set; }

        public MenuType MenuType { get; set; }
        public ProductBase ProductBase { get; set; }
        public Route Route { get; set; }
    }
}
