using Dal.Context;
using Factory;
using Interfaces.DTO;
<<<<<<< HEAD
using Logic.Interfaces;
=======
using Logic.Interfaces;
>>>>>>> main
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class GoalCollection: IGoalCollection
    {
        //Factory aanroepen
        private readonly IGoalCollectionDal GoalDAL;
        public GoalCollection(IGoalCollectionDal goalCollectionDal)
        {
            GoalDAL = goalCollectionDal;
        }

        //Begin van de Methodes aanroepen
        public void AddGoal(IGoal goal)
        {
            GoalDTO goalDTO = new GoalDTO(goal.Title, goal.Kind, goal.Item, goal.Description, goal.AccountId);
            GoalDAL.AddGoal(goalDTO);
        }

        public void DeleteGoal(int id)
        {
            GoalDAL.DeleteGoal(id);
        }

        public IGoal GetByIDGoals(int id)
        {
            GoalDTO goalDTO = GoalDAL.GetByIDGoals(id);
            Goal goal = new Goal(goalDTO.Id, goalDTO.Title, goalDTO.Kind, goalDTO.Item, goalDTO.Description);
            return goal;
        }

        public List<IGoal> GetAllGoalsByIngameAccount(int AccId)
        { 
            List<GoalDTO> goalsDTO = GoalDAL.GetAllGoalsByIngameAccount(AccId);
            List<IGoal> goals = new List<IGoal>();
            foreach(GoalDTO goalDTO in goalsDTO)
            {
                goals.Add(new Goal(goalDTO.Id, goalDTO.AccountId, goalDTO.Title, goalDTO.Item, goalDTO.Description, goalDTO.Status, goalDTO.Kind));
            }
            return goals;
        }
    }
}
