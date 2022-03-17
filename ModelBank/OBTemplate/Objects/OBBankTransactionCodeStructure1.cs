using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBBankTransactionCodeStructure1
    {
        public OBBankTransactionCodeStructure1()
        {

        }

        /// <summary>
        /// Specifies the family within a domain.	
        /// </summary>
        [DataMember]
        public string Code { get; set; }

        /// <summary>
        /// Specifies the sub-product family within a specific family.	
        /// </summary>
        [DataMember]
        public string SubCode { get; set; }
    }
}