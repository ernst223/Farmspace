using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ListingEntry
    {
        public int ListingEntryId { get; set; }
        public string ListingEntryName { get; set; }
        public string ListingEntryDesc { get; set; }
        public bool IsInformation { get; set; }
        public bool IsCommercial { get; set; }
        public double Price { get; set; }
        public string ActiveIngredient { get; set; }
        public string Remedy { get; set; }
        public int Rating { get; set; }
        public string ExernalLink { get; set; }
    }
}
