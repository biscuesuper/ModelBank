using OBData.Enums;
using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBPostalAddress6
    {
        public OBPostalAddress6()
        {

        }

        /// <summary>
        /// Identifies the nature of the postal address.	
        /// </summary>
        [DataMember]
        public OBAddressTypeCode? AddressType { get; set; }

        /// <summary>
        /// Identification of a division of a large organisation or building.	
        /// </summary>
        [DataMember]
        public string? Department { get; set; }

        /// <summary>
        /// Identification of a sub-division of a large organisation or building.	
        /// </summary>
        [DataMember]
        public string? SubDepartment { get; set; }

        /// <summary>
        /// Name of a street or thoroughfare.	
        /// </summary>
        [DataMember]
        public string? StreetName { get; set; }

        /// <summary>
        /// Number that identifies the position of a building on a street.	
        /// </summary>
        [DataMember]
        public string? BuildingNumber { get; set; }

        /// <summary>
        /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.	
        /// </summary>
        [DataMember]
        public string? PostCode { get; set; }

        /// <summary>
        /// Name of a built-up area, with defined boundaries, and a local government.	
        /// </summary>
        [DataMember]
        public string? TownName { get; set; }

        /// <summary>
        /// Identifies a subdivision of a country such as state, region, county.	
        /// </summary>
        [DataMember]
        public string? CountrySubDivision { get; set; }

        /// <summary>
        /// Nation with its own government.	
        /// </summary>
        [DataMember]
        public string? Country { get; set; }

        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services, presented in free format text.	
        /// </summary>
        [DataMember]
        public string? AddressLine { get; set; }
    }
}