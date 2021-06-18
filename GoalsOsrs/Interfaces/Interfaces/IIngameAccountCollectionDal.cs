using Interfaces.DTO;
using System.Collections.Generic;

namespace Dal.Context
{
    public interface IIngameAccountCollectionDal
    {
        void AddIngameAccount(IngameAccountDTO ingameAccount);
        List<IngameAccountDTO> GetAllIngameAccounts();
        IngameAccountDTO GetByIDIngameAccount(int id);
    }
}