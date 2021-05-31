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
        //Thuis
        //private static readonly string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jaron\Desktop\School\Nieuw\GoalsOsrs\GoalsOsrs\Dal\DatabaseOsrs.mdf";

        // School 
        private static readonly string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jaatj\OneDrive\Bureaublad\GoalsOsrs\GoalsOsrs\Dal\DatabaseOsrs.mdf";

        //Online
        //private static readonly string ConnectionString = "Data Source=mssql.fhict.local; Initial Catalog=dbi392219; Persist Security Info=True; User ID=dbi392219; Password=Masu1996";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
