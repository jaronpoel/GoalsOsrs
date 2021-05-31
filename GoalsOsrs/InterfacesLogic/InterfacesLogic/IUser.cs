namespace Logic.Interfaces
{
    public interface IUser
    {
        public int Id { get; }
        public string Name { get; }
        public string Password { get; }
        public string Email { get; }

        IUser SignIn(string email, string password);
        IUser UpdateUser(string email, string password, string name);
    }
}