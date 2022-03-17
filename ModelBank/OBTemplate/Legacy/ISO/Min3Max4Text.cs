namespace OBData.Enums
{
    public class Min3Max4Text
    {
        private string _value;

        public Min3Max4Text()
        {
            _value = "";
        }

        public Min3Max4Text(string value)
        {
            this._value = value;
        }
        public static implicit operator string(Min3Max4Text d)
        {
            return d._value;
        }
        public static implicit operator Min3Max4Text(string d)
        {
            return new Min3Max4Text(d);
        }
    }
}