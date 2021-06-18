using Dal.Context;
using Factory;
<<<<<<< HEAD
using Interfaces.DTO;
using Logic.Interfaces;
=======
using Logic.Interfaces;
>>>>>>> main
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class UserCollection: IUserCollection
    {
        //Factory aanroepen
        private readonly IUserCollectionDal UserDAL;
        public UserCollection(IUserCollectionDal userCollectionDal)
        {
            UserDAL = userCollectionDal;
<<<<<<< HEAD
        }

        //Begin van de Methodes aanroepen
        public bool DeleteUser(int id)
        {
            return UserDAL.DeleteUser(id);
        }

        public IUser GetUserByID(int id)
        {
            UserDTO userDTO = UserDAL.GetUserByID(id);
            if (userDTO == null)
            {
                return null;
            }

            User user = new User(userDTO.Id, userDTO.Name);
            return user;
        }
        public IUser SignIn(string email, string password)
        {
            UserDTO userdto = UserDAL.SignIn(email, password);
            if (userdto == null)
            {
                return null;
            }
            
            User user = new User(userdto.Id, userdto.Name);
            return user;
        }

        public IUser SignUp(string name, string password, string email)
        {
            
            UserDTO userdto= UserDAL.SignUp(name, password, email);
            if(userdto == null)
            {
                return null;
            }
            User user = new User(name, password, email);
            return user;
        }
=======
        }

        //Begin van de Methodes aanroepen
        public void AddUser(string name, string password, string email)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IUser GetUserByID(int id)
        {
            throw new NotImplementedException();
        }

        //sign in en registeren hier
>>>>>>> main
    }
}
