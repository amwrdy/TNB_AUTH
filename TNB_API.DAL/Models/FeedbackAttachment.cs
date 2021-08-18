﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class FeedbackAttachment
    {
        public Guid FileId { get; set; }
        public int FeedbackId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string FileGroupId { get; set; }

        public virtual Feedback Feedback { get; set; }
    }
}
