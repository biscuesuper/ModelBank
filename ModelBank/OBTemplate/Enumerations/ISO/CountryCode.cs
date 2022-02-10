using System.Text.RegularExpressions;

namespace OBData.Objects
{
    /// <summary>
    /// Nation with its own government.	
    /// </summary>
    public class CountryCode
    {
        readonly string _value;
        public CountryCode(string value)
        {
            if (!Regex.IsMatch(value, @"^[A-Z]{2,2}$")) throw new InvalidCastException("ActiveOrHistoricCurrencyCode does not match the required pattern.");
            this._value = value;
        }
        public static implicit operator string(CountryCode d)
        {
            return d._value;
        }
        public static implicit operator CountryCode(string d)
        {
            return new CountryCode(d);
        }
    }
}