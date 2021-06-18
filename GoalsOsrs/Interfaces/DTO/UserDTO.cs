using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public UserDTO()
        {

        }

        public UserDTO(string password, string email)
        {
            Password = password;
            Email = email;
        }

        public UserDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public UserDTO(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
        }

        public UserDTO(int id, string name, string password, string email)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
        }
    }
}
