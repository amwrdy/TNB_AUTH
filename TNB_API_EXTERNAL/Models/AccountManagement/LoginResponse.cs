using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TNB_API_EXTERNAL.Models.AccountManagement
{
    public class LoginResponse
    {
        public ResponseHeader Header { get; set; }
        public ResponseBody_TrnUser Body { get; set; }
    }
}
