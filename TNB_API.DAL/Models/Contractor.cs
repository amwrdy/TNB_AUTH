using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Contractor
    {
        public Contractor()
        {
            NewConnectionContractors = new HashSet<NewConnectionContractor>();
            RewiringContractors = new HashSet<RewiringContractor>();
        }

        public Guid ContractorId { get; set; }
        public Guid? UserId { get; set; }
        public string Rocno { get; set; }
        public long? StcontractorId { get; set; }
        public string OfficeNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonEmail { get; set; }
        public string ContactPersonPhoneNo { get; set; }
        public string ContactPersonOtherPhoneNo { get; set; }
        public decimal? ContractorRating { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Stcontractor Stcontractor { get; set; }
        public virtual TrnUser User { get; set; }
        public virtual ICollection<NewConnectionContractor> NewConnectionContractors { get; set; }
        public virtual ICollection<RewiringContractor> RewiringContractors { get; set; }
    }
}
