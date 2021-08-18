using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ProjectCancelInformation
    {
        public int ProjectCancelInfoId { get; set; }
        public int ProjectId { get; set; }
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

        public virtual TrnUser ApplicantUser { get; set; }
        public virtual TrnUser CarelineUser { get; set; }
        public virtual Project Project { get; set; }
    }
}
