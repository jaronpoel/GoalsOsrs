using Dal.Context;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class UserCollection
    {
        //Factory aanroepen
        private readonly IUserCollection UserDAL;
        public UserCollection()
        {
            UserDAL = FactoryDal.CreateUserCollectionDal();
        }

        //Begin van de Methodes aanroepen
    }
}
