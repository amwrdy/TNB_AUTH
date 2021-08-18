using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class CotcancelInformation
    {
        public int CotcancelInfoId { get; set; }
        public int Cotid { get; set; }
        public string CancelReasons { get; set; }
        public string Comment { get; set; }
        public Guid CarelineUserId { get; set; }
        public Guid? ExistingOwnerUserId { get; set; }
        public Guid? NewOwnerUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual TrnUser CarelineUser { get; set; }
        public virtual Cotapplication Cot { get; set; }
        public virtual TrnUser ExistingOwnerUser { get; set; }
        public virtual TrnUser NewOwnerUser { get; set; }
    }
}
