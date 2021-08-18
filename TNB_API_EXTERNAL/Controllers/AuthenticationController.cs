using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TNB_API.DAL.DataModels;
using System.Text;
using TNB_API_EXTERNAL.Models.AccountManagement;
using TNB_API.Enum;
using TNB_API.Core.Security;
using TNB_API.DAL.Models;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace TNB_API_EXTERNAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IConfiguration _config;

        public AuthenticationController(IConfiguration Confiq)
        {
            _config = Confiq;
        }

        [HttpPost("login")]
        public IActionResult Login(ServiceModels.AuthenticationModel request)
        {
            var username = request.Username;
            var password = request.Password;
            var result = ValidateLogin(request.Username, request.Password);

            IActionResult response = Unauthorized();
            //var profiles = _config.GetSection("Subscribers").Get<Subscribers>();
            
            var user = new User(request.Username);
            IPasswordHash passwordHash = new PasswordHash();
            
            if (user.IsValid(passwordHash, request.Password))
            {
                var subscriber = new SubscriberModel
                {
                    SubscriberID = user.UserID,
                    Password = request.Password,
                    Username = request.Username,
                    SubscriberName = user.Name
                };
                var jwToken = GenerateJsonWebToken(subscriber);
                response = Ok(new
                {
                    statusCode = result.Header.StatusCode,
                    statusDescription = result.Header.StatusDescription,
                    UserId = user.UserID,
                    UserName = user.UserName,
                    Name = user.Name,
                    EmailAddress = user.Email,
                    Token = jwToken,
                    TokenExpires = DateTime.Now.AddMinutes(string.IsNullOrEmpty(_config["JWT:ExpiresInMin"].ToString()) ? 60 : int.Parse(_config["JWT:ExpiresInMin"].ToString())).ToString("yyyy-MM-dd HH:mm:ss")
                });
            }
            else if (!user.IsValid(passwordHash, request.Password))
            {
                response = Ok(new
                {
                    statusCode = result.Header.StatusCode,
                    statusDescription = result.Header.StatusDescription,
                    
                });
            }


            return response;
        }

        private string GenerateJsonWebToken(SubscriberModel subscriber)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Key"]));
            var credential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, subscriber.Username),
                new Claim(JwtRegisteredClaimNames.UniqueName, subscriber.SubscriberName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                    issuer: _config["JWT:Issuer"],
                    audience: _config["JWT:Audience"],
                    claims,
                    expires: DateTime.Now.AddMinutes(string.IsNullOrEmpty(_config["JWT:ExpiresInMin"].ToString()) ? 60 : int.Parse(_config["JWT:ExpiresInMin"].ToString())),
                    signingCredentials: credential
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private LoginResponse ValidateLogin(string username, string password)
        {
            try
            {
                // Validation
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    return new LoginResponse()
                    {
                        Header = new ResponseHeader()
                        {
                            StatusCode = (int)InBoundStatusCode.PreconditionFailed,
                            StatusDescription = "Insufficient parameters is passed."
                        }
                    };

                // Operation
                var user = new User(username);
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
                        trnUser = db.TrnUsers.Single(e => e.UserName == username && e.IsDeleted == false);
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
                    trnUser = db.TrnUsers.Single(e => e.UserName == username && e.IsDeleted == false);
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
                    db.TrnUsers.Single(e => e.UserName == username && e.IsDeleted == false).LastLoginFromMobile = DateTime.Now;
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
