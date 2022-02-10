using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBReadDataAccount5
    {
        public OBReadDataAccount5()
        {

        }

        /// <summary>
        /// Unambiguous identification of the account to which credit and debit entries are made.	
        /// </summary>
        [DataMember]
        public ICollection<OBAccount6> Account { get; set; } = new List<OBAccount6>();
    }
}
