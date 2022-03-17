using OBData.Enums;
using System.Runtime.Serialization;

namespace OBData.Objects
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