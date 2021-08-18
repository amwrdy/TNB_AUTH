using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class WltysentEmailLog
    {
        public int Id { get; set; }
        public string EmailSentTo { get; set; }
        public DateTime EmailSentOn { get; set; }
        public DateTime NextEmailSendDate { get; set; }
    }
}
