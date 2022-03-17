using OBData.Enums;
using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBTransactionCashBalance
    {
        public OBTransactionCashBalance()
        {

        }

        /// <summary>
        /// A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217.	
        /// </summary>
        [DataMember]
        public OBActiveOrHistoricCurrencyAndAmount Amount { get; set; }

        /// <summary>
        /// Indicates whether the balance is a credit or a debit balance. Usage: A zero balance is considered to be a credit balance.	
        /// </summary>
        [DataMember]
        public OBCreditDebitCode CreditDebitIndicator { get; set; }

        /// <summary>
        /// Balance type, in a coded form.	
        /// </summary>
        [DataMember]
        public OBBalanceType1Code Type { get; set; }
    }
}