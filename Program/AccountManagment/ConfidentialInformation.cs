using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PPPI_LR2_MODULES
{
    [DataContract]
    public class ConfidentialInformation
    {
        [JsonConstructor]
        public ConfidentialInformation(
            bool visibilityPhone = false, 
            bool visibilityOnline = false, 
            WhoSendMe communicationWithMe = default, 
            bool visibilityContacts = false){

            VisibilityPhone = visibilityPhone;
            VisibilityOnline = visibilityOnline;
            CommunicationWithMe = communicationWithMe;
            VisibilityContacts = visibilityContacts;
        }
        public enum WhoSendMe 
        {
            OnlyContacts,
            All,
            None
        }

        [DataMember]
        public bool VisibilityPhone { get; set; }

        [DataMember]
        public bool VisibilityOnline { get; set; }

        [DataMember]
        public WhoSendMe CommunicationWithMe { get; set; }

        [DataMember]
        public bool VisibilityContacts { get; set; }
    }
}