using System.Text.RegularExpressions;

namespace OBData.Enums
{
    /// <summary>
    /// A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217
    /// </summary>
    public class OBActiveCurrencyAndAmount_SimpleType
    {
        readonly string _value;
        public OBActiveCurrencyAndAmount_SimpleType(string value)
        {
            if (!Regex.IsMatch(value, @"^\d{1,13}$\|^\d{1,13}\.\d{1,5}$")) 
                throw new InvalidCastException("ActiveOrHistoricCurrencyCode does not match the required pattern.");
            this._value = value;
        }
        public static implicit operator string(OBActiveCurrencyAndAmount_SimpleType d)
        {
            return d._value;
        }
        public static implicit operator OBActiveCurrencyAndAmount_SimpleType(string d)
        {
            return new OBActiveCurrencyAndAmount_SimpleType(d);
        }
    }
}