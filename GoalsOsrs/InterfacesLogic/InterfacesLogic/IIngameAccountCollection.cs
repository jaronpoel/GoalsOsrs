using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IIngameAccountCollection
    {
        void AddIngameAccount(IIngameAccount ingameAccount);
        List<IIngameAccount> GetAllIngameAccounts();
        IIngameAccount GetIngameAccountByID(int id);
    }
}