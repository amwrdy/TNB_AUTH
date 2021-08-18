using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class SubModule
    {
        public SubModule()
        {
            TrnSubModuleRoles = new HashSet<TrnSubModuleRole>();
            TrnUsers = new HashSet<TrnUser>();
        }

        public int SubModuleId { get; set; }
        public string SubModuleName { get; set; }
        public string PageCode { get; set; }
        public int? ModuleId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Module Module { get; set; }
        public virtual ICollection<TrnSubModuleRole> TrnSubModuleRoles { get; set; }
        public virtual ICollection<TrnUser> TrnUsers { get; set; }
    }
}
