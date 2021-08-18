using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class NewConnectionApprovalInformation
    {
        public int NewConnectionApprovalId { get; set; }
        public int NewConnectionId { get; set; }
        public string Bpno { get; set; }
        public string ContactBpno { get; set; }
        public bool? Bprelationship { get; set; }
        public string CaNo { get; set; }
        public bool? Bpid { get; set; }
        public string Srno { get; set; }
        public string Snno { get; set; }
        public string Sdamount { get; set; }
        public string Ccamount { get; set; }
        public string StampDuty { get; set; }
        public string ProformaInvoice { get; set; }
        public string ProcessingFee { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string Tmdstatus { get; set; }
        public string TmdworkFlow { get; set; }
        public string ApprovalStatus { get; set; }
        public int? ApprovedAgeing { get; set; }
        public string PremiseNo { get; set; }

        public virtual NewConnection NewConnection { get; set; }
    }
}
