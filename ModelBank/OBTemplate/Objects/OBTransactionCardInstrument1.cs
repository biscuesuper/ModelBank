using OBData.Enums;
using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBTransactionCardInstrument1
    {
        public OBTransactionCardInstrument1()
        {

        }

        /// <summary>
        /// The card authorisation type.	
        /// </summary>
        [DataMember]
        public OBExternalCardAuthorisationType1Code? AuthorisationType;

        /// <summary>
        /// Name of the card scheme.	 
        /// </summary>
        [DataMember]
        public OBExternalCardSchemeType1Code CardSchemeName;

        /// <summary>
        /// Identification assigned by an institution to identify the card instrument used in the transaction. 
        /// This identification is known by the account owner, and may be masked.	
        /// </summary>
        [DataMember]
        public string? Identification;

        /// <summary>
        /// Name of the cardholder using the card instrument.	
        /// </summary>
        [DataMember]
        public string? Name;

    }
}