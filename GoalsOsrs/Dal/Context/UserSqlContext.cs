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
    public class UserSqlContext : IUser, IUserCollection
    {
        //add
        public void AddUser()
        {
            throw new NotImplementedException();
        }
        //delete
        public void DeleteUser()
        {
            throw new NotImplementedException();
        }
        //getbyid
        public void GetUserByID()
        {
            throw new NotImplementedException();
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
