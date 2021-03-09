using Interfaces.DTO;

namespace Dal.Context
{
    public interface IUser
    {
        UserDTO SignIn(string email, string password);
        void UpdateUser();
    }
}