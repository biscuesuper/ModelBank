using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBReadAccount6
    {
        public OBReadAccount6()
        {

        }

        [DataMember]
        public OBReadDataAccount5 Data { get; set; }
    }
}
