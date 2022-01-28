using ModelBank.Resources.Enums;
using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBCurrencyExchange5
    {
        /// <summary>
        /// Amount of money to be moved between the debtor and creditor, before deduction of charges, 
        /// expressed in the currency as ordered by the initiating party.	
        /// </summary>
        [DataMember]
        public OBActiveOrHistoricCurrencyAndAmount? InstructedAmount;

        /// <summary>
        /// Unique identification to unambiguously identify the foreign exchange contract.	
        /// </summary>
        [DataMember]
        public Max35Text? ContractIdentification;

        /// <summary>
        /// Factor used to convert an amount from one currency into another. 
        /// This reflects the price at which one currency was bought with another currency. 
        /// Usage: ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).	
        /// </summary>
        [DataMember]
        public BaseOneRate ExchangeRate;

        /// <summary>
        /// Date and time at which an exchange rate is quoted.	
        /// </summary>
        [DataMember]
        public ISODateTime? QuotationDate;

        /// <summary>
        /// Currency from which an amount is to be converted in a currency conversion.	
        /// </summary>
        [DataMember]
        public ActiveOrHistoricCurrencyCode SourceCurrency;

        /// <summary>
        /// Currency into which an amount is to be converted in a currency conversion.	
        /// </summary>
        [DataMember]
        public ActiveOrHistoricCurrencyCode? TargetCurrency;

        /// <summary>
        /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.	
        /// </summary>
        [DataMember]
        public ActiveOrHistoricCurrencyCode? UnitCurrency;

    }
}