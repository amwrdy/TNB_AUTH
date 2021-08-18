using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class BillNotificationOutboundTrace
    {
        public Guid BillNotificationOutboundTraceId { get; set; }
        public Guid? UserId { get; set; }
        public string EmailId { get; set; }
        public string DeviceId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsSent { get; set; }
        public DateTime? SentDateTime { get; set; }
        public int? SentCount { get; set; }
        public string ReturnCode { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime? NextTryDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
