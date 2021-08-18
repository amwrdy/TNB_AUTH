using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class NewConnectionSubmitSystemMessage
    {
        public int NcsubmitSysMsgId { get; set; }
        public int NewConnectionId { get; set; }
        public string MessageType { get; set; }
        public string Message { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual NewConnection NewConnection { get; set; }
    }
}
