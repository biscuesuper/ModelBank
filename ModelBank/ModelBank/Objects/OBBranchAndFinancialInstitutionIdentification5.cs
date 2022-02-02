using ModelBank.Resources.Enums;
using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, 
    /// calculates balances on the account and provides information about the account.
    /// This is the servicer of the account.
    /// </summary>
    [DataContract]
    public class OBBranchAndFinancialInstitutionIdentification5
    {
        public OBBranchAndFinancialInstitutionIdentification5()
        {

        }

        /// <summary>
        /// Unique and unambiguous identification of the servicing institution.
        /// </summary>
        [DataMember]
        public string Identification;

        /// <summary>
        /// Name of the identification scheme, in a coded form as published in an external list.
        /// </summary>
        [DataMember]
        public OBExternalFinancialInstitutionIdentification4Code SchemeName;
    }
}