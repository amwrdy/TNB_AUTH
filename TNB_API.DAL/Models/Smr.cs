using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Smr
    {
        public Smr()
        {
            Smrattachments = new HashSet<Smrattachment>();
        }

        public int Smrid { get; set; }
        public string SmrentryMode { get; set; }
        public string ReferenceNo { get; set; }
        public string SrNo { get; set; }
        public string ContractAccountNo { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string IdentificationNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string PremiseState { get; set; }
        public string PremisePostalCode { get; set; }
        public string PremiseArea { get; set; }
        public string PremiseCity { get; set; }
        public string PremiseStreet { get; set; }
        public string PremiseBuilding { get; set; }
        public string PremiseUnitNo { get; set; }
        public string PremiseType { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public int ApplicationModuleId { get; set; }
        public int StatusId { get; set; }
        public Guid? UserId { get; set; }
        public string PremiseStreetCode { get; set; }
        public string TerminationNote { get; set; }
        public string SrapplicationDetail { get; set; }

        public virtual ICollection<Smrattachment> Smrattachments { get; set; }
    }
}
