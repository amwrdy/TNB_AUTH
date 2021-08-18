using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TNB_API.DAL.Models;

namespace TNB_API_EXTERNAL.Models.AccountManagement
{
    public class ResponseBody_TrnUser
    {
        public ResponseBody_TrnUser()
        {
        }

        public ResponseBody_TrnUser(TrnUser trnUser)
        {
            UserID = trnUser.UserId;
            UserName = trnUser.UserName;
            //UserPassword = trnUser.UserPassword;
            //Salt = trnUser.Salt;
            //SalutationID = trnUser.SalutationID;
            //IdentificationType = trnUser.IdentificationType;
            IdentificationNo = trnUser.IdentificationNo;
            Name = trnUser.Name;
            //DOB = trnUser.Dob;
            MobileNo = trnUser.MobileNo;
            //FixedLineNo = trnUser.FixedLineNo;
            //FaxNo = trnUser.FaxNo;
            Email = trnUser.Email;
            //MaidenName = trnUser.MaidenName;
            //KinName = trnUser.KinName;
            //KinContactNo = trnUser.KinContactNo;
            //CommID = trnUser.CommID;
            //MailingAddr1 = trnUser.MailingAddr1;
            //MailingAddr2 = trnUser.MailingAddr2;
            //MailingAddr3 = trnUser.MailingAddr3;
            //MailingAddrState = trnUser.MailingAddrState;
            //City = trnUser.City;
            //Postcode = trnUser.Postcode;
            //Country = trnUser.Country;
            //DefaultHomePage = trnUser.DefaultHomePage;
            //IsLockOut = trnUser.IsLockOut;
            //PasswordAttempt = trnUser.PasswordAttempt;
            //RegistrationSource = trnUser.RegistrationSource;
            //LastLoginFromWeb = trnUser.LastLoginFromWeb;
            //LastLoginFromMobile = trnUser.LastLoginFromMobile;
            //IsNotified = trnUser.IsNotified;
            //IsActivated = trnUser.IsActivated;
            //IsDeleted = trnUser.IsDeleted;
            //DeletedDate = trnUser.DeletedDate;
            //CreatedDate = trnUser.CreatedDate;
            //CreatedBy = trnUser.CreatedBy;
            //LastModifiedDate = trnUser.LastModifiedDate;
            //LastModifiedBy = trnUser.LastModifiedBy;
            //isPhoneVerified = trnUser.IsPhoneVerified; //myTNB new requirements isPhoneVerified
        }

        //public bool? isPhoneVerified { get; set; } //myTNB new requirements isPhoneVerified
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        //public string UserPassword { get; set; }
        //public string Salt { get; set; }
        //public int? SalutationID { get; set; }
        //public int? IdentificationType { get; set; }
        public string IdentificationNo { get; set; }
        public string Name { get; set; }
        //public DateTime? DOB { get; set; }
        public string MobileNo { get; set; }
        //public string FixedLineNo { get; set; }
        //public string FaxNo { get; set; }
        public string Email { get; set; }
        //public string MaidenName { get; set; }
        //public string KinName { get; set; }
        //public string KinContactNo { get; set; }
        //public int? CommID { get; set; }
        //public string MailingAddr1 { get; set; }
        //public string MailingAddr2 { get; set; }
        //public string MailingAddr3 { get; set; }
        //public string MailingAddrState { get; set; }
        //public string City { get; set; }
        //public int? Postcode { get; set; }
        //public string Country { get; set; }
        //public int? DefaultHomePage { get; set; }
        //public bool IsLockOut { get; set; }
        //public int? PasswordAttempt { get; set; }
        //public string RegistrationSource { get; set; }
        //public DateTime? LastLoginFromWeb { get; set; }
        //public DateTime? LastLoginFromMobile { get; set; }
        //public bool IsNotified { get; set; }
        //public bool IsActivated { get; set; }
        //public bool IsDeleted { get; set; }
        //public DateTime? DeletedDate { get; set; }
        //public DateTime? CreatedDate { get; set; }
        //public string CreatedBy { get; set; }
        //public DateTime? LastModifiedDate { get; set; }
        //public string LastModifiedBy { get; set; }
    }
}
