using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
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
        public ExternalBankTransactionFamily1Code Code;

        /// <summary>
        /// Specifies the sub-product family within a specific family.	
        /// </summary>
        [DataMember]
        public ExternalBankTransactionSubFamily1Code SubCode;
    }
}