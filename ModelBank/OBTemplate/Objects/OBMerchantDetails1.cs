using OBData.Enums;
using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBMerchantDetails1
    {
        public OBMerchantDetails1()
        {

        }

        /// <summary>
        /// Name by which the merchant is known.	
        /// </summary>
        [DataMember]
        public string? MerchantName { get; set; }

        /// <summary>
        /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.	
        /// </summary>
        [DataMember]
        public string? MerchantCategoryCode { get; set; }
    }
}