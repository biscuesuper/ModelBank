﻿using System.Runtime.Serialization;
using ModelBank.Resources.Enums;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBActiveOrHistoricCurrencyAndAmount
    {
        /// <summary>
        /// A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217.
        /// </summary>
        [DataMember]
        public OBActiveCurrencyAndAmount_SimpleType Amount;

        /// <summary>
        /// A code allocated to a currency by a Maintenance Agency under an international identification scheme, as described in the latest 
        /// edition of the international standard ISO 4217 "Codes for the representation of currencies and funds".
        /// </summary>
        [DataMember]
        public ActiveOrHistoricCurrencyCode Currency;
    }
}