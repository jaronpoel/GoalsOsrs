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
        public static IUserDal CreateUserDal()
        {
            return new UserSqlContext();
        }

        public static IUserCollectionDal CreateUserCollectionDal()
        {
            return new UserSqlContext();
        }

        //Voor Goal
        public static IGoalDal CreateGoalDal()
        {
            return new GoalSqlContext();
        }

        public static IGoalCollectionDal CreateGoalCollectionDal()
        {
            return new GoalSqlContext();
        }

        //Voor IngameAccount
        public static IIngameAccountDal CreateIngameAccountDal()
        {
            return new IngameAccountSqlContext();
        }

        public static IIngameAccountCollectionDal CreateIngameAccounCollectiontDal()
        {
            return new IngameAccountSqlContext();
        }

    }
}
