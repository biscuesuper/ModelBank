namespace OBData.Objects
{
    public class ExternalBankTransactionFamily1Code
    {
        private string _value;

        public ExternalBankTransactionFamily1Code()
        {
            _value = "";
        }

        public ExternalBankTransactionFamily1Code(string value)
        {
            this._value = value;
        }
        public static implicit operator string(ExternalBankTransactionFamily1Code d)
        {
            return d._value;
        }
        public static implicit operator ExternalBankTransactionFamily1Code(string d)
        {
            return new ExternalBankTransactionFamily1Code(d);
        }
    }
}