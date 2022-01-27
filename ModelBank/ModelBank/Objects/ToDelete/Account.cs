using System.Runtime.Serialization;

namespace ModelBank.Objects
{
    [DataContract]
    public class Account
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public decimal Balance { get; set; }

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
