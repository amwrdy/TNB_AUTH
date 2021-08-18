using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ModuleItem
    {
        public int ModuleItemId { get; set; }
        public int ModuleId { get; set; }
        public string ModuleItemName { get; set; }
        public string ModuleItemDesc { get; set; }
        public string ActionName { get; set; }
        public string Controller { get; set; }
        public string Area { get; set; }
        public string ImagePath { get; set; }
        public int? SequenceModule { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Module Module { get; set; }
    }
}
