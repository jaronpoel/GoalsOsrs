using Interfaces.DTO;

namespace Dal.Context
{
    public interface IGoal
    {
        void UpdateGoal(GoalDTO goal);
    }
}