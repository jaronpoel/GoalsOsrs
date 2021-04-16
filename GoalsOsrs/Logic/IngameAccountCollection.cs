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
    public class IngameAccountCollection
    {
        //Factory aanroepen
        private readonly IIngameAccountCollection IngameAccountCollectionDAL;
        public IngameAccountCollection()
        {
            IngameAccountCollectionDAL = FactoryDal.CreateIngameAccounCollectiontDal();
        }

        //Begin van de Methodes aanroepen

        public void AddIngameAccount(IngameAccount ingameAccount)
        {
            IngameAccountDTO ingameAccountDTO = new IngameAccountDTO(ingameAccount.Username, ingameAccount.Type);
            IngameAccountCollectionDAL.AddIngameAccount(ingameAccountDTO);
        }

        public IngameAccount GetIngameAccountByID(int id)
        {
            IngameAccountDTO ingameDTO = IngameAccountCollectionDAL.GetByIDIngameAccount(id);
            IngameAccount ingameAccount = new IngameAccount(ingameDTO.Id, ingameDTO.Username, ingameDTO.Type);
            return ingameAccount;
        }

        public List<IngameAccount> GetAllIngameAccounts()
        {
            List<IngameAccountDTO> IngameAccountsDTO = IngameAccountCollectionDAL.GetAllIngameAccounts();
            List<IngameAccount> IngameAccounts = new List<IngameAccount>();
            foreach (IngameAccountDTO IngameAccountDTO in IngameAccountsDTO)
            {
                IngameAccounts.Add(new IngameAccount(IngameAccountDTO.Id, IngameAccountDTO.Username, IngameAccountDTO.Type));
            }
            return IngameAccounts;
        }
    }
}
