namespace ModelBank.Objects
{
    public class Txn
    {
        public int Id;
        public int AccountId;
        public decimal Amount;
        public DateTime Date;

        public Txn(int id, int accountId, decimal amount, DateTime date)
        {
            Id = id;
            AccountId = accountId;
            Amount = amount;
            Date = date;
        }

        public Txn(int id, int accountId, decimal amount)
        {
            Id = id;
            AccountId = accountId;
            Amount = amount;
            Date = DateTime.Now;
        }

        public Txn()
        {

        }
    }
}
