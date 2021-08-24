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

        public SqlConnection OpenDatabaseConnection()
        {
            return new SqlConnection("Server=.;Database=Student_Simulator;Integrated Security=True;");
        }
        public void CloseDatabaseConnection(SqlConnection connection)
        {
            connection.Close();
        }

        #endregion

    }
}
