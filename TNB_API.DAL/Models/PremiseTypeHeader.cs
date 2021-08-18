using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class PremiseTypeHeader
    {
        public PremiseTypeHeader()
        {
            PremiseTypeItems = new HashSet<PremiseTypeItem>();
        }

        public int PremiseTypeHeaderId { get; set; }
        public string PremiseDesc { get; set; }
        public string AdId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<PremiseTypeItem> PremiseTypeItems { get; set; }
    }
}
