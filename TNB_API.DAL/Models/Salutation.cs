using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Salutation
    {
        public Salutation()
        {
            TrnUsers = new HashSet<TrnUser>();
        }

        public int SalutationId { get; set; }
        public string SalutationDesc { get; set; }
        public string ReferenceCode { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<TrnUser> TrnUsers { get; set; }
    }
}
