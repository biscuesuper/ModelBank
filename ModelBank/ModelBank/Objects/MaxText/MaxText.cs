using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class MaxText
    {
        readonly string _value;
        public MaxText(string value)
        {
            this._value = value;
        }
        public static implicit operator string(MaxText d)
        {
            return d._value;
        }
        public static implicit operator MaxText(string d)
        {
            return new MaxText(d);
        }
    }
}
