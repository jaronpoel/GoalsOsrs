using Exceptions.Goal;
using Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Context
{
    public class GoalSqlContext
    {
        //add
        public void AddGoal()
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO [Goal] () VALUES ()";
                    //parameters erin zetten
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw new AddGoalFailedException("An unexpected error occured.");
            }
        }
        //update
        //delete
        //getall
        //getbyid
    }
}
