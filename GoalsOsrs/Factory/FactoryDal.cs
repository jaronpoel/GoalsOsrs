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

        //Voor Goal
        public static IGoal CreateGoalDal()
        {
            return new GoalSqlContext();
        }

        public static IGoalCollection CreateGoalCollectionDal()
        {
            return new GoalSqlContext();
        }

        //Voor IngameAccount
        public static IIngameAccount CreateIngameAccountDal()
        {
            return new IngameAccountSqlContext();
        }

        public static IIngameAccountCollection CreateIngameAccounCollectiontDal()
        {
            return new IngameAccountSqlContext();
        }

        //Voor Stat
        public static IStat CreateStatDal()
        {
            return new StatSqlContext();
        }

    }
}
