using ModelBank.Resources.Enums;
using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBReadDataConsentResponse1
    {
        public OBReadDataConsentResponse1()
        {

        }

        [DataMember]
        public string ConsentId { get; set; }

        [DataMember]
        public string CreationDateTime { get; set; }

        [DataMember]
        public OBExternalRequestStatus1Code Status { get; set; }

        [DataMember]
        public string StatusUpdateDateTime { get; set; }

        [DataMember]
        public ICollection<string> Permissions { get; set; } = new List<string>();

        [DataMember]
        public string? ExpirationDateTime { get; set; }

        [DataMember]
        public string? TransactionFromDateTime { get; set; }

        [DataMember]
        public string? TransactionToDateTime { get; set; }
    }
}