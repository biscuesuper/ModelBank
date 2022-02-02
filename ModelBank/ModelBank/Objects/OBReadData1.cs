using ModelBank.Resources.Enums;
using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBReadData1
    {
        public OBReadData1()
        {

        }

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