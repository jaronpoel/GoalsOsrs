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
    public class IngameAccount
    {
        public int Id { get; }
        public string Username { get; }
        public string Type { get; }

        public IngameAccount(int id, string username, string type)
        {
            Id = id;
            Username = username;
            Type = type;
        }

        public IngameAccount(string username, string type)
        {
            Username = username;
            Type = type;
        }

        //Factory aanroepen
        private readonly IIngameAccount IngameAccountDAL;
        public IngameAccount()
        {
            IngameAccountDAL = FactoryDal.CreateIngameAccountDal();
        }

        //Begin van de Methodes aanroepen
        //hier mogen ook de goal collection bij komen zodat die weg kan.
    }
}
