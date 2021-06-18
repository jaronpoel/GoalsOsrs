using Dal.Context;
using Exceptions.IngameAccount;
using Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unittests.TestDal
{
    class IngameAccountTestDal : IIngameAccountCollectionDal, IIngameAccountDal
    {
        List<IngameAccountDTO> ingameAccounts = new List<IngameAccountDTO>();

        public IngameAccountTestDal()
        {
            List<IngameAccountDTO> ingameAccounts = new List<IngameAccountDTO>()
            {
                new IngameAccountDTO(1, "Jaron", "Ironman"),
                new IngameAccountDTO(2, "Poel", "Hardcore ironman"),
            };
        }

        public void AddIngameAccount(IngameAccountDTO ingameAccount)
        {
            try
            {
                ingameAccounts.Add(ingameAccount);
            }
            catch
            {
                throw new AddIngameAccountFailedException();
            }
        }

        public List<IngameAccountDTO> GetAllIngameAccounts()
        {
            return ingameAccounts;
        }

        public IngameAccountDTO GetByIDIngameAccount(int id)
        {
            foreach (var ingameAccount in ingameAccounts)
            {
                if (ingameAccount.Id == id)
                {
                    return ingameAccount;
                }
            }
            throw new GetIngameAccountFailedException("An unexpected error occured.");
        }

        public void UpdateIngameAccount(IngameAccountDTO ingameAccount)
        {
            throw new NotImplementedException();
        }
    }
}
