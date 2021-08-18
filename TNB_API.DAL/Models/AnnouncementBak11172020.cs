using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class AnnouncementBak11172020
    {
        public Guid AnnouncementId { get; set; }
        public string AnnouncementTitle { get; set; }
        public string AnnouncementMessage { get; set; }
        public string AnnouncementIntro { get; set; }
        public string ViewBy { get; set; }
        public DateTime? PublishFromDateTime { get; set; }
        public DateTime? PublishToDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
