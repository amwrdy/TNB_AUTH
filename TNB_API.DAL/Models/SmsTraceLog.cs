using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class SmsTraceLog
    {
        public Guid SmsTraceLogId { get; set; }
        public string Url { get; set; }
        public short? SourceId { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string CharType { get; set; }
        public string RequestBody { get; set; }
        public string ResponseBody { get; set; }
        public string ResponseStatus { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
