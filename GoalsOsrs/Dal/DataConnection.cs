using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DataConnection
    {
<<<<<<< HEAD
        //Thuis  op git
        //private static readonly string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jaron\Desktop\School\Nieuw\GoalsOsrs\GoalsOsrs\Dal\DatabaseOsrs.mdf";

        // School 
        //private static readonly string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jaatj\OneDrive\Bureaublad\GoalsOsrs-main\GoalsOsrs\Dal\DatabaseOsrs.mdf";

        //Thuis niet op git
         private static readonly string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jaron\Desktop\GoalsOsrs-main\GoalsOsrs\Dal\DatabaseOsrs.mdf";
=======
        //Thuis
        //private static readonly string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jaron\Desktop\School\Nieuw\GoalsOsrs\GoalsOsrs\Dal\DatabaseOsrs.mdf";

        // School 
        private static readonly string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jaatj\OneDrive\Bureaublad\GoalsOsrs\GoalsOsrs\Dal\DatabaseOsrs.mdf";
>>>>>>> main

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
