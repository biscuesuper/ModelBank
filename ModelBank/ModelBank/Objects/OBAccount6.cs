using System.Runtime.Serialization;
using ModelBank.Resources.Enums;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBAccount6
    {
        /// <summary>
        /// Provides the details to identify an account.
        /// </summary>
        [DataMember]
        IEnumerable<OBCashAccount5> Account = new List<OBCashAccount5>();

        /// <summary>
        /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of 
        /// entries on the account, calculates balances on the account and provides information about the account.
        /// </summary>
        [DataMember]
        public OBBranchAndFinancialInstitutionIdentification5? Servicer;

        /// <summary>
        /// A unique and immutable identifier used to identify the account resource. This identifier has no meaning to the account owner.
        /// </summary>
        [DataMember]
        public Max40Text AccountId;

        /// <summary>
        /// Specifies the sub type of account (product family group).
        /// </summary>
        [DataMember]
        public OBExternalAccountSubType1Code? AccountSubType;

        /// <summary>
        /// Specifies the type of account (personal or business).
        /// </summary>
        [DataMember]
        public OBExternalAccountType1Code? AccountType;

        /// <summary>
        /// Identification of the currency in which the account is held. 
        /// Usage: Currency should only be used in case one and the same account number covers several currencies and the initiating party 
        /// needs to identify which currency needs to be used for settlement on the account.
        /// </summary>
        [DataMember]
        public ActiveOrHistoricCurrencyCode? Currency;

        /// <summary>
        /// Specifies the description of the account type.
        /// </summary>
        [DataMember]
        public Max35Text? Description; //why is this only 35?

        /// <summary>
        /// Maturity date for the account.
        /// </summary>
        [DataMember]
        public ISODate? MaturityDate;

        /// <summary>
        /// The nickname of the account, assigned by the account owner in order to provide an additional means of identification of the account.
        /// </summary>
        [DataMember]
        public Max70Text? Nickname;

        /// <summary>
        /// Date on which the account and related basic services are effectively operational for the account owner.
        /// </summary>
        [DataMember]
        public ISODate? OpeningDate;

        /// <summary>
        /// Specifies the status of account resource in code form.
        /// </summary>
        [DataMember]
        public OBAccountStatus1Code Status;

        /// <summary>
        /// Date and time at which the resource status was updated.
        /// </summary>
        [DataMember]
        public ISODateTime? StatusUpdateDateTime;

        /// <summary>
        /// The switch status for the account.
        /// </summary>
        [DataMember]
        public OBExternalSwitchStatusCode? SwitchStatus;

    }
}
