using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class TrnUserSession
    {
        public Guid SessionId { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
        public string Signature { get; set; }
        public string Ipaddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
