using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigSrstatusDateSyncTemp
    {
        public string TransType { get; set; }
        public string ServiceRequestNo { get; set; }
        public string StatusCode { get; set; }
        public string ChangedDate { get; set; }
        public string ChangedTime { get; set; }
        public string MyTnbapplicationNo { get; set; }
        public string Cat1 { get; set; }
        public string Cat2 { get; set; }
        public string Cat3 { get; set; }
        public string Cat4 { get; set; }
        public string MeterIndicator { get; set; }
        public string VoltageLevel { get; set; }
        public string ExpressIndicator { get; set; }
        public string MeterReplacement { get; set; }
        public string TableName { get; set; }
        public int? MyTnbapplicationId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ChangedDateTime { get; set; }
    }
}
