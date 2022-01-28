using ModelBank.Resources.Enums;
using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBMerchantDetails1
    {
        /// <summary>
        /// Name by which the merchant is known.	
        /// </summary>
        [DataMember]
        public Max350Text? MerchantName;

        /// <summary>
        /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.	
        /// </summary>
        [DataMember]
        public Min3Max4Text? MerchantCategoryCode;
    }
}