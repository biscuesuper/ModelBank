using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBBranchAndFinancialInstitutionIdentification5
    {
        /// <summary>
        /// Unique and unambiguous identification of the servicing institution.
        /// </summary>
        [DataMember]
        public Max35Text Identification;

        /// <summary>
        /// Name of the identification scheme, in a coded form as published in an external list.
        /// </summary>
        [DataMember]
        public OBExternalFinancialInstitutionIdentification4Code SchemeName;
    }
}