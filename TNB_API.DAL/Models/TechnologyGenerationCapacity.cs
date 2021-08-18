﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class TechnologyGenerationCapacity
    {
        public int TechGenCapacityId { get; set; }
        public int TechSubCategoryId { get; set; }
        public string GenerationCapacityCode { get; set; }
        public string GenerationCapacity { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string RefCode { get; set; }

        public virtual TechnologySubCategory TechSubCategory { get; set; }
    }
}
