using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PPPI_LR2_MODULES
{
    [DataContract]
    public class NotificationModel
    {
        [JsonConstructor]
        public NotificationModel(string message = null, string sender = null, DateTime date = default)
        {
            Message = message;
            Sender = sender;
            Date = date;
        }

        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Sender { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
    }
}