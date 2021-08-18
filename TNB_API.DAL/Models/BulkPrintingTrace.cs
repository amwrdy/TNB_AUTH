using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class BulkPrintingTrace
    {
        public long BulkPrintingTraceId { get; set; }
        public Guid BulkPrintingFileId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
