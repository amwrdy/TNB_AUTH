﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ChannelSecurity
    {
        public Guid ChannelSecurityId { get; set; }
        public string ChannelKey { get; set; }
        public string EncryptionKey { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
