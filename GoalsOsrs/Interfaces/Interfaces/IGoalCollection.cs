using Interfaces.DTO;
using System.Collections.Generic;

namespace Dal.Context
{
    public interface IGoalCollection
    {
        void AddGoal(GoalDTO goal);
        void DeleteGoal(int id);
        GoalDTO GetByIDGoals(int id);
        List<GoalDTO> GetAllGoals();
    }
}