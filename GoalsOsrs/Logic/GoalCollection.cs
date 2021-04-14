using Dal.Context;
using Factory;
using Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class GoalCollection
    {
        //Factory aanroepen
        private readonly IGoalCollection GoalDAL;
        public GoalCollection()
        {
            GoalDAL = FactoryDal.CreateGoalCollectionDal();
        }

        //Begin van de Methodes aanroepen
        public void AddGoal(Goal goal)
        {
            GoalDTO goalDTO = new GoalDTO(goal.Title, goal.Level, goal.Description, goal.Kind);
            GoalDAL.AddGoal(goalDTO);
        }

        public void DeleteGoal(int id)
        {
            GoalDAL.DeleteGoal(id);
        }

        public Goal GetByIDGoals(int id)
        {
            GoalDTO goalDTO = GoalDAL.GetByIDGoals(id);
            Goal goal = new Goal(goalDTO.Id, goalDTO.Title, goalDTO.Level, goalDTO.Description,goalDTO.Kind);
            return goal;
        }

        public List<Goal> GetAllGoals()
        {
            List<GoalDTO> goalsDTO = GoalDAL.GetAllGoals();
            List<Goal> goals = new List<Goal>();
            foreach(GoalDTO goalDTO in goalsDTO)
            {
                goals.Add(new Goal(goalDTO.Id, goalDTO.Title, goalDTO.Level, goalDTO.Description, goalDTO.Kind));
            }
            return goals;
        }
    }
}
