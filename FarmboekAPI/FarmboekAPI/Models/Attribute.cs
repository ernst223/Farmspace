using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class Attribute
    {
        public Attribute()
        {
            EntryAttribute = new HashSet<EntryAttribute>();
            EntryTypeTemplateAttribute = new HashSet<EntryTypeTemplateAttribute>();
        }

        public int AttributeId { get; set; }
        public string Key { get; set; }

        public ICollection<EntryAttribute> EntryAttribute { get; set; }
        public ICollection<EntryTypeTemplateAttribute> EntryTypeTemplateAttribute { get; set; }
    }
}
