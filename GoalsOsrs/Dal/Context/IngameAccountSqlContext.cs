using Exceptions.Goal;
using Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Context
{
    public class IngameAccountSqlContext : IIngameAccountCollection, IIngameAccount
    {

        //add
        public void AddIngameAccount(IngameAccountDTO ingameAccount)
        {
            throw new NotImplementedException();
        }

        //update
        public void UpdateIngameAccount(IngameAccountDTO ingameAccount)
        {
            throw new NotImplementedException();
        }

        //delete
        public void DeleteIngameAccount(int id)
        {
            throw new NotImplementedException();
        }

        //getAll
        public List<IngameAccountDTO> GetAllIngameAccounts()
        {
            throw new NotImplementedException();
        }

        //getById
        public IngameAccountDTO GetByIDIngameAccount(int id)
        {
            throw new NotImplementedException();
        }
    }
}
