using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class FileDownload
    {
        public int FileId { get; set; }
        public string FileGroupName { get; set; }
        public string FileGroupDescription { get; set; }
        public string FileName { get; set; }
        public string FileDescription { get; set; }
        public string FileType { get; set; }
        public string FileSource { get; set; }
        public string FileButtonDescription { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
