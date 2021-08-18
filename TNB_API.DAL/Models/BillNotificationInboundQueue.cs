using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class BillNotificationInboundQueue
    {
        public Guid BillNotificationInboundQueueId { get; set; }
        public string EmailId { get; set; }
        public string DeviceId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsSent { get; set; }
        public DateTime? SentDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? IsDeletedDate { get; set; }
    }
}
