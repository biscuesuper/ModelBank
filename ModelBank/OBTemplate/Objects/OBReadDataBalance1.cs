using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBReadDataBalance1
    {
        public OBReadDataBalance1()
        {

        }

        /// <summary>
        /// Set of elements used to define the balance details.
        /// </summary>
        [DataMember]
        public ICollection<OBCashBalance1> Balance { get; set; } = new List<OBCashBalance1>();
    }
}