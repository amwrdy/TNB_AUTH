using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNB_API.DAL.DataModels
{
    public class SubscriberModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Guid SubscriberID { get; set; }
        public string SubscriberName { get; set; }
        public bool IsActive { get; set; }
    }

    public class Subscribers
    {
        public List<SubscriberModel> Subscriber { get; set; }
    }
}
