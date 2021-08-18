using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TNB_API_EXTERNAL.Controllers;

namespace TNB_API_EXTERNAL.Models.AccountManagement
{
    public class GetAccountResponse
    {
        public ResponseHeader Header { get; set; }
        public List<ResponseBody_TrnAccount> Body_account { get; set; }
        public List<ResponseBody_TrnUser> Body_user { get; set; }
        public List<ResponseBody_NewConnections> Body_newConnections { get; set; }
    }
}
