using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class BulkPaymentAccountList
    {
        public int EbulkExtractionId { get; set; }
        public string ContractAccountNo { get; set; }
        public string CollectiveContractAccountNo { get; set; }
        public string CollectiveInvoiceNo { get; set; }
        public string Reference { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public string CurrentCharge { get; set; }
        public string TotalAmountPayable { get; set; }
        public string OutstandingAmount { get; set; }
        public string Gstamount { get; set; }
        public string TaxBasedAmount { get; set; }
        public string AmountWithoutGst { get; set; }
        public Guid? EbulkPaymentId { get; set; }
        public bool? IsPaymentNotificationSent { get; set; }
        public string Comment { get; set; }
        public bool IsPaymentPaid { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public string LastBillPaid { get; set; }
        public string LastBillNo { get; set; }
        public string LastAmountPaid { get; set; }
        public string PremiseAddress { get; set; }
        public string ReadingDate { get; set; }
        public string CurrentReading { get; set; }
        public string ReadingType { get; set; }
        public string TariffCode { get; set; }
        public string TariffDescription { get; set; }
        public int? StatusId { get; set; }
        public string ActiveId { get; set; }
        public bool IsOutstandingAllowed { get; set; }
        public string TnbreferenceNo { get; set; }
        public string ReturnCode { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string ReferenceNo { get; set; }
        public string ReadingEndDate { get; set; }
        public string AdjustmentIndicator { get; set; }
        public string InstanceFlag { get; set; }
        public string IsPayLotmatch { get; set; }

        public virtual BulkPaymentCollectiveAccount CollectiveInvoiceNoNavigation { get; set; }
        public virtual BulkPayment EbulkPayment { get; set; }
    }
}
