using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class PaymentReceiptLog
    {
        public Guid LogId { get; set; }
        public DateTime LogTime { get; set; }
        public string LogOperation { get; set; }
        public int PaymentReceiptId { get; set; }
        public string ReferenceNo { get; set; }
        public Guid GroupPaymentId { get; set; }
        public int PaymentStatusId { get; set; }
        public DateTime? PgresponseDate { get; set; }
        public int? RequeryCount { get; set; }
        public DateTime? NextTryDate { get; set; }
        public bool IsRepost { get; set; }
        public DateTime? RepostDate { get; set; }
        public Guid UserId { get; set; }
        public string AccountNo { get; set; }
        public decimal ReqAmount { get; set; }
        public string ReqCustomerName { get; set; }
        public string ReqCustomerEmail { get; set; }
        public string ReqDescription { get; set; }
        public string ReqTriggerUrl { get; set; }
        public string ResPaymentMethod { get; set; }
        public string ResErrorCode { get; set; }
        public string ResErrorDescription { get; set; }
        public string ResTransactionStatus { get; set; }
        public string ResCustomerName { get; set; }
        public decimal? ResAmount { get; set; }
        public string ResEui { get; set; }
        public string ResCardNo { get; set; }
        public string ResCardType { get; set; }
        public string ResAuthCode { get; set; }
        public string ResIsOnUs { get; set; }
        public int? ResTransactionId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string ReqPaymentMethod { get; set; }
        public bool IsQuickPay { get; set; }
        public string PremiseAddress { get; set; }
        public bool OneTimeRequery { get; set; }
        public int OneTimeRequeryCount { get; set; }
        public DateTime? OneTimeRequeryDateTime { get; set; }
        public string OneTimeRequeryResponse { get; set; }
        public DateTime? OneTimeRequeryNextTry { get; set; }
        public string ReqCustomerMobileNo { get; set; }
        public string Ipaddress { get; set; }
        public string Browser { get; set; }
    }
}
