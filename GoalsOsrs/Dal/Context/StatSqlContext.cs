using Exceptions.User;
using Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Context
{
    public class StatSqlContext
    {
        //getbyid
        public StatDTO GetStatByID(int id)
        {
            try
            {
                using (SqlConnection conn = DataConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * From [Stat] WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    StatDTO stat = new StatDTO();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stat.Id = (int)reader["Id"];
                            stat.Title = (string)reader["Title"];
                            
                        }
                    }
                    return (stat);
                }
            }
            catch (SqlException)
            {
                throw new NotImplementedException();
            }
        }
        //update

    }
}
