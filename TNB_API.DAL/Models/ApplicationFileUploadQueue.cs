using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class ApplicationFileUploadQueue
    {
        public Guid FileQueueId { get; set; }
        public string FileId { get; set; }
        public string DestinationInd { get; set; }
        public string ReferenceNo { get; set; }
        public string ReferenceType { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public byte[] FileBinary { get; set; }
        public string FileServerPath { get; set; }
        public bool? FileIsReadOnly { get; set; }
        public string UploadStatus { get; set; }
        public byte? NoOfTry { get; set; }
        public DateTime? NextTryDate { get; set; }
        public bool IsSent { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string FileGroupId { get; set; }
        public bool? Deleted { get; set; }
    }
}
