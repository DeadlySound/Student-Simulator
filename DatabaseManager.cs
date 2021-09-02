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
        public static void AddStudentToDatabase(string nickname)
        {
            SqlConnection connection = DatabaseManager.MakeDatabaseConnection();
            connection.Open();
            var insertStudentCommand = new SqlCommand("INSERT INTO Student VALUES (@nickname)", connection);
            insertStudentCommand.Parameters.AddWithValue("@nickname", nickname);
            insertStudentCommand.ExecuteNonQuery();
            connection.Close();
        }

        public static int RetrieveLastStudentId()
        {
            SqlConnection connection = DatabaseManager.MakeDatabaseConnection();
            connection.Open();
            var getStudentIdCommand = new SqlCommand("SELECT TOP(1) ID FROM Student ORDER BY ID DESC", connection);
            var reader = getStudentIdCommand
                .ExecuteReader();
            int StudentId = 0; // this value will be overwritten, but needs to be assigned in order to work
            if (reader.Read())
            {
                StudentId = reader.GetInt32(0);
            }
            connection.Close();
            return StudentId;
        }

        public static List<string> RetrieveListOfSubjectsForTerm(int term, string fieldOfStudy)
        {
            SqlConnection connection = DatabaseManager.MakeDatabaseConnection();
            connection.Open();
            var getListofSubjectsCommand = new SqlCommand(@"SELECT S.[Name] 
                FROM [Subject] S JOIN Field_of_study F ON S.Field_of_study_ID = F.ID 
                WHERE F.[Name] = @fieldOfStudy AND S.Term = @term", connection);
            getListofSubjectsCommand.Parameters.AddWithValue("@term", term);
            getListofSubjectsCommand.Parameters.AddWithValue("@fieldOfStudy", fieldOfStudy);
            var reader = getListofSubjectsCommand.ExecuteReader();
            var tempList = new List<string>();
            while (reader.Read())
            {
                tempList.Add(reader.GetString(0));
            }
            connection.Close();

            return tempList;
        }
        #endregion
    }
}
