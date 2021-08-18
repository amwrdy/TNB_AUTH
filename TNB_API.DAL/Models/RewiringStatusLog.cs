﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class RewiringStatusLog
    {
        public Guid Guid { get; set; }
        public int? RewiringId { get; set; }
        public short? StatusId { get; set; }
        public short? SrStatus { get; set; }
        public short? SnStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
