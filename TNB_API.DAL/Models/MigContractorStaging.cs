using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigContractorStaging
    {
        public Guid? ContractorId { get; set; }
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
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public int? Id { get; set; }
        public int? LoadLineage { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
