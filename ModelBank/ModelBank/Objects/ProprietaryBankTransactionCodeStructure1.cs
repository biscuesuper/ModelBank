using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class ProprietaryBankTransactionCodeStructure1
    {
        /// <summary>
        /// Proprietary bank transaction code to identify the underlying transaction.	
        /// </summary>
        [DataMember]
        public Max35Text Code;

        /// <summary>
        /// Identification of the issuer of the proprietary bank transaction code.	
        /// </summary>
        [DataMember]
        public Max35Text? Issuer;
    }
}