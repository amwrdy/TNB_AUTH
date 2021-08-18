﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class NewConnectionContractor
    {
        public long Id { get; set; }
        public int NewConnectionId { get; set; }
        public Guid ContractorId { get; set; }
        public int StatusId { get; set; }
        public string RejectReason { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Contractor Contractor { get; set; }
        public virtual NewConnection NewConnection { get; set; }
        public virtual ApplicationStatus Status { get; set; }
    }
}
