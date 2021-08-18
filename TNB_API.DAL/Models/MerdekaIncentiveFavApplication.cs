using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MerdekaIncentiveFavApplication
    {
        public Guid FavAppId { get; set; }
        public int? ApplicationId { get; set; }
        public string ModuleName { get; set; }
        public Guid? BackendAppId { get; set; }
        public Guid UserId { get; set; }
        public int RoleId { get; set; }
        public bool IsOwnApplication { get; set; }
        public string Channel { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
