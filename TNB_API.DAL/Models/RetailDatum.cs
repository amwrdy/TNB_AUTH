﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class RetailDatum
    {
        public Guid RetailDataId { get; set; }
        public Guid? UserId { get; set; }
        public string Email { get; set; }
        public string StateCode { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual TrnUser User { get; set; }
    }
}
