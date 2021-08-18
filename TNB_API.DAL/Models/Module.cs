using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Module
    {
        public Module()
        {
            ModuleItems = new HashSet<ModuleItem>();
            SubModules = new HashSet<SubModule>();
        }

        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDesc { get; set; }
        public string ActionName { get; set; }
        public string Controller { get; set; }
        public string Area { get; set; }
        public string ImagePath { get; set; }
        public int? SequenceModule { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<ModuleItem> ModuleItems { get; set; }
        public virtual ICollection<SubModule> SubModules { get; set; }
    }
}
