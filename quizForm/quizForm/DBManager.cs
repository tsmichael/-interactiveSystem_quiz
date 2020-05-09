using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace quizForm
{
    class DBManager
    {

        static String dbPath = Path.Combine(Environment.CurrentDirectory, @"TryOut.mdf"); //path - we need const vars
        private static readonly String connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + dbPath + ";Integrated Security = True";

        private const String Addition = "Addition"; // TODO create new final class with constants
        private const String Generalization = "Generalization";
        private const String SubtractionEqual = "SubtractionEqual";
        private const String Compare = "Compare";

        public static void TakeQuestionFromDB(int questionId, String tableName, TextBox questionField)
        {
            String queryString = "SELECT Question FROM [" + tableName + "] WHERE Id=" + questionId;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    questionField.Text = dataReader.GetValue(0).ToString();
                }

                dataReader.Close();
            }
        }

        public static void TakeQuestionFromDB(int questionId, String tableName, Label l1, Label l2)
        {
            String queryString = "SELECT FirstNumber,SecondNumber FROM [" + tableName + "] WHERE Id=" + questionId;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    l1.Text = dataReader.GetValue(0).ToString();
                    l2.Text = dataReader.GetValue(1).ToString();
                }

                dataReader.Close();
            }
        }

        public static void TakeAnswersFromDB(int questionId, String tableName, Button btn1, Button btn2, Button btn3, Button btn4)
        {
            String queryString = "SELECT Answer1,Answer2,Answer3,Answer4 FROM [" + tableName + "] WHERE Id=" + questionId;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    btn1.Text = dataReader.GetValue(0).ToString();
                    btn2.Text = dataReader.GetValue(1).ToString();
                    btn3.Text = dataReader.GetValue(2).ToString();
                    btn4.Text = dataReader.GetValue(3).ToString();
                }

                dataReader.Close();
            }
        }

        public static void TakeAnswersFromDB(int questionId, String tableName, Button btn1, Button btn2)
        {
            String queryString = "SELECT Answer1,Answer2 FROM [" + tableName + "] WHERE Id=" + questionId;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    btn1.Text = dataReader.GetValue(0).ToString();
                    btn2.Text = dataReader.GetValue(1).ToString();
                }

                dataReader.Close();
            }
        }

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

        public static void BlockQuestionSession(int questionId, String tableName)
        {
            string queryString = "UPDATE [" + tableName + "] SET Status=1 WHERE Id=" + questionId;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();

                sqlCommand.ExecuteReader();
            }
        }

        public static List<int> TakeIdFromDB(String tableName) 
        {
            List<int> idList = new List<int>();
            String queryString = "SELECT Id FROM [" + tableName + "] WHERE Status!=1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String parseToInt = dataReader.GetValue(0).ToString();
                    idList.Add(Int32.Parse(parseToInt));//add to list all questions which has Status == 0
                }

                dataReader.Close();
            }
            return idList;
        }
    }
}
