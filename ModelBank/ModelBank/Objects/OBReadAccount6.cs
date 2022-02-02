using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBReadAccount6
    {
        public OBReadAccount6()
        {

        }

        [DataMember]
        public OBReadDataAccount5 Data;
    }
}
