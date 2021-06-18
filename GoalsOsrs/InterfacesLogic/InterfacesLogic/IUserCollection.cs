namespace Logic.Interfaces
{
    public interface IUserCollection
    {
<<<<<<< HEAD
        bool DeleteUser(int id);
        IUser GetUserByID(int id);
        IUser SignUp(string email, string password, string name);
        IUser SignIn(string email, string password);
=======
        void AddUser(string name, string password, string email);
        void DeleteUser(int id);
        IUser GetUserByID(int id);
>>>>>>> main
    }
}