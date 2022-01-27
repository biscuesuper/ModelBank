using System.Runtime.Serialization;

namespace ModelBank.Objects
{
    [DataContract]
    public class Txn
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int AccountId { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

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
