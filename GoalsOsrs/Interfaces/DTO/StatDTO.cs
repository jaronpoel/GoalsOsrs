using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DTO
{
    public class StatDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Value { get; set; }

        public StatDTO()
        {

        }

        public StatDTO(int id, string title, int value)
        {
            Title = title;
            Id = id;
            Value = value;
        }
    }
}
