using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class BulkPrintingFile
    {
        public Guid BulkPrintingFileId { get; set; }
        public DateTime? StartExecuteDate { get; set; }
        public DateTime? EndExecuteDate { get; set; }
        public int? TotalExecuted { get; set; }
        public int? SuccessExecuted { get; set; }
        public int? FailedExecuted { get; set; }
        public short? StatusId { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
