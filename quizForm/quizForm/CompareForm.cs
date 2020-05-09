using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizForm
{
    public partial class CompareForm : Form
    {

        private SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\winforms\quizForm\quizForm\TryOut.mdf;Integrated Security = True");

        private SqlCommand sqlCommand;
        private SqlDataReader dataReader;

        private String sql = "";

        private String tableName = "Compare";
        private int activeAnswer = 0;
        private int questionIndex;

        public CompareForm()
        {
            InitializeComponent();
        }

        private void CompareForm_Activated(object sender, EventArgs e)
        {
            label_anounce.Text = "Зроби свій вибір =) ";
            questionIndex = GenerationOfQuestionIndex();

            FillTextBoxQuestion(questionIndex);
            FillButtonsAnswers(questionIndex);
        }

        #region Logic: Choose question for quiz & change status of question 
        private void FillTextBoxQuestion(int index)
        {
            connection.Open();

            sql = "SELECT FirstNumber,SecondNumber FROM [" + tableName + "] WHERE Id=" + index;
            sqlCommand = new SqlCommand(sql, connection);

            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                label_firstNumber.Text = dataReader.GetValue(0).ToString();
                label_secondNumber.Text = dataReader.GetValue(1).ToString();
            }
            connection.Close();
        }

        private void FillButtonsAnswers(int index)
        {
            connection.Open();

            sql = "SELECT Answer1,Answer2 FROM [" + tableName + "] WHERE Id=" + index;
            sqlCommand = new SqlCommand(sql, connection);

            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                btn_answer1.Text = dataReader.GetValue(0).ToString();
                btn_answer2.Text = dataReader.GetValue(1).ToString();
            }
            connection.Close();
        }

        private int GenerationOfQuestionIndex()
        {
            Random generationNumber = new Random();
            List<int> indexes = new List<int>();
            connection.Open();
            sql = "SELECT Id FROM [" + tableName + "] WHERE Status!=1";
            sqlCommand = new SqlCommand(sql, connection);

            dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                String parseToInt = dataReader.GetValue(0).ToString();
                indexes.Add(Int32.Parse(parseToInt));//add to list all questions which has Status = 0
            }
            connection.Close();
            int randomNumber = generationNumber.Next(indexes.Count());
            int position = indexes.ElementAt(randomNumber);
            return position;
        }

        private void DisableQuestion(int index)
        {

            sql = "UPDATE [" + tableName + "] SET Status=1 WHERE Id=" + index;
           
            sqlCommand = new SqlCommand(sql, connection);
            connection.Open();
            sqlCommand.ExecuteReader();

            connection.Close();

        }//change the status of the question so that in the future it does not appear

        #endregion



        #region Button-clickers 

        private void btn_continue_Click(object sender, EventArgs e)
        {
            if (activeAnswer == 0)
            {
                label_anounce.Text = "Спочатку потрібно вибрати варіант відповіді";
            }
            else
            {
                label_anounce.Text = "Твоя відповідь прийнята =)";
                StatisticalAnalyzer.CheckAnswer(tableName, questionIndex, activeAnswer); //correct-or-nonCorrect answer
                activeAnswer = 0;

                DisableQuestion(questionIndex); // update status of question

                FormPicker.DempingManager(FormPicker.pickIndex); // update list of tables
                //call new question
                if (FormPicker.formContainer.Count != 0)
                {
                    //FormPicker.additionForm.Show();
                    this.Hide();
                    FormPicker.formContainer.ElementAt(FormPicker.numberGeneration()).Show();
                }
                else
                {
                    EndForm endForm = new EndForm();
                    endForm.Show();
                    this.Hide();
                }

            }
        }

        private void btn_answer1_Click(object sender, EventArgs e)
        {
            activeAnswer = 1;
            label_anounce.Text = "Твоя відповідь: " + btn_answer1.Text;
        }

        private void btn_answer2_Click(object sender, EventArgs e)
        {
            activeAnswer = 2;
            label_anounce.Text = "Твоя відповідь: " + btn_answer2.Text;
        }

        #endregion

        
    }
}
