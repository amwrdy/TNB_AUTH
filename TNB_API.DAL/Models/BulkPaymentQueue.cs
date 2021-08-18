using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class BulkPaymentQueue
    {
        public Guid BulkQueueId { get; set; }
        public string PaymentId { get; set; }
        public string PaymentChannel { get; set; }
        public string PaymentDate { get; set; }
        public string TotalAmount { get; set; }
        public string TotalItems { get; set; }
        public string LineNo { get; set; }
        public string RevenueCode { get; set; }
        public string PaymentMode { get; set; }
        public string ReferenceNo { get; set; }
        public string BankCode { get; set; }
        public string ChequeNo { get; set; }
        public string ChequeType { get; set; }
        public string AccountNo { get; set; }
        public string InvoiceNo { get; set; }
        public string PaymentAmount { get; set; }
        public string CollAccountNo { get; set; }
        public string CollInvoiceNo { get; set; }
        public string CreditCardNo { get; set; }
        public string AuthCode { get; set; }
        public string CardTransType { get; set; }
        public string MerchantId { get; set; }
        public DateTime? NextTryDate { get; set; }
        public bool IsSent { get; set; }
        public int? SentCount { get; set; }
        public DateTime? SentDateTime { get; set; }
        public bool? PaidByCollective { get; set; }
        public bool? LastItem { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
