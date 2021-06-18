namespace Logic.Interfaces
{
    public interface IUserCollection
    {
        bool DeleteUser(int id);
        IUser GetUserByID(int id);
        IUser SignUp(string email, string password, string name);
        IUser SignIn(string email, string password);
    }
}