namespace ModelBank.Resources.Enums
{
    public class ISODateTime
    {
        readonly string _value;

        public ISODateTime()
        {
            _value = "";
        }

        public ISODateTime(string value)
        {
            this._value = value;
        }
        public static implicit operator string(ISODateTime d)
        {
            return d._value;
        }
        public static implicit operator ISODateTime(string d)
        {
            return new ISODateTime(d);
        }
    }
}