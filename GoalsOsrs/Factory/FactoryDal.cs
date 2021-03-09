using Dal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class FactoryDal
    {
        //Voor User
        public static IUser CreateUserDal()
        {
            return new UserSqlContext();
        }

        public static IUserCollection CreateUserCollectionDal()
        {
            return new UserSqlContext();
        }
    }
}
