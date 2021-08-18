using System;
using System.Collections.Generic;
using TNB_API.DAL.Models;
using TNB_API_EXTERNAL.Models.AccountManagement;

namespace TNB_API_EXTERNAL.Controllers
{
    public class modelView
    {
        public modelView() { }
        public int? AccountTypeID { get; set; }

        public string AccountNumber { get; set; }

        //public int? IdentificationType { get; set; }


        //public int? ROC { get; set; }

        //public string MotherName { get; set; }

        public Guid UserID { get; set; }

        public string PremiseAddress { get; set; }

        //public string State { get; set; }

        //public string City { get; set; }

        //public string Postcode { get; set; }

        //public string ContactNo { get; set; }

        public string MobileNo { get; set; }

        public bool? IsOwnedAccount { get; set; }

        //public string OwnerName { get; set; }

        public string AccountDescription { get; set; }

        //public int? AccountCategoryID { get; set; }

        public string IdentificationNo { get; set; }

        public int? PremiseTypeHeaderId { get; set; }
        public string PremiseDesc { get; set; }
    }
}