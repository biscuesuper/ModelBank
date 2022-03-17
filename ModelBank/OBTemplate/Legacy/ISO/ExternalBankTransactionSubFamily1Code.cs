namespace OBData.Objects
{
    public class ExternalBankTransactionSubFamily1Code
    {
        private string _value;

        public ExternalBankTransactionSubFamily1Code()
        {
            _value = "";
        }

        public ExternalBankTransactionSubFamily1Code(string value)
        {
            this._value = value;
        }
        public static implicit operator string(ExternalBankTransactionSubFamily1Code d)
        {
            return d._value;
        }
        public static implicit operator ExternalBankTransactionSubFamily1Code(string d)
        {
            return new ExternalBankTransactionSubFamily1Code(d);
        }
    }
}