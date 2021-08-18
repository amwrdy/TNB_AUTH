using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class AsrlogAction
    {
        public int AsrlogActionId { get; set; }
        public int AddressSearchRequestId { get; set; }
        public Guid? CarelineUserId { get; set; }
        public Guid? RetailDataUserId { get; set; }
        public int StatusId { get; set; }
        public string AssignedState { get; set; }
        public string Asraction { get; set; }
        public string Comment { get; set; }
        public string CancelReason { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual AddressSearchRequest AddressSearchRequest { get; set; }
        public virtual TrnUser CarelineUser { get; set; }
        public virtual TrnUser RetailDataUser { get; set; }
        public virtual ApplicationStatus Status { get; set; }
    }
}
