using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigTrnUserStaging
    {
        public Guid? UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Salt { get; set; }
        public int? SalutationId { get; set; }
        public int? IdentificationType { get; set; }
        public string IdentificationNo { get; set; }
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public string MobileNo { get; set; }
        public string FixedLineNo { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        public string MaidenName { get; set; }
        public string KinName { get; set; }
        public string KinContactNo { get; set; }
        public int? CommId { get; set; }
        public string MailingAddr1 { get; set; }
        public string MailingAddr2 { get; set; }
        public string MailingAddr3 { get; set; }
        public string MailingAddrState { get; set; }
        public string City { get; set; }
        public int? Postcode { get; set; }
        public string Country { get; set; }
        public int? DefaultHomePage { get; set; }
        public bool? IsLockOut { get; set; }
        public int? PasswordAttempt { get; set; }
        public string RegistrationSource { get; set; }
        public DateTime? LastLoginFromWeb { get; set; }
        public DateTime? LastLoginFromMobile { get; set; }
        public DateTime? ActivationExpiryDate { get; set; }
        public bool? IsNotified { get; set; }
        public bool? IsActivated { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public int? Id { get; set; }
        public int? LoadLineage { get; set; }
        public DateTime? LoadDate { get; set; }
        public string SourcePassword { get; set; }
        public string SourceEncryptPassword { get; set; }
        public int? SourceEncryptionProcessFlag { get; set; }
    }
}
