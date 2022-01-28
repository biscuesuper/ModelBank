using ModelBank.Resources.Enums;
using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBTransactionCardInstrument1
    {
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
        public Max34Text? Identification;

        /// <summary>
        /// Name of the cardholder using the card instrument.	
        /// </summary>
        [DataMember]
        public Max70Text? Name;

    }
}