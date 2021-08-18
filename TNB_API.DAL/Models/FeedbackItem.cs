using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class FeedbackItem
    {
        public Guid RequestId { get; set; }
        public int FeedbackId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual Feedback Feedback { get; set; }
    }
}
