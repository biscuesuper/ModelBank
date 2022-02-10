using OBData.Enums;
using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBCreditLine1
    {
        public OBCreditLine1()
        {

        }

        /// <summary>
        /// Amount of money of the credit line.
        /// </summary>
        [DataMember]
        public OBActiveOrHistoricCurrencyAndAmount? Amount;

        /// <summary>
        /// Indicates whether or not the credit line is included in the balance of the account. 
        /// Usage: If not present, credit line is not included in the balance amount of the account.
        /// </summary>
        [DataMember]
        public bool Included;

        /// <summary>
        /// Limit type, in a coded form.
        /// </summary>
        [DataMember]
        public OBExternalLimitType1Code? Type;
    }
}