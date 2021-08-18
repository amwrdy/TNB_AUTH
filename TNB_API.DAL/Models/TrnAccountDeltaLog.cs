using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class TrnAccountDeltaLog
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Crudindicator { get; set; }
        public Guid AccountId { get; set; }
        public string AccountCategory { get; set; }
        public int AccountCategoryId { get; set; }
        public int? AccountTypeId { get; set; }
        public string AccountNumber { get; set; }
        public int? IdentificationType { get; set; }
        public string IdentificationNo { get; set; }
        public int? Roc { get; set; }
        public string MotherName { get; set; }
        public Guid UserId { get; set; }
        public string PremiseAddress { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string HouseNo { get; set; }
        public string UnitNo { get; set; }
        public string ContactNo { get; set; }
        public string MobileNo { get; set; }
        public bool? IsOwnedAccount { get; set; }
        public string OwnerName { get; set; }
        public string AccountDescription { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Amsid { get; set; }
        public string LastModifiedSource { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LogCreatedDate { get; set; }
        public string LogCreatedBy { get; set; }
        public bool? PostedToBcrm { get; set; }
        public DateTime? PostedToBcrmdate { get; set; }
    }
}
