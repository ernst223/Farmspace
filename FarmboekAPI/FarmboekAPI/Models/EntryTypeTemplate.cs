using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class EntryTypeTemplate
    {
        public EntryTypeTemplate()
        {
            Entry = new HashSet<Entry>();
            EntryTypeTemplateAttribute = new HashSet<EntryTypeTemplateAttribute>();
        }

        public int EntryTypeTemplateId { get; set; }
        public string Name { get; set; }

        public ICollection<Entry> Entry { get; set; }
        public ICollection<EntryTypeTemplateAttribute> EntryTypeTemplateAttribute { get; set; }
    }
}
