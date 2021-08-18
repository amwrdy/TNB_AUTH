using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class TrnSubModuleRole
    {
        public int SubModuleRoleId { get; set; }
        public int? RoleId { get; set; }
        public int? SubModuleId { get; set; }
        public int? Access { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Ssprole Role { get; set; }
        public virtual SubModule SubModule { get; set; }
    }
}
