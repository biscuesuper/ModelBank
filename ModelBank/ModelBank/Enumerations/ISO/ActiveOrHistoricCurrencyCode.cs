using System.Text.RegularExpressions;

namespace ModelBank.Resources.Enums
{
    /// <summary>
    /// A code allocated to a currency by a Maintenance Agency under an international identification scheme, 
    /// as described in the latest edition of the international standard ISO 4217 "Codes for the representation of currencies and funds".
    /// </summary>
    public class ActiveOrHistoricCurrencyCode
    {
        readonly string _value;
        public ActiveOrHistoricCurrencyCode(string value)
        {
            if (!Regex.IsMatch(value, @"^[A-Z]{3,3}$")) throw new InvalidCastException("ActiveOrHistoricCurrencyCode does not match the required pattern.");
            this._value = value;
        }
        public static implicit operator string(ActiveOrHistoricCurrencyCode d)
        {
            return d._value;
        }
        public static implicit operator ActiveOrHistoricCurrencyCode(string d)
        {
            return new ActiveOrHistoricCurrencyCode(d);
        }
    }
}