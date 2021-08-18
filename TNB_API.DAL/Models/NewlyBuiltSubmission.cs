using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class NewlyBuiltSubmission
    {
        public double? ApplicationModuleId { get; set; }
        public string UserId { get; set; }
        public string LoadType { get; set; }
        public double? AccountTypeId { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public double? PremiseTypeHeaderId { get; set; }
        public string PremiseTypeItemCode { get; set; }
        public string ContractorId { get; set; }
        public string ApplicantType { get; set; }
        public string PremiseCategory { get; set; }
        public DateTime? RequiredDate { get; set; }
        public double? StationCode { get; set; }
        public double? StatusId { get; set; }
        public double? SalutationId { get; set; }
        public double? IdentificationTypeId { get; set; }
        public string IdentificationNo { get; set; }
        public DateTime? Dob { get; set; }
        public string MobileNo { get; set; }
        public string FixedLineNo { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        public string MothersName { get; set; }
        public string NextOfKinName2 { get; set; }
        public string NextOfKinPhoneNo { get; set; }
        public string NextOfKinEmail { get; set; }
        public double? IsSearchByCa { get; set; }
        public string PremiseState { get; set; }
        public double? PremisePostalCode { get; set; }
        public string PremiseArea { get; set; }
        public string PremiseCity { get; set; }
        public string PremiseStreet { get; set; }
        public string PremiseHouseNo { get; set; }
        public string PremiseType { get; set; }
        public double? NewPremise { get; set; }
        public string MailState { get; set; }
        public double? MailPostalCode { get; set; }
        public string MailArea { get; set; }
        public string MailCity { get; set; }
        public string MailStreet { get; set; }
        public string MailHouseNo { get; set; }
        public string MailType { get; set; }
        public double? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public double? PremiseStreetCode { get; set; }
    }
}
