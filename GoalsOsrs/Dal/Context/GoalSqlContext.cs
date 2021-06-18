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
    public class GoalSqlContext : IGoalDal, IGoalCollectionDal
    {

        //add
        public void AddGoal(GoalDTO goal)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    //nog een goal aanmaken koppelen accounts
                    int Accid = 1;

                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
<<<<<<< HEAD
                    command.CommandText = "INSERT INTO [Goal] (IngameAccountID, Title, Item, Description, Status, Kind) VALUES (@IngameAccountID, @Title, @Item, @Description, @Status, @Kind)";
                    command.Parameters.AddWithValue("@IngameAccountID", goal.AccountId);
                    command.Parameters.AddWithValue("@Item", goal.Item);
=======
                    command.CommandText = "INSERT INTO [Goal] (Title, Level, Description, IngameAccountID, Kind) VALUES (@Title, @Level, @Description, @AccId, @Kind)";
                    command.Parameters.AddWithValue("@Title", goal.Title);
                    command.Parameters.AddWithValue("@AccId", Accid);
                    command.Parameters.AddWithValue("@Level", goal.Level);
>>>>>>> main
                    command.Parameters.AddWithValue("@Description", goal.Description);
                    command.Parameters.AddWithValue("@Status", "NotStarted");
                    command.Parameters.AddWithValue("@Kind", goal.Kind);
                    command.Parameters.AddWithValue("@Title", goal.Title);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw new AddGoalFailedException("An unexpected error occured.");
            }
        }

        //update
        public void UpdateGoal(GoalDTO goal)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE [Goal] SET Item = @Item, Description = @Description, Kind = @Kind, Status = @Status, Title = @Title WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", goal.Id);
                    command.Parameters.AddWithValue("@Item", goal.Item);
                    command.Parameters.AddWithValue("@Description", goal.Description);
                    command.Parameters.AddWithValue("@Kind", goal.Kind);
                    command.Parameters.AddWithValue("@Status", goal.Status);
                    command.Parameters.AddWithValue("@Title", goal.Title);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw new UpdateGoalFailedException("An unexpected error occured.");
            }
        }

        //delete
        public void DeleteGoal(int id)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM [Goal] WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw new DeleteGoalFailedException("An unexpected error occured.");
            }
        }

        //getAll
        public List<GoalDTO> GetAllGoalsByIngameAccount(int AccId)
        {
            try
            {
                using (SqlConnection conn = DataConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Goal WHERE IngameAccountID = @id";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Id", AccId);
                    command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    List<GoalDTO> AllGoals = new List<GoalDTO>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        GoalDTO goal = new GoalDTO();

                        int.TryParse(dr[0].ToString(), out int id);
                        goal.Id = id;
                        int.TryParse(dr[1].ToString(), out int Accountid);
                        goal.AccountId = Accountid;
                        goal.Title = dr[2].ToString();
                        goal.Item = dr[3].ToString();
                        goal.Description = dr[4].ToString();
                        goal.Status  = dr[5].ToString();
                        goal.Kind = dr[6].ToString();

                        AllGoals.Add(goal);
                    }
                    return (AllGoals);
                }
            }
            catch (SqlException)
            {
                throw new GetGoalFailedException("An unexpected error occured.");
            }
        }

        //getById                                                                                                                          
        public GoalDTO GetByIDGoals(int id)
        {
            try
            {
                using (SqlConnection conn = DataConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * From Goal WHERE Id=@id";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    GoalDTO goal = new GoalDTO();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            goal.Id = (int)reader["Id"];
                            goal.Title = (string)reader["Title"];
                            goal.Description = (string)reader["Description"];
                            goal.Kind = (string)reader["Kind"];
                            goal.Item = (string)reader["Item"];
                        }
                    }
                    return (goal);
                }
            }
            catch (SqlException)
            {
                throw new GetGoalFailedException("An unexpected error occured.");
            }
        }
    }
}
