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
    public class IngameAccount: IIngameAccount
    {
        public int Id { get; }
        public string Username { get; }
        public string Type { get; }
        public List<IStat> Stats { get; }

        public IngameAccount(int id, string username, string type)
        {
            Id = id;
            Username = username;
            Type = type;
        }

        public IngameAccount(int id, string username, string type, List<IStat> stats)
        {
            Id = id;
            Username = username;
            Type = type;
            Stats = stats;
        }

        public IngameAccount(string username, string type)
        {
            Username = username;
            Type = type;
        }

        //Factory aanroepen
        private readonly IIngameAccountDal IngameAccountDAL;
        public IngameAccount(IIngameAccountDal ingameAccountDal)
        {
            IngameAccountDAL = ingameAccountDal;
        }

        //Begin van de Methodes aanroepen
        public void UpdateIngameAccount(IIngameAccount ingameAccount)
        {
            throw new NotImplementedException();
        }
        //hier mogen ook de goal collection bij komen zodat die weg kan.
    }
}
