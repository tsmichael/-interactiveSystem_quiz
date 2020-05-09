using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace quizForm
{
    class DBManager
    {
        private static SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\winforms\quizForm\quizForm\TryOut.mdf;Integrated Security = True");

        private static SqlCommand sqlCommand;
        private static SqlDataReader dataReader;

        private static String sql = "";

        private const String Addition = "Addition";
        private const String Generalization = "Generalization";
        private const String SubtractionEqual = "SubtractionEqual";
        private const String Compare = "Compare";

        public static int TakeTrueFromDB(String tableName, int questionId)
        {
            int correctAnswer = 0;
            sql = "SELECT True FROM [" + tableName + "] WHERE Id=" + questionId;
            sqlCommand = new SqlCommand(sql, connection);
            connection.Open();
            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                String parseToInt = dataReader.GetValue(0).ToString();
                correctAnswer = Int32.Parse(parseToInt);
            }
            connection.Close();
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
            connection.Open();

            sql = "UPDATE ["+ tableName +"] SET Status=0 WHERE Status=1";

            sqlCommand = new SqlCommand(sql, connection);

            sqlCommand.ExecuteReader();

            connection.Close();
        }

        




    }
}
