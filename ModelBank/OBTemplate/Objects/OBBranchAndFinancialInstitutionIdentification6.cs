using OBData.Enums;
using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBBranchAndFinancialInstitutionIdentification6
    {
        public OBBranchAndFinancialInstitutionIdentification6()
        {

        }

        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.	
        /// </summary>
        [DataMember]
        public OBPostalAddress6? PostalAddress;

        /// <summary>
        /// Unique and unambiguous identification of a financial institution or a branch of a financial institution.	
        /// </summary>
        [DataMember]
        public string? Identification;

        /// <summary>
        /// Name by which an agent is known and which is usually used to identify that agent.	
        /// </summary>
        [DataMember]
        public string? Name;

        /// <summary>
        /// Name of the identification scheme, in a coded form as published in an external list.	
        /// </summary>
        [DataMember]
        public OBExternalFinancialInstitutionIdentification4Code? SchemeName;
    }
}