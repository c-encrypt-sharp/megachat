using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PPPI_LR2_MODULES
{
    [DataContract]
    public class Contact
    {
        [JsonConstructor]
        public Contact(string name = null, string surname = null, string pageID = null)
        {
            Name = name;
            Surname = surname;
            PageID = pageID;
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public string PageID { get; set; }
        public override int GetHashCode() { throw new NotImplementedException(); }
    }
}