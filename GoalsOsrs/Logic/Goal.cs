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
    public class Goal
    {
        public int Id { get; }
        public string Title { get; }
        public string Item { get;  }
        public int Level { get; }
        public int Killcount { get; }
        public string Description { get; }
        public string Kind { get; }

        public Goal(int id, string title, string item, int level, int killcount, string description, string kind)
        {
            Id = id;
            Title = title;
            Item = item;
            Level = level;
            Killcount = killcount;
            Description = description;
            Kind = kind;
        }

        public Goal(string title, int level, string description, string kind)
        {
            Title = title;
            Level = level;
            Description = description;
            Kind = kind;
        }

        public Goal(int id, string title, int level, string description, string kind)
        {
            Id = id;
            Title = title;
            Level = level;
            Description = description;
            Kind = kind;
        }

        //Factory aanroepen
        private readonly IGoal GoalDAL;
        public Goal()
        {
            GoalDAL = FactoryDal.CreateGoalDal();
        }

        //methodes
        public void UpdateGoal(Goal goal)
        {
            GoalDTO goalDTO = new GoalDTO(goal.Title, goal.Level, goal.Description, goal.Kind);
            GoalDAL.UpdateGoal(goalDTO);
        }
    }
}
