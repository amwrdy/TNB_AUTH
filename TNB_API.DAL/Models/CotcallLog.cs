﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class CotcallLog
    {
        public int CotcallLogId { get; set; }
        public int Cotid { get; set; }
        public Guid UserId { get; set; }
        public string Remarks { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Cotapplication Cot { get; set; }
        public virtual TrnUser User { get; set; }
    }
}
