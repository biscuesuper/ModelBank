using System.ComponentModel;

namespace OBData.Enums
{
    /// <summary>
    /// This is Data Type for Account/SchemeName and used to identify the type of Identification used to identify an account.
    /// </summary>
    public enum OBExternalAccountIdentification4Code
    {
        /// <summary>
        /// Basic Bank Account Number (BBAN) - identifier used nationally by financial institutions, ie, in individual countries, generally as part of a 
        /// National Account Numbering Scheme(s), to uniquely identify the account of a customer.
        /// </summary>
        [Description("UK.OBIE.BBAN")]
        UKOBIEBBAN,

        /// <summary>
        /// An identifier used internationally by financial institutions to uniquely identify the account of a customer at a financial institution, as described in 
        /// the latest edition of the international standard ISO 13616. "Banking and related financial services - International Bank Account Number (IBAN)".
        /// </summary>
        [Description("UK.OBIE.IBAN")]
        UKOBIEIBAN,

        /// <summary>
        /// Primary Account Number - identifier scheme used to identify a card account.
        /// </summary>
        [Description("UK.OBIE.PAN")]
        UKOBIEPAN,

        /// <summary>
        /// Paym Scheme to make payments via mobile
        /// </summary>
        [Description("UK.OBIE.Paym")]
        UKOBIEPaym,

        /// <summary>
        /// Sort Code and Account Number - identifier scheme used in the UK by financial institutions to identify the account of a customer. 
        /// The identifier is the concatenation of the 6 digit UK sort code and 8 digit account number.
        /// The regular expression for this identifier is: ^[0-9]{6}[0-9]{8}$
        /// </summary>
        [Description("UK.OBIE.SortCodeAccountNumber")]
        UKOBIESortCodeAccountNumber,
    }
}