using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Page
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string PageTitle { get; set; }
        public string PageSubTitle { get; set; }
        public string PageContent { get; set; }
        public string PagePath { get; set; }
        public string PageKeyWords { get; set; }
    }
}
