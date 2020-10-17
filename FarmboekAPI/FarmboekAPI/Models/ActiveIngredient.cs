using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ActiveIngredient
    {
        public ActiveIngredient()
        {
            ProductActiveIngredient = new HashSet<ProductActiveIngredient>();
        }

        public int ActiveIngredientId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<ProductActiveIngredient> ProductActiveIngredient { get; set; }
    }
}
