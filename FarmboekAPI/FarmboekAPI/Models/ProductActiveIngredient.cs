using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ProductActiveIngredient
    {
        public int ProductActiveIngredientId { get; set; }
        public int ProductBaseId { get; set; }
        public int ActiveIngredientId { get; set; }

        public ActiveIngredient ActiveIngredient { get; set; }
        public ProductBase ProductBase { get; set; }
    }
}
