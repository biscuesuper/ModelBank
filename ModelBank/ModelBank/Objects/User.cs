namespace ModelBank.Objects
{
    public class User
    {
        public int Id;
        public string? Name;

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
