using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ProjectContractor
    {
        public int ContractorId { get; set; }
        public int ProjectId { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string IdentificationNo { get; set; }
        public string FixedLineNo { get; set; }
        public string Building { get; set; }
        public string HouseNo { get; set; }
        public string UnitNo { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PropertyType { get; set; }
        public string FaxNo { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Project Project { get; set; }
    }
}
