using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class CotexistingOwnerLog
    {
        public Guid CotexistingOwnerLogId { get; set; }
        public int Cotid { get; set; }
        public Guid? ExistingOwnerId { get; set; }
        public string Ownerid { get; set; }
        public DateTime? DisconnectDate { get; set; }
        public TimeSpan? DisconnectTime { get; set; }
        public bool? MeterBoardAccessible { get; set; }
        public string RefundMethod { get; set; }
        public int? RefundBankId { get; set; }
        public string RefundBankAccount { get; set; }
        public string OwnerMailUnitNo { get; set; }
        public string OwnerMailBuilding { get; set; }
        public string OwnerMailHouseNo { get; set; }
        public string OwnerMailStreet { get; set; }
        public string OwnerMailArea { get; set; }
        public string OwnerMailCity { get; set; }
        public string OwnerMailPostalCode { get; set; }
        public string OwnerMailState { get; set; }
        public int? OwnerIdentificationTypeId { get; set; }
        public string RefundName1 { get; set; }
        public string RefundName2 { get; set; }
        public string HousePhoneNumber { get; set; }
        public bool? IsAlternateRefundMethod { get; set; }
        public string RefundMobileNumber { get; set; }
        public string RefundEmail { get; set; }
        public string TransferDepositCaNo { get; set; }
        public string Attachments { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public int? StatusId { get; set; }
    }
}
