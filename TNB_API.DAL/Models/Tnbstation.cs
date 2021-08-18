using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class Tnbstation
    {
        public int StationId { get; set; }
        public int? StationCode { get; set; }
        public string Description { get; set; }
        public string HouseNo { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string TelephoneNo { get; set; }
        public string FaxNo { get; set; }
        public string StationName { get; set; }
        public int? StateId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string ContactNo { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string BorderRegion { get; set; }
        public string ProjectPlannerEmail { get; set; }

        public virtual State State { get; set; }
    }
}
