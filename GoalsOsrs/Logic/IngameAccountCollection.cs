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
    public class IngameAccountCollection: IIngameAccountCollection
    {
        //Factory aanroepen
        private readonly IIngameAccountCollectionDal IngameAccountCollectionDAL;
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
        }

        public IIngameAccount GetIngameAccountByID(int id)
        {
            IngameAccountDTO ingameDTO = IngameAccountCollectionDAL.GetByIDIngameAccount(id);
            IngameAccount ingameAccount = new IngameAccount(ingameDTO.Id, ingameDTO.Username, ingameDTO.Type);
            return ingameAccount;
        }
    }
}
