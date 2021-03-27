using Interfaces.DTO;

namespace Dal.Context
{
    public interface IUserCollection
    {
        void AddUser(string name, string password, string email);
        void DeleteUser(int id);
        UserDTO GetUserByID(int id);
    }
}