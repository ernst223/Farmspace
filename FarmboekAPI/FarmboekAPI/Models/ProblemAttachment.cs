﻿using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ProblemAttachment
    {
        public int ProblemAttachmentId { get; set; }
        public int ProblemBaseId { get; set; }
        public int ListingFileId { get; set; }

        public ListingFile ListingFile { get; set; }
        public ProblemBase ProblemBase { get; set; }
    }
}
