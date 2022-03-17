namespace OBData.Enums
{
    public class ISODate
    {
        readonly string _value;

        public ISODate()
        {
            _value = "";
        }

        public ISODate(string value)
        {
            this._value = value;
        }
        public static implicit operator string(ISODate d)
        {
            return d._value;
        }
        public static implicit operator ISODate(string d)
        {
            return new ISODate(d);
        }
    }
}