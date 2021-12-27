namespace ModelBank.Objects
{
    public class Account
    {
        public int Id;
        public int UserId;
        public decimal Balance;

        public Account(int id, int userId, decimal balance)
        {
            Id = id;
            UserId = userId;
            Balance = balance;
        }

        public Account()
        {

        }
    }
}
