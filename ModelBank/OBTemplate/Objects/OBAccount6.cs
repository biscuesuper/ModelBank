﻿using System.Data;
using System.Runtime.Serialization;
using OBData.Enums;

namespace OBData.Objects
{
    [DataContract]
    public class OBAccount6
    {
        public OBAccount6()
        {

        }

        /// <summary>
        /// Provides the details to identify an account.
        /// </summary>
        [DataMember]
        public ICollection<OBCashAccount5> Account { get; set; } = new List<OBCashAccount5>();

        /// <summary>
        /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of 
        /// entries on the account, calculates balances on the account and provides information about the account.
        /// </summary>
        [DataMember]
        public OBBranchAndFinancialInstitutionIdentification5? Servicer { get; set; }

        /// <summary>
        /// A unique and immutable identifier used to identify the account resource. This identifier has no meaning to the account owner.
        /// </summary>
        [DataMember]
        public string AccountId { get; set; }

        /// <summary>
        /// Specifies the sub type of account (product family group).
        /// </summary>
        [DataMember]
        public OBExternalAccountSubType1Code? AccountSubType { get; set; }

        /// <summary>
        /// Specifies the type of account (personal or business).
        /// </summary>
        [DataMember]
        public OBExternalAccountType1Code? AccountType { get; set; }

        /// <summary>
        /// Identification of the currency in which the account is held. 
        /// Usage: Currency should only be used in case one and the same account number covers several currencies and the initiating party 
        /// needs to identify which currency needs to be used for settlement on the account.
        /// </summary>
        [DataMember]
        public string? Currency { get; set; }

        /// <summary>
        /// Specifies the description of the account type.
        /// </summary>
        [DataMember]
        public string? Description { get; set; } //why is this only 35?

        /// <summary>
        /// Maturity date for the account.
        /// </summary>
        [DataMember]
        public DateTime? MaturityDate { get; set; }

        /// <summary>
        /// The nickname of the account, assigned by the account owner in order to provide an additional means of identification of the account.
        /// </summary>
        [DataMember]
        public string? Nickname { get; set; }

        /// <summary>
        /// Date on which the account and related basic services are effectively operational for the account owner.
        /// </summary>
        [DataMember]
        public DateTime? OpeningDate { get; set; }

        /// <summary>
        /// Specifies the status of account resource in code form.
        /// </summary>
        [DataMember]
        public OBAccountStatus1Code Status { get; set; }

        /// <summary>
        /// Date and time at which the resource status was updated.
        /// </summary>
        [DataMember]
        public DateTime? StatusUpdateDateTime { get; set; }

        /// <summary>
        /// The switch status for the account.
        /// </summary>
        [DataMember]
        public OBExternalSwitchStatusCode? SwitchStatus { get; set; }

    }
}
