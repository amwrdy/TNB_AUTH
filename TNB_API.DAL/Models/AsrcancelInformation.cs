using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class AsrcancelInformation
    {
        public int AsrcancelInfoId { get; set; }
        public int AddressSearchRequestId { get; set; }
        public string CancelReasons { get; set; }
        public string Comment { get; set; }
        public Guid CarelineUserId { get; set; }
        public Guid? ApplicantUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual AddressSearchRequest AddressSearchRequest { get; set; }
        public virtual TrnUser ApplicantUser { get; set; }
        public virtual TrnUser CarelineUser { get; set; }
    }
}
