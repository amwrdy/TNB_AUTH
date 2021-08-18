using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class MigProjectParcelUpdateOnRequest
    {
        public int Id { get; set; }
        public string ReferenceNo { get; set; }
        public string TnbprojectId { get; set; }
        public string TotalNumberofUnits { get; set; }
        public string ParcelDescription { get; set; }
        public string Action { get; set; }
        public string NumberofUnits { get; set; }
        public string MaterialDescription { get; set; }
        public string VoltageLevel { get; set; }
        public string MeterType { get; set; }
        public string Mdload { get; set; }
        public string Tnbstation { get; set; }
        public string TnbstationCode { get; set; }
        public string Remark { get; set; }
        public string SspparcelId { get; set; }
        public string MigrationStatus { get; set; }
        public int? LoadLineage { get; set; }
        public DateTime? LoadDate { get; set; }
    }
}
