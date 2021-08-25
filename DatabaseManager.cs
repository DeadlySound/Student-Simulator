using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Simulator
{
    public class DatabaseManager
    {
        #region Database operations
        public static SqlConnection MakeDatabaseConnection()
        {
            return new SqlConnection("Server=.;Database=Student_Simulator;Integrated Security=True;");
        }
        public static void OpenDatabaseConnection(SqlConnection connection)
        {
            connection.Open();
        }

        public static void CloseDatabaseConnection(SqlConnection connection)
        {
            connection.Close();
        }

        #endregion
    }
}
