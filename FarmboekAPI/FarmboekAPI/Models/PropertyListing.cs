using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class PropertyListing
    {
        public int PropertyId { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int ProvinceId { get; set; }
        public int TownId { get; set; }
        public string Suburb { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int PostalCode { get; set; }
        public string ListingType { get; set; }
        public int ListingPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }
        public int PropertyCategoryId { get; set; }
        public int NoOfBedrooms { get; set; }
        public int NoOfBathrooms { get; set; }
        public int NoOfGarages { get; set; }

        public PropertyCategory PropertyCategory { get; set; }
        public UserProfile User { get; set; }
    }
}
