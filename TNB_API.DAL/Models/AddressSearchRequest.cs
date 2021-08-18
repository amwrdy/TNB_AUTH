using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class AddressSearchRequest
    {
        public AddressSearchRequest()
        {
            Asrattachments = new HashSet<Asrattachment>();
            AsrcallLogAttachments = new HashSet<AsrcallLogAttachment>();
            AsrcancelInformations = new HashSet<AsrcancelInformation>();
            AsrlogActions = new HashSet<AsrlogAction>();
        }

        public int AddressSearchRequestId { get; set; }
        public string ReferenceNo { get; set; }
        public Guid UserId { get; set; }
        public string StationEmail { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string UnitNo { get; set; }
        public string HouseNo { get; set; }
        public string PremiseType { get; set; }
        public int StatusId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string PremiseFullText { get; set; }
        public string StreetCode { get; set; }
        public string PremiseNo { get; set; }
        public int? ApplicationModuleId { get; set; }
        public string ApplicationRefNo { get; set; }
        public string FormUnitNo { get; set; }
        public string FormBuildingName { get; set; }
        public int? RoleId { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public string ResolvedBy { get; set; }
        public string AssignedState { get; set; }
        public int? Aging { get; set; }
        public string ProcessBy { get; set; }
        public string LockStatus { get; set; }
        public int? SubmissionSource { get; set; }
        public string FormBuildingNumber { get; set; }

        public virtual ApplicationStatus Status { get; set; }
        public virtual ICollection<Asrattachment> Asrattachments { get; set; }
        public virtual ICollection<AsrcallLogAttachment> AsrcallLogAttachments { get; set; }
        public virtual ICollection<AsrcancelInformation> AsrcancelInformations { get; set; }
        public virtual ICollection<AsrlogAction> AsrlogActions { get; set; }
    }
}
