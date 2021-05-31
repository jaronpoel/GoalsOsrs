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
    public class IngameAccountSqlContext : IIngameAccountCollectionDal, IIngameAccountDal
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
                    command.CommandText = "INSERT INTO [IngameAccount] (Name, Type, UserID) VALUES (@Username, @Type, 1)";
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
            try
            {
                using (SqlConnection conn = DataConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM IngameAccount WHERE UserID = 1";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    List<IngameAccountDTO> AllIngameAccounts = new List<IngameAccountDTO>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        IngameAccountDTO ingameAccount = new IngameAccountDTO();

                        int.TryParse(dr[0].ToString(), out int id);
                        ingameAccount.Id = id;
                        ingameAccount.Username = dr[2].ToString();
                        ingameAccount.Type = dr[3].ToString();


                        AllIngameAccounts.Add(ingameAccount);
                    }
                    return (AllIngameAccounts);
                }
            }
            catch (SqlException)
            {
                throw new GetIngameAccountFailedException("An unexpected error occured.");
            }
        }

        //getById
        public IngameAccountDTO GetByIDIngameAccount(int id)
        {
            try
            {
                using (SqlConnection conn = DataConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * From IngameAccount WHERE Id=@id";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    IngameAccountDTO ingameAccount = new IngameAccountDTO();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ingameAccount.Id = (int)reader["Id"];
                            ingameAccount.Username = (string)reader["Name"];
                            ingameAccount.Type = (string)reader["Type"];
                        }
                    }
                    return (ingameAccount);
                }
            }
            catch (SqlException)
            {
                throw new GetIngameAccountFailedException("An unexpected error occured.");
            }
        }
    }
}
