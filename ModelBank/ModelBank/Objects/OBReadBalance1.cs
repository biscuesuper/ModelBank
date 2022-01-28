using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBReadBalance1
    {
        [DataMember]
        public OBReadDataBalance1 Data;
    }
}
