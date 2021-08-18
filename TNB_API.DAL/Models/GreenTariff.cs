using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class GreenTariff
    {
        public GreenTariff()
        {
            GreenTariffAttachments = new HashSet<GreenTariffAttachment>();
        }

        public int GreenTariffId { get; set; }
        public string ReferenceNo { get; set; }
        public int ApplicationModuleId { get; set; }
        public string GreenTariffEntryMode { get; set; }
        public string ContractAccountNo { get; set; }
        public int AccountTypeId { get; set; }
        public Guid UserId { get; set; }
        public int StatusId { get; set; }
        public string SrNo { get; set; }
        public string SnNo { get; set; }
        public string BpNo { get; set; }
        public int? PreviousBlocks { get; set; }
        public int? NewBlocks { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string IdentificationNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
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
        public string PremiseStreetCode { get; set; }
        public string VoltageLevel { get; set; }
        public string StationCode { get; set; }
        public string ContactPersonBpNo { get; set; }
        public string ContactPersonName1 { get; set; }
        public string ContactPersonName2 { get; set; }
        public string ContactPersonMobileNo { get; set; }
        public string ContactPersonEmail { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string PremiseTypeItemCode { get; set; }
        public string SrapplicationDetail { get; set; }

        public virtual ICollection<GreenTariffAttachment> GreenTariffAttachments { get; set; }
    }
}
