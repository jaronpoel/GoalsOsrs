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

        public StatDTO()
        {

        }

        public StatDTO(string title)
        {
            Title = title;
        }
    }
}
