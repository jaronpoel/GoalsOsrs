using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DTO
{
    public class GoalDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Item { get; set; }
        public int Level { get; set; }
        public int Killcount { get; set; }
        public string Description { get; set; }
        public string Kind { get; set; }

        public GoalDTO()
        {

        }

        public GoalDTO(string title, int level, string description, string kind)
        {
            Title = title;
            Level = level;
            Description = description;
            Kind = kind;
        }
    }
}
