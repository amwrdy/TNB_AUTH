using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Rewiring
    {
        public Rewiring()
        {
            RewiringApplicationStatuses = new HashSet<RewiringApplicationStatus>();
            RewiringAttachments = new HashSet<RewiringAttachment>();
            RewiringContractors = new HashSet<RewiringContractor>();
        }

        public int RewiringId { get; set; }
        public string ReferenceNo { get; set; }
        public int ApplicationModuleId { get; set; }
        public Guid UserId { get; set; }
        public string SrNo { get; set; }
        public string SnNo { get; set; }
        public string LoadChangeType { get; set; }
        public string LoadType { get; set; }
        public string ContractAccountNo { get; set; }
        public int AccountTypeId { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string BpNo { get; set; }
        public string PremiseNo { get; set; }
        public bool? PremiseServiceReady { get; set; }
        public string PremiseVoltageLevel { get; set; }
        public int? PremiseTypeHeaderId { get; set; }
        public string PremiseTypeItemCode { get; set; }
        public int? NewPremiseTypeHeaderId { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string TariffRate { get; set; }
        public string StationCode { get; set; }
        public int StatusId { get; set; }
        public int? IdentificationTypeId { get; set; }
        public string IdentificationNo { get; set; }
        public DateTime? Dob { get; set; }
        public string ContactPersonBpNo { get; set; }
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
        public decimal? PremiseCurrentMaxDemand { get; set; }
        public Guid? ContractorId { get; set; }
        public string ApplicantType { get; set; }
        public string MailAddrTag { get; set; }
        public string MailState { get; set; }
        public string MailPostalCode { get; set; }
        public string MailArea { get; set; }
        public string MailCity { get; set; }
        public string MailStreet { get; set; }
        public string MailBuilding { get; set; }
        public string MailUnitNo { get; set; }
        public string MailHouseNo { get; set; }
        public string MailType { get; set; }
        public double? OutstandingAmount { get; set; }
        public string PaymentFlag { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string PremiseStreetCode { get; set; }
        public bool? IsInitiatedByCon { get; set; }
        public bool? IsTimeOfUseEligibility { get; set; }
        public bool? IsTimeOfUse { get; set; }
        public int? PurposeId { get; set; }
        public bool? IsAppliedAllDay { get; set; }
        public string RegisterGroup { get; set; }
        public string SrapplicationDetail { get; set; }
        public int? CommunicationId { get; set; }
        public int? BillingDeliveryId { get; set; }
        public int? PremiseOwnershipId { get; set; }
        public string BillingEmail { get; set; }

        public virtual RewiringTechnical RewiringTechnical { get; set; }
        public virtual ICollection<RewiringApplicationStatus> RewiringApplicationStatuses { get; set; }
        public virtual ICollection<RewiringAttachment> RewiringAttachments { get; set; }
        public virtual ICollection<RewiringContractor> RewiringContractors { get; set; }
    }
}
