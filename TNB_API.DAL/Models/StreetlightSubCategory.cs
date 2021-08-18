using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class StreetlightSubCategory
    {
        public int PremiseTypeHeaderId { get; set; }
        public string PremiseTypeItemCode { get; set; }
        public string StreetlightSubCategoryCode { get; set; }
        public string StreetlightSubCategoryDesc { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public int? Sequence { get; set; }
    }
}
