using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TNB_API.DAL.Models;

namespace TNB_API_EXTERNAL.Models.AccountManagement
{
    public class ResponseBody_TrnAccount
    {
        public ResponseBody_TrnAccount()
        {
        }

        public ResponseBody_TrnAccount(TrnAccount trnAccount)
        {
            AccountNumber = trnAccount.AccountNumber;
            PremiseAddress = trnAccount.PremiseAddress;
            //State = trnAccount.State;
            //City = trnAccount.City;
            //Postcode = trnAccount.Postcode;
            //ContactNo = trnAccount.ContactNo;
            MobileNo = trnAccount.MobileNo;
            IsOwnedAccount = trnAccount.IsOwnedAccount;
            AccountTypeID = trnAccount.AccountTypeId;
            UserID = trnAccount.UserId;
            //OwnerName = trnAccount.OwnerName;
            AccountDescription = trnAccount.AccountDescription;
            //AccountCategoryID = trnAccount.AccountCategoryId;
            //AMSID = trnAccount.Amsid; //myTNB new requirements isSmartMeter
            IdentificationNo = trnAccount.IdentificationNo;
        }

        //public string AMSID { get; set; } //myTNB new requirements isSmartMeter

        //public Guid AccountID { get; set; }

        public int? AccountTypeID { get; set; }

        public string AccountNumber { get; set; }

        //public int? IdentificationType { get; set; }

        //public string IdentificationNo { get; set; }

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
    }
}
