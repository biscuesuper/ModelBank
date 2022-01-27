using System.ComponentModel;

namespace ModelBank.Resources.Enums
{
    /// <summary>
    /// This is the Data Type for Agent/SchemeName and used to identify the type of Identification used to identify an agent. 
    /// </summary>
    public enum OBExternalFinancialInstitutionIdentification4Code
    {
        /// <summary>
        /// Valid BICs for financial institutions are registered by the ISO 9362 Registration Authority 
        /// in the BIC directory, and consist of eight (8) or eleven (11) contiguous characters.
        /// </summary>
        [Description("UK.OBIE.BICFI")]
        UKOBIEBICFI
    }
}