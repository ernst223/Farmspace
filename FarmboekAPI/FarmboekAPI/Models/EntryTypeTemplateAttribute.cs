using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class EntryTypeTemplateAttribute
    {
        public int EntryTypeTemplateAttributeId { get; set; }
        public int EntryTypeTemplateId { get; set; }
        public int AttributeId { get; set; }

        public Attribute Attribute { get; set; }
        public EntryTypeTemplate EntryTypeTemplate { get; set; }
    }
}
