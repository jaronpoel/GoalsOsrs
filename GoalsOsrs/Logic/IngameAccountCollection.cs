using Dal.Context;
using Factory;
using Interfaces.DTO;
<<<<<<< HEAD
using Logic.Interfaces;
=======
using Logic.Interfaces;
>>>>>>> main
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class IngameAccountCollection: IIngameAccountCollection
    {
        //Factory aanroepen
        private readonly IIngameAccountCollectionDal IngameAccountCollectionDAL;
<<<<<<< HEAD

=======
>>>>>>> main
        public IngameAccountCollection(IIngameAccountCollectionDal ingameAccountCollectionDal)
        {
            IngameAccountCollectionDAL = ingameAccountCollectionDal;
        }

        //Begin van de Methodes aanroepen

        public void AddIngameAccount(IIngameAccount ingameAccount)
        {
            IngameAccountDTO ingameAccountDTO = new IngameAccountDTO(ingameAccount.Username, ingameAccount.Type);
            IngameAccountCollectionDAL.AddIngameAccount(ingameAccountDTO);
        }

        public List<IIngameAccount> GetAllIngameAccounts()
        {
            List<IngameAccountDTO> IngameAccountsDTO = IngameAccountCollectionDAL.GetAllIngameAccounts();
            List<IIngameAccount> IngameAccounts = new List<IIngameAccount>();
            foreach (IngameAccountDTO IngameAccountDTO in IngameAccountsDTO)
            {
                IngameAccounts.Add(new IngameAccount(IngameAccountDTO.Id, IngameAccountDTO.Username, IngameAccountDTO.Type));
            }
            return IngameAccounts;
<<<<<<< HEAD
        }

        public IIngameAccount GetIngameAccountByID(int id)
        {
            IngameAccountDTO ingameDTO = IngameAccountCollectionDAL.GetByIDIngameAccount(id);
            List<IStat> stats = new List<IStat>();
            foreach (StatDTO stat in ingameDTO.Stats)
            {
                stats.Add(new Stat(stat.Id, stat.Title, stat.Value));
            }
            IngameAccount ingameAccount = new IngameAccount(ingameDTO.Id, ingameDTO.Username, ingameDTO.Type, stats);
            return ingameAccount;
        }
=======
        }

        public IIngameAccount GetIngameAccountByID(int id)
        {
            IngameAccountDTO ingameDTO = IngameAccountCollectionDAL.GetByIDIngameAccount(id);
            IngameAccount ingameAccount = new IngameAccount(ingameDTO.Id, ingameDTO.Username, ingameDTO.Type);
            return ingameAccount;
        }
>>>>>>> main
    }
}
