using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Sspnotification
    {
        public Guid NotificationId { get; set; }
        public string AccountNumber { get; set; }
        public string ApplicationModuleId { get; set; }
        public int? ApplicationNumber { get; set; }
        public Guid? UserId { get; set; }
        public string TemplateId { get; set; }
        public string NotificationDescription { get; set; }
        public string NotificationText { get; set; }
        public bool IsRead { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual TrnUser User { get; set; }
    }
}
