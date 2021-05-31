namespace Logic.Interfaces
{
    public interface IUserCollection
    {
        void AddUser(string name, string password, string email);
        void DeleteUser(int id);
        IUser GetUserByID(int id);
    }
}