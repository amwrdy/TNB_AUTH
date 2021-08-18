using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Project
    {
        public Project()
        {
            ProjectAttachments = new HashSet<ProjectAttachment>();
            ProjectCallLogs = new HashSet<ProjectCallLog>();
            ProjectCancelInformations = new HashSet<ProjectCancelInformation>();
            ProjectConsultants = new HashSet<ProjectConsultant>();
            ProjectContractors = new HashSet<ProjectContractor>();
            ProjectPics = new HashSet<ProjectPic>();
            ProjectReworkInformations = new HashSet<ProjectReworkInformation>();
        }

        public int ProjectId { get; set; }
        public string ReferenceNo { get; set; }
        public string TnbProjectId { get; set; }
        public int ApplicationModuleId { get; set; }
        public Guid UserId { get; set; }
        public string ProjectName { get; set; }
        public string SrNo { get; set; }
        public string SnNo { get; set; }
        public string LoadType { get; set; }
        public string PremiseCategory { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public int? IdentificationTypeId { get; set; }
        public string IdentificationNo { get; set; }
        public string FixedLineNo { get; set; }
        public long? EContractorId { get; set; }
        public int StatusId { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string DeclaredMd { get; set; }
        public string VoltageLevel { get; set; }
        public string StationCode { get; set; }
        public string StationCodeErms { get; set; }
        public string PremiseState { get; set; }
        public string PremisePostalCode { get; set; }
        public string PremiseTown { get; set; }
        public string PremiseCity { get; set; }
        public string PremiseStreet { get; set; }
        public string PremiseBuilding { get; set; }
        public string PremiseHouseNo { get; set; }
        public string PremiseUnitNo { get; set; }
        public string PremiseType { get; set; }
        public string PremiseSubStation { get; set; }
        public string Bpbuilding { get; set; }
        public string BphouseNo { get; set; }
        public string BpunitNo { get; set; }
        public string Bpstreet { get; set; }
        public string BppostalCode { get; set; }
        public string Bptown { get; set; }
        public string Bpcity { get; set; }
        public string Bpstate { get; set; }
        public string Bpcountry { get; set; }
        public string BppropertyType { get; set; }
        public string BpfaxNo { get; set; }
        public int? ParcelQty { get; set; }
        public int? MaxMoveIn { get; set; }
        public decimal? Cctotal { get; set; }
        public string ProformaInvNo { get; set; }
        public bool? UpdateParcelFlag { get; set; }
        public bool? IsParcelReduce { get; set; }
        public bool? IsAcknowledge { get; set; }
        public bool? IsTnc { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string Source { get; set; }
        public string PremiseStreetCode { get; set; }
        public string BpNo { get; set; }
        public string CaNo { get; set; }
        public string ContactBpNo { get; set; }
        public int? PremiseOwnerAccountTypeId { get; set; }
        public int? PremiseTypeHeaderId { get; set; }
        public string PremiseTypeItemCode { get; set; }
        public string CodeGroup { get; set; }
        public bool? IsGeeligible { get; set; }
        public int? AccountTypeId { get; set; }
        public bool? IsSearchByCa { get; set; }
        public string NextOfKinName1 { get; set; }
        public string NextOfKinName2 { get; set; }
        public string NextOfKinPhoneNo { get; set; }
        public string NextOfKinEmail { get; set; }
        public string CustomerName1 { get; set; }
        public string CustomerName2 { get; set; }
        public string CustomerMobileNo { get; set; }
        public string CustomerIdentificationNo { get; set; }
        public int? CustomerIdentificationTypeId { get; set; }
        public string CustomerFixedLineNo { get; set; }
        public string CustomerFaxNo { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPremiseState { get; set; }
        public string CustomerPremiseStreet { get; set; }
        public string CustomerPremiseStreetCode { get; set; }
        public string CustomerPremiseTownArea { get; set; }
        public string CustomerPremiseHouseNo { get; set; }
        public string CustomerPremiseUnitNo { get; set; }
        public string CustomerPremisePostalCode { get; set; }
        public bool? IsCustomerSameAsOwner { get; set; }
        public string CustomerPremiseCity { get; set; }
        public int? CustomerSalutationId { get; set; }
        public int? CustomerGivenTitleId { get; set; }
        public string CustomerPremisePropertyType { get; set; }
        public DateTime? CustomerDob { get; set; }
        public string CustomerMothersName { get; set; }
        public string CustomerBpNo { get; set; }
        public bool? CustomerBpmismatchFlag { get; set; }
        public string CustomerPremiseBuilding { get; set; }
        public string MailBuilding { get; set; }
        public string MailType { get; set; }
        public string MailCity { get; set; }
        public string MailState { get; set; }
        public string MailStreet { get; set; }
        public string MailArea { get; set; }
        public string MailHouseNo { get; set; }
        public string MailUnitNo { get; set; }
        public string MailPostalCode { get; set; }
        public bool? IsNewPremise { get; set; }
        public string ContactPersonName1 { get; set; }
        public string ContactPersonName2 { get; set; }
        public string ContactPersonPosition { get; set; }
        public string ContactPersonMobileNo { get; set; }
        public string ContactPersonEmailAddress { get; set; }
        public string TypeOfForm { get; set; }
        public string GeapplicationType { get; set; }
        public int? InstallationType { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string SupplyType { get; set; }
        public string StreetlightSubCategoryCode { get; set; }
        public string SrapplicationDetail { get; set; }
        public int? CommunicationId { get; set; }
        public int? BillingDeliveryId { get; set; }
        public int? PremiseOwnershipId { get; set; }
        public string BillingEmail { get; set; }

        public virtual ApplicationStatus Status { get; set; }
        public virtual TrnUser User { get; set; }
        public virtual ICollection<ProjectAttachment> ProjectAttachments { get; set; }
        public virtual ICollection<ProjectCallLog> ProjectCallLogs { get; set; }
        public virtual ICollection<ProjectCancelInformation> ProjectCancelInformations { get; set; }
        public virtual ICollection<ProjectConsultant> ProjectConsultants { get; set; }
        public virtual ICollection<ProjectContractor> ProjectContractors { get; set; }
        public virtual ICollection<ProjectPic> ProjectPics { get; set; }
        public virtual ICollection<ProjectReworkInformation> ProjectReworkInformations { get; set; }
    }
}
