using System.Runtime.Serialization;

namespace ModelBank.Objects
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string? Name { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public User()
        {

        }
    }
}
