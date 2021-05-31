using Dal.Context;
using Factory;
using Interfaces.DTO;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class User : IUser
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
        private readonly IUserDal UserDAL;
        public User(IUserDal userDal)
        {
            UserDAL = userDal;
        }

        //Begin van de Methodes aanroepen

        public IUser SignIn(string email, string password)
        {
            UserDTO userdto = UserDAL.SignIn(email, password);
            User user = new User(userdto.Id, userdto.Name);
            return user;
        }

        public IUser UpdateUser(string email, string password, string name)
        {
            throw new NotImplementedException();
        }
    }
}
