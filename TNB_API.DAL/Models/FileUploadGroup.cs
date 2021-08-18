using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class FileUploadGroup
    {
        public int FileGroupId { get; set; }
        public string FileGroupName { get; set; }
        public string FileGroupDescription { get; set; }
        public string FileCode { get; set; }
        public string FileName { get; set; }
        public string FileDescription { get; set; }
        public string FileType { get; set; }
        public decimal? FileSize { get; set; }
        public string SizeType { get; set; }
        public string FileSource { get; set; }
        public bool Mandatory { get; set; }
        public bool Enabled { get; set; }
        public bool? RestrictedFileName { get; set; }
        public string ToolTip { get; set; }
        public string PopupUrl { get; set; }
        public int? Sequence { get; set; }
    }
}
