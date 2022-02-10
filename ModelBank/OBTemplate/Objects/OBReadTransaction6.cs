using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBReadTransaction6
    {
        public OBReadTransaction6()
        {

        }

        [DataMember]
        public OBReadDataTransaction6 Data;
    }
}
