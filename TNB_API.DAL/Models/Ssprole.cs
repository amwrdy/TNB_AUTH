using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Ssprole
    {
        public Ssprole()
        {
            LnkUserRoles = new HashSet<LnkUserRole>();
            TrnSubModuleRoles = new HashSet<TrnSubModuleRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public int? Internal { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<LnkUserRole> LnkUserRoles { get; set; }
        public virtual ICollection<TrnSubModuleRole> TrnSubModuleRoles { get; set; }
    }
}
