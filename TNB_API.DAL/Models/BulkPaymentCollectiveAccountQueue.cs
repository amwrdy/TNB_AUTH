using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class BulkPaymentCollectiveAccountQueue
    {
        public BulkPaymentCollectiveAccountQueue()
        {
            BulkPaymentAccountListQueues = new HashSet<BulkPaymentAccountListQueue>();
        }

        public int EbulkExtractionId { get; set; }
        public string ExtractionDate { get; set; }
        public string ExtractionTime { get; set; }
        public string CollectiveContractAccountNo { get; set; }
        public string CollectiveInvoiceNo { get; set; }
        public string CollectiveInvoiceDueDate { get; set; }
        public string TotalTransactionRecords { get; set; }
        public string TotalTransactionAmount { get; set; }
        public bool IsPaymentPaid { get; set; }
        public string PaymentPaidDate { get; set; }
        public int? StatusId { get; set; }
        public bool? IsPaidByCollectiveAccount { get; set; }
        public Guid? EbulkPaymentId { get; set; }
        public Guid? UserId { get; set; }
        public string TnbreferenceNo { get; set; }
        public string ReturnCode { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string ReferenceNo { get; set; }
        public string CollectiveAccountName { get; set; }

        public virtual BulkPayment EbulkPayment { get; set; }
        public virtual ICollection<BulkPaymentAccountListQueue> BulkPaymentAccountListQueues { get; set; }
    }
}
