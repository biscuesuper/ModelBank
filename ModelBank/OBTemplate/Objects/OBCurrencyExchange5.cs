using OBData.Enums;
using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBCurrencyExchange5
    {
        public OBCurrencyExchange5()
        {

        }

        /// <summary>
        /// Amount of money to be moved between the debtor and creditor, before deduction of charges, 
        /// expressed in the currency as ordered by the initiating party.	
        /// </summary>
        [DataMember]
        public OBActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; set; }

        /// <summary>
        /// Unique identification to unambiguously identify the foreign exchange contract.	
        /// </summary>
        [DataMember]
        public string? ContractIdentification { get; set; }

        /// <summary>
        /// Factor used to convert an amount from one currency into another. 
        /// This reflects the price at which one currency was bought with another currency. 
        /// Usage: ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).	
        /// </summary>
        [DataMember]
        public BaseOneRate ExchangeRate { get; set; }

        /// <summary>
        /// Date and time at which an exchange rate is quoted.	
        /// </summary>
        [DataMember]
        public DateTime? QuotationDate { get; set; }

        /// <summary>
        /// Currency from which an amount is to be converted in a currency conversion.	
        /// </summary>
        [DataMember]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// Currency into which an amount is to be converted in a currency conversion.	
        /// </summary>
        [DataMember]
        public string? TargetCurrency { get; set; }

        /// <summary>
        /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.	
        /// </summary>
        [DataMember]
        public string? UnitCurrency { get; set; }

    }
}