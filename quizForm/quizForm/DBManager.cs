using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace quizForm
{
    class DBManager
    {

        static String dbPath = Path.Combine(Environment.CurrentDirectory, @"TryOut.mdf"); //path - we need const vars
        private static readonly String connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + dbPath + ";Integrated Security = True";

        private const String Addition = "Addition"; // Need to create new final class with constants
        private const String Generalization = "Generalization";
        private const String SubtractionEqual = "SubtractionEqual";
        private const String Compare = "Compare";

        //private void TakeQuestionFromDB(int questionId, String tableName)
        //{
        //    connection.Open();

        //    sql = "SELECT Question FROM [" + tableName + "] WHERE Id=" + index;
        //    sqlCommand = new SqlCommand(sql, connection);

        //    dataReader = sqlCommand.ExecuteReader();
        //    while (dataReader.Read())
        //    {
        //        textBox_question.Text = dataReader.GetValue(0).ToString();
        //    }
        //    connection.Close();
        //}
        public static int TakeTrueFromDB(String tableName, int questionId)
        {
            int correctAnswer = 0;

            string queryString = "SELECT True FROM [" + tableName + "] WHERE Id=" + questionId;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String parseToInt = dataReader.GetValue(0).ToString();
                    correctAnswer = Int32.Parse(parseToInt);
                }

                dataReader.Close();
            }
            return correctAnswer;
        }

        public static void RestoreStatusOfAllQuestions()
        {
            RestoreStatusInTable(Addition);
            RestoreStatusInTable(Generalization);
            RestoreStatusInTable(SubtractionEqual);
            RestoreStatusInTable(Compare);
        }

        public static void RestoreStatusInTable(String tableName)
        {
            string queryString = "UPDATE [" + tableName + "] SET Status=0 WHERE Status=1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();

                sqlCommand.ExecuteReader();
            }
        }
    }
}
