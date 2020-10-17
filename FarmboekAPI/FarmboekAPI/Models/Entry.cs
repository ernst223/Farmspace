using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Entry
    {
        public Entry()
        {
            EntryAttribute = new HashSet<EntryAttribute>();
            EntryHeader = new HashSet<EntryHeader>();
            EntryImage = new HashSet<EntryImage>();
            EntryPdf = new HashSet<EntryPdf>();
            SupplierProduct = new HashSet<SupplierProduct>();
        }

        public int EntryId { get; set; }
        public string Name { get; set; }
        public bool IsBrowseBy { get; set; }
        public bool IsInfo { get; set; }
        public int? BrandId { get; set; }
        public int? EntryTypeTemplateId { get; set; }
        public string Range { get; set; }

        public Brand Brand { get; set; }
        public EntryTypeTemplate EntryTypeTemplate { get; set; }
        public ICollection<EntryAttribute> EntryAttribute { get; set; }
        public ICollection<EntryHeader> EntryHeader { get; set; }
        public ICollection<EntryImage> EntryImage { get; set; }
        public ICollection<EntryPdf> EntryPdf { get; set; }
        public ICollection<SupplierProduct> SupplierProduct { get; set; }
    }
}
