using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBReadDataAccount5
    {
        /// <summary>
        /// Unambiguous identification of the account to which credit and debit entries are made.	
        /// </summary>
        [DataMember]
        public IEnumerable<OBAccount6> Account = new List<OBAccount6>();
    }
}
