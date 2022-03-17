using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBReadBalance1
    {
        public OBReadBalance1()
        {

        }

        [DataMember]
        public OBReadDataBalance1 Data { get; set; }
    }
}
