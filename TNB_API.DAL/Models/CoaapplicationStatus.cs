using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class CoaapplicationStatus
    {
        public int ApplicationStatusId { get; set; }
        public int Coaid { get; set; }
        public int? StatusId { get; set; }
        public string StatusCode { get; set; }
        public string StatusText { get; set; }
        public string DisplayText { get; set; }
        public DateTime StatusDate { get; set; }
        public string StatusFor { get; set; }
        public bool IsDisplayableStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual Coaapplication Coa { get; set; }
        public virtual ApplicationStatus Status { get; set; }
    }
}
