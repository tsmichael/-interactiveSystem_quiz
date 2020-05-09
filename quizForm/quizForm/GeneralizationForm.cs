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
    public partial class GeneralizationForm : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\winforms\quizForm\quizForm\TryOut.mdf;Integrated Security = True");

        private SqlCommand sqlCommand;
        private SqlDataReader dataReader;

        private String sql = "";

        private String tableName = "Generalization";
        private int activeAnswer = 0;
        private int questionIndex;

        public GeneralizationForm()
        {
            InitializeComponent();
        }

        private void GeneralizationForm_Activated(object sender, EventArgs e)
        {
            label_anounce.Text = "Зроби свій вибір =) ";
            questionIndex = GenerationOfQuestionIndex();

            FillTextBoxQuestion(questionIndex);
            FillButtonsAnswers(questionIndex);
        }

        #region Logic: Choose question for quiz & change status of question 

        private int GenerationOfQuestionIndex()
        {
            Random generationNumber = new Random();
            List<int> indexes = new List<int>();

            sql = "SELECT Id FROM [" + tableName + "] WHERE Status!=1";
            sqlCommand = new SqlCommand(sql, connection);

            connection.Open();
            dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                String parseToInt = dataReader.GetValue(0).ToString();
                indexes.Add(Int32.Parse(parseToInt));//add to list all questions which has Status = 0
            }
            connection.Close();

            int questionIndex = generationNumber.Next(indexes.Count());
            int questionId = indexes.ElementAt(questionIndex);

            return questionId;
        }

        private void FillTextBoxQuestion(int index)
        {
            sql = "SELECT Question FROM [" + tableName + "] WHERE Id=" + index;
            sqlCommand = new SqlCommand(sql, connection);

            connection.Open();
            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                textBox_question.Text = dataReader.GetValue(0).ToString();
            }
            connection.Close();
        }

        private void FillButtonsAnswers(int index)
        {
            sql = "SELECT Answer1,Answer2,Answer3,Answer4 FROM [" + tableName + "] WHERE Id=" + index;
            sqlCommand = new SqlCommand(sql, connection);

            connection.Open();
            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                btn_answer1.Text = dataReader.GetValue(0).ToString();
                btn_answer2.Text = dataReader.GetValue(1).ToString();
                btn_answer3.Text = dataReader.GetValue(2).ToString();
                btn_answer4.Text = dataReader.GetValue(3).ToString();
            }
            connection.Close();
        }

        private void DisableQuestion(int index)
        {

            sql = "UPDATE [" + tableName + "] SET Status=1 WHERE Id=" + index;
            //sql = "UPDATE [" + tableName + "] SET Status=1 WHERE Id=" + index+"";
            sqlCommand = new SqlCommand(sql, connection);
            connection.Open();
            sqlCommand.ExecuteReader();

            connection.Close();

        }//change the status of the question so that in the future it does not appear


        #endregion

        #region Button-Logic

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

        private void btn_answer3_Click(object sender, EventArgs e)
        {
            activeAnswer = 3;
            label_anounce.Text = "Твоя відповідь: " + btn_answer3.Text;
        }

        private void btn_answer4_Click(object sender, EventArgs e)
        {
            activeAnswer = 4;
            label_anounce.Text = "Твоя відповідь: " + btn_answer4.Text;
        }
        #endregion

       
    }
}
