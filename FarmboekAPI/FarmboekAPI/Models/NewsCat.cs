using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class NewsCat
    {
        public NewsCat()
        {
            News = new HashSet<News>();
        }

        public int NewsCatId { get; set; }
        public string Description { get; set; }

        public ICollection<News> News { get; set; }
    }
}
