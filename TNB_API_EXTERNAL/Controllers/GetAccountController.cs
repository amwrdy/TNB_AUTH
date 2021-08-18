using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TNB_API_EXTERNAL.Models;
using TNB_API_EXTERNAL.Models.AccountManagement;
using TNB_API.Enum;
using TNB_API.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace TNB_API_EXTERNAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAccountController : ControllerBase
    {

        [HttpPost]
        public List<modelView> GetAccount(string userId)
        {
            //InBoundWebServiceLogger.LogInBoundWebServiceCall(Convert.ToBoolean(Convert.ToInt32(ConfigurationManager.AppSettings["EnableWebServiceLog"])), "SSP_MyTNB_GetAccount", "GetAccount", userId);
            List<modelView> result = new List<modelView>();
            try
            {
                // Validation
                Guid guidUserId = Guid.Parse(userId);
                //if (string.IsNullOrEmpty(userId))
                //    return new GetAccountResponse()
                //    {
                //        Header = new ResponseHeader()
                //        {
                //            StatusCode = (int)InBoundStatusCode.PreconditionFailed,
                //            StatusDescription = "Insufficient parameters is passed."
                //        }
                //    };
                //if (!Guid.TryParse(userId, out guidUserId))
                //    return new GetAccountResponse()
                //    {
                //        Header = new ResponseHeader()
                //        {
                //            StatusCode = (int)InBoundStatusCode.PreconditionFailed,
                //            StatusDescription = "Invalid parameters is passed."
                //        }
                //    };

                // Operation

                //List<TrnAccount> trnAccounts;

                
                //List<modelView> vm = new List<modelView>();
                using (var db2 = new SSPDBContext())
                {
                    var vm = (from a in db2.TrnAccounts
                            join b in db2.NewConnections on a.UserId equals b.UserId
                            join c in db2.PremiseTypeHeaders on b.PremiseTypeHeaderId equals c.PremiseTypeHeaderId
                            where a.UserId == guidUserId && a.AccountNumber == b.ContractAccountNo
                            select new modelView()
                            {
                                AccountNumber = a.AccountNumber,
                                PremiseAddress = a.PremiseAddress,
                                MobileNo = a.MobileNo,
                                IsOwnedAccount = a.IsOwnedAccount,
                                AccountTypeID = a.AccountTypeId,
                                UserID = a.UserId,
                                AccountDescription = a.AccountDescription,
                                IdentificationNo = a.IdentificationNo,
                                PremiseTypeHeaderId = b.PremiseTypeHeaderId,
                                PremiseDesc = c.PremiseDesc
                            }).ToList();


                    if (vm != null)
                    {
                        foreach (var account in vm)
                        {
                            modelView modelView1 = new modelView();
                            modelView1.AccountDescription = account.AccountDescription;
                            modelView1.AccountNumber = account.AccountNumber;
                            modelView1.AccountTypeID = account.AccountTypeID;
                            modelView1.IdentificationNo = account.IdentificationNo;
                            modelView1.IsOwnedAccount = account.IsOwnedAccount;
                            modelView1.MobileNo = account.MobileNo;
                            modelView1.PremiseAddress = account.PremiseAddress;
                            modelView1.PremiseDesc = account.PremiseDesc;
                            modelView1.PremiseTypeHeaderId = account.PremiseTypeHeaderId;
                            modelView1.UserID = account.UserID;
                            result.Add(modelView1);
                        }
                    }
                }


                   

                //using (var db = new SSPDBContext())


                //List<ResponseBody_NewConnections> body = new List<ResponseBody_NewConnections>();
                
                
                //    body.Add(new ResponseBody_NewConnections(account.PremiseDesc));
                

                //return new GetAccountResponse()
                //{
                //    Header = new ResponseHeader()
                //    {
                //        StatusCode = (int)InBoundStatusCode.Success,
                //        StatusDescription = "Get account is successful."
                //    },
                //    Body_newConnections = body

                //};
            }
            catch (Exception)
            {
                //return new GetAccountResponse()
                //{
                //    Header = new ResponseHeader()
                //    {
                //        StatusCode = (int)InBoundStatusCode.InternalFailed,
                //        StatusDescription = "The server encountered an error and could not complete your request."
                //    }
                //};
            }
            return result;
        }
    }
}
