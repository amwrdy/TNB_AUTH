using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class BulkPayLotFileUploadLog
    {
        public int FileNo { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileServerPath { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
