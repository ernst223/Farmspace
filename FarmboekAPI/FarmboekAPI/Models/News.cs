using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class News
    {
        public News()
        {
            NewsImage = new HashSet<NewsImage>();
        }

        public int NewsId { get; set; }
        public string Author { get; set; }
        public DateTime? Date { get; set; }
        public string Headline { get; set; }
        public string Body { get; set; }
        public string Link { get; set; }
        public bool Active { get; set; }
        public int NewsCatId { get; set; }
        public string Intro { get; set; }

        public NewsCat NewsCat { get; set; }
        public ICollection<NewsImage> NewsImage { get; set; }
    }
}
