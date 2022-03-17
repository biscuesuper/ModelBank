using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBReadDataTransaction6
    {
        public OBReadDataTransaction6()
        {

        }

        /// <summary>
        /// Provides further details on an entry in the report.	
        /// </summary>
        [DataMember]
        public ICollection<OBTransaction6> Transaction { get; set; } = new List<OBTransaction6>();
    }
}
