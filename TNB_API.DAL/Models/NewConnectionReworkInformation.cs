using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class NewConnectionReworkInformation
    {
        public int NcreworkInfoId { get; set; }
        public int NewConnectionId { get; set; }
        public int ReworkParty { get; set; }
        public int? ReworkReason1 { get; set; }
        public int? ReworkReason2 { get; set; }
        public int? ReworkReason3 { get; set; }
        public int? ReworkReason4 { get; set; }
        public int? ReworkReason5 { get; set; }
        public string Comment { get; set; }
        public Guid CarelineUserId { get; set; }
        public Guid? ApplicantUserId { get; set; }
        public Guid? ContractorUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public int? ReworkReason6 { get; set; }
        public int? ReworkReason7 { get; set; }
        public int? ReworkReason8 { get; set; }

        public virtual TrnUser ApplicantUser { get; set; }
        public virtual TrnUser CarelineUser { get; set; }
        public virtual TrnUser ContractorUser { get; set; }
        public virtual NewConnection NewConnection { get; set; }
        public virtual MasterLookup ReworkPartyNavigation { get; set; }
        public virtual MasterLookup ReworkReason1Navigation { get; set; }
        public virtual MasterLookup ReworkReason2Navigation { get; set; }
        public virtual MasterLookup ReworkReason3Navigation { get; set; }
        public virtual MasterLookup ReworkReason4Navigation { get; set; }
        public virtual MasterLookup ReworkReason5Navigation { get; set; }
        public virtual MasterLookup ReworkReason6Navigation { get; set; }
        public virtual MasterLookup ReworkReason7Navigation { get; set; }
        public virtual MasterLookup ReworkReason8Navigation { get; set; }
    }
}
