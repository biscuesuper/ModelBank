using OBData.Enums;
using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBCashBalance1
    {
        public OBCashBalance1()
        {

        }

        /// <summary>
        /// Amount of money of the cash balance.
        /// </summary>
        [DataMember]
        public OBActiveOrHistoricCurrencyAndAmount Amount { get; set; }

        /// <summary>
        /// Set of elements used to provide details on the credit line.
        /// </summary>
        [DataMember]
        public ICollection<OBCreditLine1> CreditLine { get; set; } = new List<OBCreditLine1>();

        /// <summary>
        /// A unique and immutable identifier used to identify the account resource. This identifier has no meaning to the account owner.
        /// </summary>
        [DataMember]
        public string AccountId { get; set; }

        /// <summary>
        /// Indicates whether the balance is a credit or a debit balance. Usage: A zero balance is considered to be a credit balance.
        /// </summary>
        [DataMember]
        public OBCreditDebitCode CreditDebitIndicator { get; set; }

        /// <summary>
        /// Indicates the date (and time) of the balance.
        /// </summary>
        [DataMember]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Balance type, in a coded form.
        /// </summary>
        [DataMember]
        public OBBalanceType1Code Type { get; set; }
    }
}