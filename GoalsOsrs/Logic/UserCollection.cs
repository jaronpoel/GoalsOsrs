using Dal.Context;
using Factory;
using Logic.Interfaces;
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
    }
}
