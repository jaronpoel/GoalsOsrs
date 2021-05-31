using Logic;
using Logic.Interfaces;
using Dal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLogic
{
    public class FactoryLogicLayer
    {

        //Voor User
        public static IUser CreateUser()
        {
            return new User(new UserSqlContext());
        }

        public static IUserCollection CreateUserCollection()
        {
            return new UserCollection(new UserSqlContext());
        }

        //Voor Goal
        public static IGoal CreateGoal()
        {
            return new Goal(new GoalSqlContext());
        }

        public static IGoalCollection CreateGoalCollection()
        {
            return new GoalCollection(new GoalSqlContext());
        }

        //Voor IngameAccount
        public static IIngameAccount CreateIngameAccount()
        {
            return new IngameAccount(new IngameAccountSqlContext());
        }

        public static IIngameAccountCollection CreateIngameAccounCollectiont()
        {
            return new IngameAccountCollection(new IngameAccountSqlContext());
        }
    }
}
