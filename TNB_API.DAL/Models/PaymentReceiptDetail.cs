using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class PaymentReceiptDetail
    {
        public Guid PaymentReceiptDetailId { get; set; }
        public Guid? GroupPaymentId { get; set; }
        public string RevenueCode { get; set; }
        public Guid? AccountId { get; set; }
        public Guid? Reid { get; set; }
        public int? NewConnectionId { get; set; }
        public int? Cotid { get; set; }
        public int? RewiringId { get; set; }
        public int? ProjectId { get; set; }
        public decimal? Amount1 { get; set; }
        public decimal? Amount2 { get; set; }
        public decimal? Amount3 { get; set; }
        public decimal OutstandingAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public string InvoiceNo { get; set; }
        public string ReturnCode { get; set; }
        public string BcrmpaymentDocNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string OwnerName { get; set; }
        public string AccountNo { get; set; }
        public int? GreenTariffId { get; set; }
        public Guid? BackendAppId { get; set; }
        public Guid? FavAppId { get; set; }
    }
}
