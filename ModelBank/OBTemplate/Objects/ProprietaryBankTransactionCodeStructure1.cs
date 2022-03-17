using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class ProprietaryBankTransactionCodeStructure1
    {
        public ProprietaryBankTransactionCodeStructure1()
        {

        }

        /// <summary>
        /// Proprietary bank transaction code to identify the underlying transaction.	
        /// </summary>
        [DataMember]
        public string Code { get; set; }

        /// <summary>
        /// Identification of the issuer of the proprietary bank transaction code.	
        /// </summary>
        [DataMember]
        public string? Issuer { get; set; }
    }
}