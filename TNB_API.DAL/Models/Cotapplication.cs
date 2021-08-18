using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Cotapplication
    {
        public Cotapplication()
        {
            CotapplicationStatuses = new HashSet<CotapplicationStatus>();
            Cotattachments = new HashSet<Cotattachment>();
            CotcallLogs = new HashSet<CotcallLog>();
            CotcancelInformations = new HashSet<CotcancelInformation>();
            CotsubmitSystemMessages = new HashSet<CotsubmitSystemMessage>();
        }

        public int Cotid { get; set; }
        public string ReferenceNo { get; set; }
        public int ApplicationModuleId { get; set; }
        public Guid UserId { get; set; }
        public Guid? ExistingOwnerId { get; set; }
        public string SrNo { get; set; }
        public int? RequestReasonId { get; set; }
        public string ContractAccountNo { get; set; }
        public string ExistingContractAccountNo { get; set; }
        public int AccountTypeId { get; set; }
        public string AccountClass { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string BpNo { get; set; }
        public string ExistingOwnerName1 { get; set; }
        public string ExistingOwnerName2 { get; set; }
        public string TransferDepositCaNo { get; set; }
        public string PremiseNo { get; set; }
        public bool? PremiseServiceReady { get; set; }
        public int? PremiseTypeHeaderId { get; set; }
        public string PremiseTypeItemCode { get; set; }
        public string ApplicantType { get; set; }
        public string PremiseCategory { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? DisconnetDate { get; set; }
        public TimeSpan? DisconnectTime { get; set; }
        public string StationCode { get; set; }
        public int StatusId { get; set; }
        public int? SalutationId { get; set; }
        public int? GivenTitleId { get; set; }
        public int? IdentificationTypeId { get; set; }
        public string IdentificationNo { get; set; }
        public DateTime? Dob { get; set; }
        public string ContactPersonName1 { get; set; }
        public string ContactPersonName2 { get; set; }
        public string ContactPersonPosition { get; set; }
        public string MobileNo { get; set; }
        public string FixedLineNo { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        public string MothersName { get; set; }
        public string NextOfKinName1 { get; set; }
        public string NextOfKinName2 { get; set; }
        public string NextOfKinPhoneNo { get; set; }
        public string NextOfKinEmail { get; set; }
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
        public string MailUnitNo { get; set; }
        public string MailHouseNo { get; set; }
        public string MailType { get; set; }
        public int? MaReligion { get; set; }
        public int? MaRace { get; set; }
        public int? MaIncome { get; set; }
        public int? MaOccupation { get; set; }
        public int? MaEducation { get; set; }
        public int? MaPaymentMethod { get; set; }
        public int? MaPaymentChannel { get; set; }
        public bool? MeterBoardAccessible { get; set; }
        public string RefundMethod { get; set; }
        public int? RefundBankId { get; set; }
        public string RefundBankAccount { get; set; }
        public string OwnerContactNo { get; set; }
        public string OwnerEmail { get; set; }
        public int? OwnerIdentificationTypeId { get; set; }
        public string OwnerId { get; set; }
        public string OwnerMailState { get; set; }
        public string OwnerMailPostalCode { get; set; }
        public string OwnerMailArea { get; set; }
        public string OwnerMailCity { get; set; }
        public string OwnerMailStreet { get; set; }
        public string OwnerMailBuilding { get; set; }
        public string OwnerMailUnitNo { get; set; }
        public string OwnerMailHouseNo { get; set; }
        public string OwnerMailType { get; set; }
        public bool? OwnerIndicator { get; set; }
        public double? OutstandingAmount { get; set; }
        public string PaymentFlag { get; set; }
        public bool? Rejected { get; set; }
        public string RejectReason { get; set; }
        public string Gstno { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string PremiseStreetCode { get; set; }
        public int? Aging { get; set; }
        public string ProcessBy { get; set; }
        public string LockStatus { get; set; }
        public string AlternateBpnumber { get; set; }
        public string RefundName1 { get; set; }
        public string RefundName2 { get; set; }
        public string HousePhoneNumber { get; set; }
        public bool? IsAlternateRefundMethod { get; set; }
        public string RefundMobileNumber { get; set; }
        public string RefundEmail { get; set; }
        public int? StaffId { get; set; }
        public bool? SdexemptionFlag { get; set; }
        public bool? IsTimeOfUseEligibility { get; set; }
        public bool? IsTimeOfUse { get; set; }
        public int? OwnershipType { get; set; }
        public string RegisterGroup { get; set; }
        public bool IsExistingWeldSetLoadAvailable { get; set; }
        public bool IsUpdateExistingWeldSetLoad { get; set; }
        public bool IsApplyForWeldSetLoad { get; set; }
        public int? WeldTotalConnected { get; set; }
        public string SrapplicationDetail { get; set; }
        public int? CommunicationId { get; set; }
        public int? BillingDeliveryId { get; set; }
        public int? PremiseOwnershipId { get; set; }
        public string BillingEmail { get; set; }
        public bool? IsIdntfctnNoAvailable { get; set; }

        public virtual ApplicationStatus Status { get; set; }
        public virtual ICollection<CotapplicationStatus> CotapplicationStatuses { get; set; }
        public virtual ICollection<Cotattachment> Cotattachments { get; set; }
        public virtual ICollection<CotcallLog> CotcallLogs { get; set; }
        public virtual ICollection<CotcancelInformation> CotcancelInformations { get; set; }
        public virtual ICollection<CotsubmitSystemMessage> CotsubmitSystemMessages { get; set; }
    }
}
