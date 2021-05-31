using Interfaces.DTO;

namespace Dal.Context
{
    public interface IUserDal
    {
        UserDTO SignIn(string email, string password);
        void UpdateUser();
    }
}