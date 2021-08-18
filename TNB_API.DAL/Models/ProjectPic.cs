using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ProjectPic
    {
        public int ProjectPicId { get; set; }
        public int ProjectId { get; set; }
        public int Type { get; set; }
        public Guid? UserId { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Project Project { get; set; }
        public virtual MasterLookup TypeNavigation { get; set; }
    }
}
