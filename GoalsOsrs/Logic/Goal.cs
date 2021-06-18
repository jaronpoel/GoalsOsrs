using Dal.Context;
using Factory;
using Interfaces.DTO;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Goal: IGoal
    {
        public int Id { get; }
        public int AccountId { get; }
        public string Title { get; }
        public string Item { get;  }
        public string Description { get; }
        public string Status { get; }
        public string Kind { get; }

        public Goal()
        {

        }

        public Goal(int id, int accid, string title, string item, string description, string status, string kind)
        {
            Id = id;
            AccountId = accid;
            Title = title;
            Item = item;
            Description = description;
            Status = status;
            Kind = kind;
        }

        public Goal(string title, string kind, string item, string description, int accid)
        {
            Title = title;
            Kind = kind;
            Item = item;
            Description = description;
            AccountId = accid;
        }

        public Goal(int id, string title, string kind, string item, string description)
        {
            Id = id;
            Title = title;
            Kind = kind;
            Item = item;
            Description = description;
        }

        public Goal(int id, string title, string kind, string item, string description, string status)
        {
            Id = id;
            Title = title;
            Kind = kind;
            Item = item;
            Description = description;
            Status = status;
        }

        //Factory aanroepen
        private readonly IGoalDal GoalDAL;
        public Goal(IGoalDal goalDal)
        {
            GoalDAL = goalDal;
        }

        //methodes
        public void UpdateGoal(IGoal goal)
        {
            GoalDTO goalDTO = new GoalDTO(goal.Id, goal.Title, goal.Kind, goal.Item, goal.Description, goal.Status);
            GoalDAL.UpdateGoal(goalDTO);
        }
    }
}
