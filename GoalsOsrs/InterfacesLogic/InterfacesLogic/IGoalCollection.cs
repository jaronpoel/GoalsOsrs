using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IGoalCollection
    {
        void AddGoal(IGoal goal);
        void DeleteGoal(int id);
        IGoal GetByIDGoals(int id);
        List<IGoal> GetAllGoalsByIngameAccount(int AccId);
    }
}