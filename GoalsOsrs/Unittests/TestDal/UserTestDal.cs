using Dal.Context;
using Exceptions.User;
using Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unittests.TestDal
{
    class UserTestDal : IUserDal, IUserCollectionDal
    {
        public List<UserDTO> users = new List<UserDTO>();

        public UserTestDal()
        {
            users = new List<UserDTO>()
            {
                new UserDTO(1, "Jaron", "Admin", "jaron@gmail.com"),
                new UserDTO(2, "Poel", "123456", "poel@gmail.com")
            };
        }

        public bool DeleteUser(int id)
        {
            if (users.Contains(users.Find(x => x.Id == id)))
            {
                users.Remove(users.Find(x => x.Id == id));
                return true;
            }
            else
            {
                return false;
            }
        }

        public UserDTO GetUserByID(int id)
        {
            foreach(var user in users)
            {
                if(user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public UserDTO SignIn(string email, string password)
        {
            if(email == string.Empty || password == string.Empty)
            {
                return null;
            }

            UserDTO findUser = users.Find(u => u.Email == email && u.Password == password);

            if(findUser == null)
            {
                return null;
            }
            UserDTO returnUser = new UserDTO(findUser.Id, findUser.Name);

            return returnUser;
        }

        UserDTO IUserCollectionDal.SignUp(string name, string password, string email)
        {
            if (email == null || password == null || name == null)
            {
                return null;
            }

            //hoe maak ik mijn id auto incremented
            UserDTO user = new UserDTO(3, name, password, email);
            users.Add(user);
            return user;
        }

        UserDTO IUserDal.UpdateUser(int id, string name, string password, string email)
        {
            throw new NotImplementedException();
        }
    }
}
