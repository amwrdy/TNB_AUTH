using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TNB_API.DAL.Models;

namespace TNB_API_EXTERNAL.Models.AccountManagement
{
    public class ResponseBody_NewConnections
    {
        public ResponseBody_NewConnections()
        {
        }

        public ResponseBody_NewConnections(NewConnection newConnection)
        {
            PremiseTypeHeaderId = newConnection.PremiseTypeHeaderId;
        }
        public int? PremiseTypeHeaderId { get; set; }
    }
}
