using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class BulkPayment
    {
        public BulkPayment()
        {
            BulkPaymentAccountListQueues = new HashSet<BulkPaymentAccountListQueue>();
            BulkPaymentAccountLists = new HashSet<BulkPaymentAccountList>();
            BulkPaymentCollectiveAccountQueues = new HashSet<BulkPaymentCollectiveAccountQueue>();
            BulkPaymentCollectiveAccounts = new HashSet<BulkPaymentCollectiveAccount>();
        }

        public Guid EbulkPaymentId { get; set; }
        public string CollectiveContractAccountNo { get; set; }
        public bool? IsPaymentPaid { get; set; }
        public string ModeofPayment { get; set; }
        public string PaymentRefNo { get; set; }
        public string ApproveOrrejectedBy { get; set; }
        public DateTime? ApproveOrrejectedDate { get; set; }
        public bool IsPaymentNotificationSent { get; set; }
        public string Comment { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string TransactionAmount { get; set; }
        public string TotalItems { get; set; }
        public int? StatusId { get; set; }
        public string ReturnCode { get; set; }
        public string BankId { get; set; }
        public string TnbreferenceNo { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string TypeOfPayment { get; set; }

        public virtual BankForBulkPayment Bank { get; set; }
        public virtual PaymentStatus Status { get; set; }
        public virtual ICollection<BulkPaymentAccountListQueue> BulkPaymentAccountListQueues { get; set; }
        public virtual ICollection<BulkPaymentAccountList> BulkPaymentAccountLists { get; set; }
        public virtual ICollection<BulkPaymentCollectiveAccountQueue> BulkPaymentCollectiveAccountQueues { get; set; }
        public virtual ICollection<BulkPaymentCollectiveAccount> BulkPaymentCollectiveAccounts { get; set; }
    }
}
