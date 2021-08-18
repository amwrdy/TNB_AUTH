using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNB_API_EXTERNAL.DataModels
{
    public class GlobalSettingsModel
    {
        public Request Request { get; set; }
        public NotificationService NotificationService { get; set; }
        public SendToCloudMessagingConfigs SendToCloudMessagingConfigs { get; set; }
        public SendToMailTransferServiceConfig SendToMailTransferServiceConfig { get; set; }
        public SendToShortMessageServiceConfigs SendToShortMessageServiceConfigs { get; set; }
        public ConnectionString ConnectionString { get; set; }
        public Subscribers Subscribers { get; set; }
    }

    public class Subscribers
    {
        public List<Subscriber> Subscriber { get; set; }
    }

    public class Subscriber
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string SubscriberID { get; set; }
        public string SubscriberName { get; set; }
        public bool IsActive { get; set; }
        public bool AllowSendToInApps { get; set; }
        public bool AllowSendToCloudMessaging { get; set; }
        public bool AllowSendToMailTransferService { get; set; }
        public bool AllowSendToShortMessageService { get; set; }
    }

    public class ConnectionString
    {
        public string MyTNB { get; set; }
    }

    public class Request
    {
        public int MaxBatchRequest { get; set; }
    }

    public class NotificationService
    {
        public bool SendToInApps { get; set; }
        public bool SendToCloudMessaging { get; set; }
        public bool SendToMailTransferService { get; set; }
        public bool SendToShortMessageService { get; set; }
    }

    public class SendToCloudMessagingConfigs
    {
        public string HuaweiClientId { get; set; }
        public string HuaweiClientSecret { get; set; }
        public string ApiKey { get; set; }
    }

    public class SendToMailTransferServiceConfig
    {
        public string SmtpHost { get; set; }
        public string SmtpPort { get; set; }
        public string SmtpFrom { get; set; }
    }


    public class SendToShortMessageServiceConfigs
    {
        public string SmsEndpoint { get; set; }
        public string SmsServiceId { get; set; }
        public string SmsUsername { get; set; }
        public string SmsPassword { get; set; }
        public string SenderDisplayName { get; set; }
        public string IsTestMode { get; set; }
        public string TestModeRecipient { get; set; }
    }
}
