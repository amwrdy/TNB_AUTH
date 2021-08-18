using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class RewiringApplicationStatus
    {
        public int ApplicationStatusId { get; set; }
        public int RewiringId { get; set; }
        public int? StatusId { get; set; }
        public string StatusCode { get; set; }
        public string StatusText { get; set; }
        public string DisplayText { get; set; }
        public DateTime StatusDate { get; set; }
        public string StatusFor { get; set; }
        public bool IsDisplayableStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual Rewiring Rewiring { get; set; }
    }
}
