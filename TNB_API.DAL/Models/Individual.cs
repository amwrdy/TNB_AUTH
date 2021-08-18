using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Individual
    {
        public Guid IndividualId { get; set; }
        public Guid? UserId { get; set; }
        public int? IdentificationType { get; set; }
        public string IdentificationNo { get; set; }
        public DateTime? Dob { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        public string MaidenName { get; set; }
        public string KinName { get; set; }
        public string KinContactNo { get; set; }
        public int? CommId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual TrnUser User { get; set; }
    }
}
