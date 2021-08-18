using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ApplicationStatusSync
    {
        public int Id { get; set; }
        public string ReferenceNo { get; set; }
        public string SrNo { get; set; }
        public string SnNo { get; set; }
        public string StatusSap { get; set; }
        public string StatusSsp { get; set; }
        public int? StatusId { get; set; }
        public string ReadFlag { get; set; }
        public string UpdateFlag { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
