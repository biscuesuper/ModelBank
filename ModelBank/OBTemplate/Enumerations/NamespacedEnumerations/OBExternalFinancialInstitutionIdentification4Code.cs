using System.ComponentModel;

namespace OBData.Enums
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
        UKOBIEBICFI,

        /// <summary>
        /// Valid NCC (National Clearing Code) as an option for the accounts that don't have an IBAN, registered in the country 
        /// identified by the 2 letter ISO-3166 Country code. For example, transfer to India may have Scheme Name as UK.OBIE.NCC.IN 
        /// and Identification can be the IFSC code of the bank/branch in India
        /// </summary>
        [Description("UK.OBIE.NCC.[ISO3166-aplha2-CountryCode]")]
        UKOBIENCC //TODO: Populate with country code list
    }
}