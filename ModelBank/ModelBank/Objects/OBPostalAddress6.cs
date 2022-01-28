using ModelBank.Resources.Enums;
using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBPostalAddress6
    {
        /// <summary>
        /// Identifies the nature of the postal address.	
        /// </summary>
        [DataMember]
        public OBAddressTypeCode? AddressType;

        /// <summary>
        /// Identification of a division of a large organisation or building.	
        /// </summary>
        [DataMember]
        public Max70Text? Department;

        /// <summary>
        /// Identification of a sub-division of a large organisation or building.	
        /// </summary>
        [DataMember]
        public Max70Text? SubDepartment;

        /// <summary>
        /// Name of a street or thoroughfare.	
        /// </summary>
        [DataMember]
        public Max70Text? StreetName;

        /// <summary>
        /// Number that identifies the position of a building on a street.	
        /// </summary>
        [DataMember]
        public Max16Text? BuildingNumber;

        /// <summary>
        /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.	
        /// </summary>
        [DataMember]
        public Max16Text? PostCode;

        /// <summary>
        /// Name of a built-up area, with defined boundaries, and a local government.	
        /// </summary>
        [DataMember]
        public Max35Text? TownName;

        /// <summary>
        /// Identifies a subdivision of a country such as state, region, county.	
        /// </summary>
        [DataMember]
        public Max35Text? CountrySubDivision;

        /// <summary>
        /// Nation with its own government.	
        /// </summary>
        [DataMember]
        public CountryCode? Country;

        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services, presented in free format text.	
        /// </summary>
        [DataMember]
        public Max70Text? AddressLine;
    }
}