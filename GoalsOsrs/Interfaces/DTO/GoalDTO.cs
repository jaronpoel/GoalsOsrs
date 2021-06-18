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
<<<<<<< HEAD
        public int AccountId { get; set; }
=======
        public int AccId { get; }
>>>>>>> main
        public string Title { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Kind { get; set; }

        public GoalDTO()
        {

        }

        public GoalDTO(int id, int accid, string title, string item, string description, string status, string kind)
        {
            Id = id;
            AccountId = accid;
            Title = title;
            Item = item;
            Description = description;
            Status = status;
            Kind = kind;
        }

        public GoalDTO(string title, string kind, string item, string description, int accid)
        {
            Title = title;
            Kind = kind;
            Item = item;
            Description = description;
            AccountId = accid;
        }

        public GoalDTO(int id, string title, string kind, string item, string description, string status)
        {
            Id = id;
            Title = title;
            Kind = kind;
            Item = item;
            Description = description;
            Status = status;
        }
    }
}
