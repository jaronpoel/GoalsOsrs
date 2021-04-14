using Interfaces.DTO;
using System.Collections.Generic;

namespace Dal.Context
{
    public interface IIngameAccountCollection
    {
        void AddIngameAccount(IngameAccountDTO ingameAccount);
        void DeleteIngameAccount(int id);
        List<IngameAccountDTO> GetAllIngameAccounts();
        IngameAccountDTO GetByIDIngameAccount(int id);
    }
}