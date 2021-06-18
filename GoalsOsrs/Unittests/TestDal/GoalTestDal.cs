using Dal.Context;
using Exceptions.Goal;
using Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unittests.TestDal
{
    class GoalTestDal : IGoalDal, IGoalCollectionDal
    {
        List<GoalDTO> goals = new List<GoalDTO>();

        public GoalTestDal()
        {
            List<GoalDTO> goals = new List<GoalDTO>()
            {
                new GoalDTO(1, 1, "Saradomin verslaan", "armadyl crossbow", "Betere ranged weapon", "NotStarted", "Item"),
                new GoalDTO(2, 1, "Saradomin verslaan", "Saradomin godsword", "Heal spec weapon voor slayer", "Started", "Item"),
                new GoalDTO(3, 1, "Saradomin verslaan", "ss", "Betere melee weapon", "Done", "Item"),
                new GoalDTO(4, 2, "Zammy verslaan", "Staff of the death", "Betere magic weapon", "Started", "Item"),
                new GoalDTO(5, 2, "Zulrah verslaan", "Blowpipe", "Betere ranged weapon", "Done", "Item"),
            };
        }

        public void AddGoal(GoalDTO goal)
        {
            try
            {
                goals.Add(goal);
            }
            catch
            {
                throw new AddGoalFailedException();
            }
        }

        public void DeleteGoal(int id)
        {
            if (goals.Contains(goals.Find(x => x.Id == id)))
            {
                goals.Remove(goals.Find(x => x.Id == id));
            }
            else
            {
                throw new DeleteGoalFailedException("could not delete user");
            }
        }

        public List<GoalDTO> GetAllGoalsByIngameAccount(int accId)
        {
            //even Id nog aan koppelen nu geeft hij elke goal terug
            return goals;
        }

        public GoalDTO GetByIDGoals(int id)
        {
            foreach (var goal in goals)
            {
                if (goal.Id == id)
                {
                    return goal;
                }
            }
            throw new GetGoalFailedException("An unexpected error occured.");
        }

        public void UpdateGoal(GoalDTO goal)
        {
            //kan je nu wel maken.
            throw new NotImplementedException();
        }
    }
}
