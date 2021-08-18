using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class InBoundWebServiceLog
    {
        public int InBoundWebServiceLogId { get; set; }
        public string ServiceName { get; set; }
        public string MethodName { get; set; }
        public string InputParams { get; set; }
        public string UserName { get; set; }
        public string IpAddress { get; set; }
        public int? Port { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
