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
        //signUp
        public UserDTO SignUp(string email, string password, string name)
        {
            try
            {
                using (SqlConnection conn = DataConnection.GetConnection())
                {
                    conn.Open();
                    string query = "IF NOT EXISTS (Select 1 from [User] WHERE Email = @Email) INSERT INTO [User](Email, Name, Password) VALUES (@Email, @Name, @Password) ELSE Throw 50011, '', 1";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.ExecuteNonQuery();

                        UserDTO madeUser = new UserDTO(name, password, email);
                        return madeUser;
                    }
                }
            }
            catch(SqlException)
            {
                return null;
            }
            
        }

        //delete
        public bool DeleteUser(int id)
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
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //getbyid
        public UserDTO GetUserByID(int id)
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
<<<<<<< HEAD
                    while (reader.Read())
=======
                    conn.Open();
                    string query = "SELECT * From [User] WHERE Id=@id";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    UserDTO user = new UserDTO();
                    using (SqlDataReader reader = command.ExecuteReader())
>>>>>>> main
                    {
                        user.Id = (int)reader["Id"];
                        user.Name = (string)reader["Name"];
                        user.Email = (string)reader["Email"];
                        user.Password = (string)reader["Password"];
                    }
                }
                return user;
            }
        }

        //update
        public UserDTO UpdateUser(int id, string name, string password, string email)
        {
            using (SqlConnection conn = DataConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE [User] SET Email = @Email, Name = @Name, Password = @Password WHERE Id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();

                    UserDTO updatedUser = new UserDTO(id, name, password, email);
                    return updatedUser;
                }
            }
        }

        //signin
        public UserDTO SignIn(string email, string password)
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
                return null;
            }
        }
    }
}
