using Interfaces.DTO;

namespace Dal.Context
{
    public interface IUserCollectionDal
    {
        bool DeleteUser(int id);
        UserDTO GetUserByID(int id);
        UserDTO SignUp(string email, string password, string name);
        UserDTO SignIn(string email, string password);
    }
}