using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class EntryAttribute
    {
        public int EntryAttributeId { get; set; }
        public int EntryId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }

        public Attribute Attribute { get; set; }
        public Entry Entry { get; set; }
    }
}
