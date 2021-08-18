using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class PaymentStatus
    {
        public PaymentStatus()
        {
            BulkPayments = new HashSet<BulkPayment>();
            PaymentReceipts = new HashSet<PaymentReceipt>();
        }

        public int StatusId { get; set; }
        public string StatusDescription { get; set; }
        public string StatusCode { get; set; }
        public string Area { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<BulkPayment> BulkPayments { get; set; }
        public virtual ICollection<PaymentReceipt> PaymentReceipts { get; set; }
    }
}
