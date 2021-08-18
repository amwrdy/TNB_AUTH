using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Coaapplication
    {
        public Coaapplication()
        {
            CoaapplicationStatuses = new HashSet<CoaapplicationStatus>();
            Coaattachments = new HashSet<Coaattachment>();
        }

        public int Coaid { get; set; }
        public string ReferenceNo { get; set; }
        public int ApplicationModuleId { get; set; }
        public Guid UserId { get; set; }
        public string SrNo { get; set; }
        public string AccountNumber { get; set; }
        public int? AccountTypeId { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Bpnumber { get; set; }
        public string PremiseNo { get; set; }
        public string PremiseState { get; set; }
        public string PremisePostalCode { get; set; }
        public string PremiseArea { get; set; }
        public string PremiseCity { get; set; }
        public string PremiseStreet { get; set; }
        public string PremiseBuilding { get; set; }
        public string PremiseUnitNo { get; set; }
        public string PremiseHouseNo { get; set; }
        public string PremiseType { get; set; }
        public string MailState { get; set; }
        public string MailPostalCode { get; set; }
        public string MailArea { get; set; }
        public string MailCity { get; set; }
        public string MailStreet { get; set; }
        public string MailBuilding { get; set; }
        public string MailHouseNo { get; set; }
        public string MailUnitNo { get; set; }
        public string MailType { get; set; }
        public bool? MeterBoardAccessible { get; set; }
        public Guid? GroupPaymentId { get; set; }
        public string InvoiceNo { get; set; }
        public string PaymentType { get; set; }
        public double? OutstandingAmount { get; set; }
        public DateTime? DisconnectDate { get; set; }
        public string DisconnectTime { get; set; }
        public string RefundMethod { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public string OwnerId { get; set; }
        public int? OwnerIdentificationTypeId { get; set; }
        public string TransferDepositCaNo { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string StationCode { get; set; }
        public int StatusId { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string PremiseStreetCode { get; set; }
        public bool? IsOwnStaying { get; set; }
        public string AlternateBpnumber { get; set; }
        public string RefundName1 { get; set; }
        public string RefundName2 { get; set; }
        public string HousePhoneNumber { get; set; }
        public bool? IsAlternateRefundMethod { get; set; }
        public string SrapplicationDetail { get; set; }

        public virtual ICollection<CoaapplicationStatus> CoaapplicationStatuses { get; set; }
        public virtual ICollection<Coaattachment> Coaattachments { get; set; }
    }
}
