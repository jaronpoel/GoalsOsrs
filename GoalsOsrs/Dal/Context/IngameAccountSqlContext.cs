using Exceptions.IngameAccount;
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
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO [IngameAccount] () VALUES ()";
                    command.Parameters.AddWithValue("@Username", ingameAccount.Username);
                    command.Parameters.AddWithValue("@Type", ingameAccount.Type);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw new AddIngameAccountFailedException("An unexpected error occured.");
            }
        }

        //update
        public void UpdateIngameAccount(IngameAccountDTO ingameAccount)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE [IngameAccount] () VALUES () WHERE Id = @Id";
                    //parameters
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw new UpdateIngameAccountFailedException("An unexpected error occured.");
            }
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
