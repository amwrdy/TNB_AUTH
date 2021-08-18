using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class NewConnectionCancelInformation
    {
        public int NccancelInfoId { get; set; }
        public int NewConnectionId { get; set; }
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

        public virtual TrnUser ApplicantUser { get; set; }
        public virtual TrnUser CarelineUser { get; set; }
        public virtual TrnUser ContractorUser { get; set; }
        public virtual NewConnection NewConnection { get; set; }
    }
}
