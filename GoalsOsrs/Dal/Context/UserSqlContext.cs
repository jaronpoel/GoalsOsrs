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
    public class UserSqlContext : IUserDal, IUserCollectionDal
    {
        //add
        public void AddUser(string name, string password, string email)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO [User] (Email, Name, Password) VALUES (@Email, @Name, @Password)";
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Username", name);
                    command.Parameters.AddWithValue("@Password", password);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw new SignUpFailedException("An unexpected error occured.");
            }
        }
        //delete
        public void DeleteUser(int id)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM [User] WHERE @Id = id;";
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw new NotImplementedException();
            }
        }
        //getbyid
        public UserDTO GetUserByID(int id)
        {
            try
            {
                using (SqlConnection conn = DataConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * From [User] WHERE Id=@id";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    UserDTO user = new UserDTO();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.Id = (int)reader["Id"];
                            user.Name = (string)reader["Name"];
                            user.Email = (string)reader["Email"];
                            user.Password = (string)reader["Password"];
                        }
                    }
                    return (user);
                }
            }
            catch (SqlException)
            {
                throw new NotImplementedException();
            }
        }
        //update
        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
        //signin
        public UserDTO SignIn(string email, string password)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Email = @Email AND Password = @Password", connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    if ((int)command.ExecuteScalar() == 1)
                    {
                        SqlCommand scommand = new SqlCommand("SELECT ID, Name FROM [User] WHERE Email = @Email", connection);
                        scommand.Parameters.AddWithValue("@Email", email);
                        SqlDataReader reader = scommand.ExecuteReader();
                        while (reader.Read())
                        {
                            return new UserDTO()
                            {
                                Id = (int)reader["ID"],
                                Name = (string)reader["Name"],
                            };
                        }
                    }
                    throw new AuthenticationFailedException("Incorrect username or password.");
                }
            }
            catch (SqlException)
            {
                throw new AuthenticationFailedException("An unexpected error occured.");
            }
        }
    }
}
