using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TNB_API_EXTERNAL.Models;
using TNB_API_EXTERNAL.Models.AccountManagement;
using TNB_API.Enum;
using TNB_API.Core.Security;
using TNB_API.DAL.Models;

namespace TNB_API_EXTERNAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public LoginResponse Login(string eMail, string password)
        {
            //InBoundWebServiceLogger.LogInBoundWebServiceCall(Convert.ToBoolean(Convert.ToInt32(ConfigurationManager.AppSettings["EnableWebServiceLog"])), "SSP_MyTNB_Login", "Login", eMail, password);

            try
            {
                // Validation
                if (string.IsNullOrEmpty(eMail) || string.IsNullOrEmpty(password))
                    return new LoginResponse()
                    {
                        Header = new ResponseHeader()
                        {
                            StatusCode = (int)InBoundStatusCode.PreconditionFailed,
                            StatusDescription = "Insufficient parameters is passed."
                        }
                    };

                // Operation
                var user = new User(eMail);
                IPasswordHash passwordHash = new PasswordHash();
                TrnUser trnUser;
                List<LnkUserRole> roles;

                if (!user.IsValid(passwordHash, password))
                {
                    var tempKeyStatus = user.IsTempKeyValid(passwordHash, password);
                    if (tempKeyStatus == TempKeyStatus.Expired)
                        return new LoginResponse()
                        {
                            Header = new ResponseHeader()
                            {
                                StatusCode = (int)InBoundStatusCode.Failed,
                                StatusDescription = "TempKey is expired."
                            }
                        };
                    if (tempKeyStatus == TempKeyStatus.Unmatched)
                        return new LoginResponse()
                        {
                            Header = new ResponseHeader()
                            {
                                StatusCode = (int)InBoundStatusCode.Failed,
                                StatusDescription = "Invalid username or password."
                            }
                        };

                    using (var db = new SSPDBContext())
                        trnUser = db.TrnUsers.Single(e => e.UserName == eMail && e.IsDeleted == false);
                    return new LoginResponse()
                    {
                        Header = new ResponseHeader()
                        {
                            StatusCode = (int)InBoundStatusCode.ActionRequired,
                            StatusDescription = "Login is successful using TempKey with requirement to change password."
                        },
                        Body = new ResponseBody_TrnUser(trnUser)
                    };
                }

                using (var db = new SSPDBContext())
                {
                    trnUser = db.TrnUsers.Single(e => e.UserName == eMail && e.IsDeleted == false);
                    roles = db.LnkUserRoles.Where(e => e.UserId == trnUser.UserId).ToList();
                }

                if (!trnUser.IsActivated)
                    return new LoginResponse()
                    {
                        Header = new ResponseHeader()
                        {
                            StatusCode = (int)InBoundStatusCode.Failed,
                            StatusDescription = "User is not activated."
                        }
                    };

                if (roles.Count > 0 && roles.Where(e => e.RoleId == 16 || e.RoleId == 2).ToList().Count == 0)
                    return new LoginResponse()
                    {
                        Header = new ResponseHeader()
                        {
                            StatusCode = (int)InBoundStatusCode.Failed,
                            StatusDescription = "User is unauthorised."
                        }
                    };

                using (var db = new SSPDBContext())
                {
                    db.TrnUsers.Single(e => e.UserName == eMail && e.IsDeleted == false).LastLoginFromMobile = DateTime.Now;
                    db.SaveChanges();
                }
                return new LoginResponse()
                {
                    Header = new ResponseHeader()
                    {
                        StatusCode = (int)InBoundStatusCode.Success,
                        StatusDescription = "Login is successful."
                    },
                    Body = new ResponseBody_TrnUser(trnUser)
                };
            }
            catch (Exception)
            {
                return new LoginResponse()
                {
                    Header = new ResponseHeader()
                    {
                        StatusCode = (int)InBoundStatusCode.InternalFailed,
                        StatusDescription = "The server encountered an error and could not complete your request."
                    }
                };
            }
        }
    }
}
