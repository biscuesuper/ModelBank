using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBReadConsent1
    {
        public OBReadConsent1()
        {

        }

        [DataMember]
        public OBReadData1 Data { get; set; }


        [DataMember]
        public OBRisk2? Risk { get; set; }
    }
}
