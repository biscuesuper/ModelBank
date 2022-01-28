using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBReadDataTransaction6
    {
        /// <summary>
        /// Provides further details on an entry in the report.	
        /// </summary>
        [DataMember]
        public IEnumerable<OBTransaction6> Transaction = new List<OBTransaction6>();
    }
}
