using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class NewConnectionBackup8Nov19
    {
        public int NewConnectionId { get; set; }
        public string ReferenceNo { get; set; }
        public int ApplicationModuleId { get; set; }
        public Guid UserId { get; set; }
        public string SrNo { get; set; }
        public string SnNo { get; set; }
        public string ContractAccountNo { get; set; }
        public string LoadType { get; set; }
        public bool Rewiring { get; set; }
        public int AccountTypeId { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string BpNo { get; set; }
        public string PremiseNo { get; set; }
        public bool? PremiseServiceReady { get; set; }
        public int? PremiseTypeHeaderId { get; set; }
        public string PremiseTypeItemCode { get; set; }
        public Guid? ContractorId { get; set; }
        public string ApplicantType { get; set; }
        public string PremiseCategory { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string StationCode { get; set; }
        public int StatusId { get; set; }
        public string SrStatus { get; set; }
        public string SnStatus { get; set; }
        public DateTime? StatusDate { get; set; }
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
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public bool? IsSearchByCa { get; set; }
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
        public bool? NewPremise { get; set; }
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
        public int? ParcelId { get; set; }
        public string ProformaInvoiceNo { get; set; }
        public bool? LoadChange { get; set; }
        public int? ApprovedAgeing { get; set; }
        public string Gstno { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string Source { get; set; }
        public string PremiseStreetCode { get; set; }
        public bool? IsContractorEnable { get; set; }
        public string LockStatus { get; set; }
        public string ProcessBy { get; set; }
        public string ApprovalStatus { get; set; }
        public string InstallationNo { get; set; }
        public string SearchedCano { get; set; }
        public string SnForAttachment { get; set; }
        public string UserRole { get; set; }
        public string StreetlightSubCategoryCode { get; set; }
        public int? Aging { get; set; }
        public bool? IsRsgexist { get; set; }
        public int? StaffId { get; set; }
        public bool? SdexemptionFlag { get; set; }
        public bool? SkipQuestionnaire { get; set; }
        public bool? QuestionnaireAnswer { get; set; }
        public bool? IsTimeOfUseEligibility { get; set; }
        public bool? IsTimeOfUse { get; set; }
        public string RegisterGroup { get; set; }
    }
}
