using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ClassifiedAd
    {
        public ClassifiedAd()
        {
            Image = new HashSet<Image>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public int ClassifiedAdCategoryId { get; set; }
        public int ClassifiedAdRegionId { get; set; }
        public int? UserUserId { get; set; }

        public ClassifiedsCategories ClassifiedAdCategory { get; set; }
        public ClassifiedAdRegion ClassifiedAdRegion { get; set; }
        public UserProfile UserUser { get; set; }
        public ICollection<Image> Image { get; set; }
    }
}
