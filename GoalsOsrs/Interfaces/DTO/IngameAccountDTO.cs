using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DTO
{
    public class IngameAccountDTO
    {
        //get en sets
        public int Id { get; set; }
        public string Username { get; set; }
        public string Type { get; set; }
        public List<StatDTO> Stats { get; set; }

        public IngameAccountDTO()
        {

        }
        public IngameAccountDTO(string username, string type)
        {
            Username = username;
            Type = type;
        }

        public IngameAccountDTO(int id, string username, string type)
        {
            Id = id;
            Username = username;
            Type = type;
        }
    }
}
