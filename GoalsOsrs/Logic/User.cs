using Dal.Context;
using Factory;
using Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class User
    {
        public int Id { get; }
        public string Name { get; }
        public string Password { get; }
        public string Email { get; }

        public User(int id, string name, string password, string email)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
        }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //Factory aanroepen
        private readonly IUser UserDAL;
        public User()
        {
            UserDAL = FactoryDal.CreateUserDal();
        }

        //Begin van de Methodes aanroepen

        public User SignIn(string email, string password)
        {
            UserDTO userdto = UserDAL.SignIn(email, password);
            User user = new User(userdto.Id, userdto.Name);
            return user;
        }

        public User UpdateUser(string email, string password, string name)
        {
            throw new NotImplementedException();
        }
    }
}
