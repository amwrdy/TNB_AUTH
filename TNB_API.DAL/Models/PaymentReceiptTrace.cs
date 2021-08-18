using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class PaymentReceiptTrace
    {
        public Guid PaymentReceiptTraceId { get; set; }
        public int PaymentReceiptId { get; set; }
        public DateTime? NextTryDate { get; set; }
        public bool IsSent { get; set; }
        public int? SentCount { get; set; }
        public DateTime? SentDateTime { get; set; }
        public string ReturnCode { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
