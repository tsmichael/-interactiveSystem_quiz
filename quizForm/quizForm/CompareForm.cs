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
        private String tableName = "Compare";
        private int activeAnswer = 0;
        private int questionId;

        public CompareForm()
        {
            InitializeComponent();
        }

        private void CompareForm_Activated(object sender, EventArgs e)
        {
            label_anounce.Text = "Зроби свій вибір =) ";
            questionId = Tool.ChooseIDForQuestion(tableName);

            FillTextBoxQuestion(questionId, tableName, label_firstNumber, label_secondNumber);
            FillButtonsAnswers(questionId, tableName, btn_answer1, btn_answer2);
        }

        #region Logic: Choose question for quiz & change status of question 
        private void FillTextBoxQuestion(int questionId, String tableName, Label l1, Label l2)
        {
            DBManager.TakeQuestionFromDB(questionId, tableName, l1, l2);
        }

        private void FillButtonsAnswers(int questionId, String tableName,Button button1, Button button2)
        {
            DBManager.TakeAnswersFromDB(questionId, tableName, button1, button2);
        }

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
                StatisticalAnalyzer.CheckAnswer(tableName, questionId, activeAnswer); //correct-or-nonCorrect answer
                activeAnswer = 0;

                // Update status of question
                DBManager.BlockQuestionSession(questionId, tableName);
                // Update list of tables
                FormPicker.DempingManager(FormPicker.pickIndex);
                // Call new question
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

        #endregion


    }
}
