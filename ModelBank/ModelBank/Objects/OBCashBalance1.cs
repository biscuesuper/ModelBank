using ModelBank.Resources.Enums;
using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
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
        public OBActiveOrHistoricCurrencyAndAmount Amount;

        /// <summary>
        /// Set of elements used to provide details on the credit line.
        /// </summary>
        [DataMember]
        public IEnumerable<OBCreditLine1> CreditLine = new List<OBCreditLine1>();

        /// <summary>
        /// A unique and immutable identifier used to identify the account resource. This identifier has no meaning to the account owner.
        /// </summary>
        [DataMember]
        public string AccountId;

        /// <summary>
        /// Indicates whether the balance is a credit or a debit balance. Usage: A zero balance is considered to be a credit balance.
        /// </summary>
        [DataMember]
        public OBCreditDebitCode CreditDebitIndicator;

        /// <summary>
        /// Indicates the date (and time) of the balance.
        /// </summary>
        [DataMember]
        public ISODateTime DateTime;

        /// <summary>
        /// Balance type, in a coded form.
        /// </summary>
        [DataMember]
        public OBBalanceType1Code Type;
    }
}