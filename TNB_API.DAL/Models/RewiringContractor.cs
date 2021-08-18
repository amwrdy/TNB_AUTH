using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class RewiringContractor
    {
        public long Id { get; set; }
        public int RewiringId { get; set; }
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
        public virtual Rewiring Rewiring { get; set; }
    }
}
