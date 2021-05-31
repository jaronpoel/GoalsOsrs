using Interfaces.DTO;

namespace Dal.Context
{
    public interface IGoalDal
    {
        void UpdateGoal(GoalDTO goal);
    }
}