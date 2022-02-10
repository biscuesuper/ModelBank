using OBData.Enums;
using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBCashAccount5
    {
        public OBCashAccount5()
        {

        }

        /// <summary>
        /// Identification assigned by an institution to identify an account. This identification is known by the account owner.
        /// </summary>
        [DataMember]
        public string Identification;

        /// <summary>
        /// The account name is the name or names of the account owner(s) represented at an account level, as displayed by the 
        /// ASPSP's online channels. Note, the account name is not the product name or the nickname of the account.
        /// </summary>
        [DataMember]
        public string? Name;

        /// <summary>
        /// Name of the identification scheme, in a coded form as published in an external list.
        /// </summary>
        [DataMember]
        public OBExternalAccountIdentification4Code SchemeName;

        /// <summary>
        /// This is secondary identification of the account, as assigned by the account servicing institution. 
        /// This can be used by building societies to additionally identify accounts with a roll number (in addition to a sort code and account number combination).
        /// </summary>
        [DataMember]
        public string? SecondaryIdentification;
    }
}