using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNB_API.Enum;
using TNB_API.DAL.Models;
using System.Security.Principal;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace TNB_API.Core.Security
{
    public class User
    {
        private TrnUser _loggedInUser;

        public Guid UserID { get { return _loggedInUser != null ? _loggedInUser.UserId : Guid.Empty; } }
        public string Careline { get { return "Please call TNB CareLine at 1-300-88-5454 if you have any questions."; } }
        public string UserName { get { return _loggedInUser != null ? _loggedInUser.UserName : null; } }
        //public string Password { get { return _loggedInUser != null ? _loggedInUser.UserPassword : null; } }
        public string Name { get { return _loggedInUser != null ? _loggedInUser.Name : null; } }
        public string MobileNo { get { return _loggedInUser != null ? _loggedInUser.MobileNo : null; } }
        public int? IdentificationType { get { return _loggedInUser != null ? _loggedInUser.IdentificationType : null; } }
        public string IdentificationNo { get { return _loggedInUser != null ? _loggedInUser.IdentificationNo : null; } }
        public string Email { get { return _loggedInUser != null ? _loggedInUser.Email : null; } }

        //public string CollectiveContractAccountNo { get { return _loggedInUser != null && Roles.Contains(UserRoleCode.BulkPaymentUser) ? _loggedInUser.BulkPaymentUsers.FirstOrDefault().CollectiveContractAccountNo : null; } }
        //Email
        public List<UserRoleCode> Roles { get { return _loggedInUser != null ? _loggedInUser.LnkUserRoles.Select(e => (UserRoleCode)e.RoleId).ToList() : null; } }
        public UserRoleCode CurrentRole { get; set; }
        public string SelectedCA { get; set; }
        public string SelectedCAID { get; set; }
        public bool HasUnreadApplications { get; set; }

        public string CurrentRoleDescription
        {
            get
            {
                if ((int)CurrentRole <= 0)
                    return "";

                string currentRoleDescription = SSPRoles.Single(m => m.RoleId == (int)CurrentRole).RoleDescription;

                return currentRoleDescription != null ? $"{currentRoleDescription}, " : "";
            }
        }

        public List<Module> Modules
        {
            get
            {
                if (_loggedInUser == null)
                    return new List<Module>();

                return SubModules
                       .Where(e => e.RoleId == (int)CurrentRole && e.SubModule.Module.SequenceModule != null && e.SubModule.Module.SequenceModule.Value != 0)
                       .Select(e => e.SubModule.Module)
                       .Distinct()
                       .OrderBy(e => e.SequenceModule)
                       .ToList();
            }
        }

        public List<TrnSubModuleRole> SubModules { get; private set; }
        //public List<TrnRoleFunctionControl> FunctionControls { get; private set; }
        protected List<Ssprole> SSPRoles { get; private set; }

        public bool IsRememberMe { get; private set; }
        public bool IsAuthenticated { get; private set; }

        public bool IsAdmin { get; set; }

        

        public User()
        {
            //Modules = new List<Module>();
            SubModules = new List<TrnSubModuleRole>();
            //FunctionControls = new List<TrnRoleFunctionControl>();
        }

        public User(string userName) : this()
        {
            if (String.IsNullOrEmpty(userName))
                throw new ArgumentOutOfRangeException("UserName is not set properly");

            RefreshSession(userName);
        }

        public User(IIdentity identity) : this(identity.Name, true)
        {
            IsAuthenticated = identity.IsAuthenticated;
        }

        public User(string userName, bool isRememberMe) : this(userName)
        {
            IsRememberMe = isRememberMe;
        }

        public void RefreshSession(string userName)
        {
            using (var db = new SSPDBContext())
            {
                _loggedInUser = db.TrnUsers
                                .Include(e => e.LnkUserRoles)
                                //.Include(e => e.BulkPaymentUsers)
                                .SingleOrDefault(e => e.UserName == userName && e.IsDeleted == false && e.IsActivated == true);
                if (_loggedInUser != null)
                {
                    SubModules = new List<TrnSubModuleRole>();
                    foreach (var role in _loggedInUser.LnkUserRoles)
                        SubModules.AddRange(db.TrnSubModuleRoles
                                              .Include(e => e.SubModule)
                                              .Include(e => e.SubModule.Module)
                                              .Where(e => e.RoleId == role.RoleId && e.IsDeleted == false && (e.Access & (int)UserActions.Read) == (int)UserActions.Read));

                    var roles = _loggedInUser.LnkUserRoles.Select(e => e.RoleId).ToList();
                    SSPRoles = db.Ssproles.Where(e => roles.Contains(e.RoleId)).ToList();
                    var userStatus = _loggedInUser.IsActivated;
                    //Modules = SubModules
                    //          .Select(e => e.SubModule.Module)
                    //          .Distinct()
                    //          .OrderBy(e => e.SequenceModule)
                    //          .ToList();

                    //_trnRoleFunctionControl = db.TrnRoleFunctionControl
                    //    .Include(e => e.FunctionControl)
                    //    .Where(e => e.RoleID == 2)
                    //    .ToList();
                }
            }
        }

        public bool CheckPassword(IPasswordHash PasswordHash, string password)
        {
            return _loggedInUser != null && PasswordHash.ValidatePassword(password, _loggedInUser.UserPassword);
        }

        public bool IsValid(IPasswordHash PasswordHash, string password)
        {
            IsAuthenticated = CheckPassword(PasswordHash, password);
            return IsAuthenticated;
        }

        public void AuthenticateByCookie(bool valid)
        {
            IsAuthenticated = valid;
        }

        public TempKeyStatus IsTempKeyValid(IPasswordHash passwordHash, string tempKey)
        {
            if (_loggedInUser == null)
                return TempKeyStatus.Unmatched;
            //PwdManagement key;
            using (var db = new SSPDBContext())
            {
                var key = db.PwdManagements
                        .Where(e => e.UserId == _loggedInUser.UserId)
                        .ToList();

                var unMatched = true;
                var expiredDate = true;

                foreach (var items in key)
                {
                    if (passwordHash.ValidatePassword(tempKey, items.TempKey))
                    {
                        unMatched = false;

                        if (items.ExpiryDate > DateTime.Now)
                            expiredDate = false;
                        else
                            expiredDate = true;
                    }
                }

                if (unMatched)
                    return TempKeyStatus.Unmatched;

                if (expiredDate)
                    return TempKeyStatus.Expired;

                // Chris Lui: Checking for SSO, commented assuming to be always SSO
                //if (System.Configuration.ConfigurationManager.AppSettings["IsSSOEnabled"].ToString() == "1")
                //{
                IsAuthenticated = true;
                //}
                return TempKeyStatus.Matched;
            }
            //if (_loggedInUser == null)
            //    return TempKeyStatus.Unmatched;

            //PwdManagement key;
            //using (var db = new TNB_SSP_DBContext())
            //    key = db.PwdManagement
            //          .OrderByDescending(e => e.CreatedDate)
            //          .FirstOrDefault(e => e.UserID == _loggedInUser.UserID);

            //if (key == null || !passwordHash.ValidatePassword(tempKey, key.TempKey))
            //    return TempKeyStatus.Unmatched;
            //if (key.ExpiryDate < DateTime.Now)
            //    return TempKeyStatus.Expired;
            //return TempKeyStatus.Matched;
        }

        
    }
}
