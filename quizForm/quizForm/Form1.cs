using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizForm
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\winforms\quizForm\quizForm\TryOut.mdf;Integrated Security = True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Static.CountDemping();
            //textBox1.Text = Static.RANDOM();
            connection.Open();
            //

            SqlCommand sqlCom;

            SqlDataReader dataReader;

            String Output = "";
            String sql = "";

            sql = "UPDATE [Addition] SET Status=0 WHERE Status=1";

            sqlCom = new SqlCommand(sql, connection);

            dataReader = sqlCom.ExecuteReader();


            while (dataReader.Read())
            {
                Output += dataReader.GetValue(0) + "\n";

            }


            textBox1.Text += "1";
            //
            connection.Close();
            connection.Open();
            //

            //SqlCommand sqlCom;

            
            sql = "UPDATE [Generalization] SET Status=0 WHERE Status=1";

            sqlCom = new SqlCommand(sql, connection);

            dataReader = sqlCom.ExecuteReader();


            while (dataReader.Read())
            {
                Output += dataReader.GetValue(0) + "\n";

            }


            textBox1.Text += "2";
            //
            connection.Close();

            connection.Open();

            sql = "UPDATE [SubtractionEqual] SET Status=0 WHERE Status=1";

            sqlCom = new SqlCommand(sql, connection);

            dataReader = sqlCom.ExecuteReader();


            while (dataReader.Read())
            {
                Output += dataReader.GetValue(0) + "\n";

            }

            textBox1.Text += "3";
            //
            connection.Close();

        }

        public void Caller() {
            Static.CountDemping();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Static.CountDemping();
            textBox1.Text = Static.count.ToString();



            connection.Open();
            //

            SqlCommand sqlCom;
          
            SqlDataReader dataReader;

            String Output = "";
            String sql = "";

            sql = "SELECT COUNT(Id) FROM [SubtractionEqual] WHERE Status!=1";

            sqlCom = new SqlCommand(sql, connection);

            dataReader = sqlCom.ExecuteReader();


            while (dataReader.Read())
            {
                Output += dataReader.GetValue(0) + "\n";

            }

            textBox1.Text = Output;
            //
            connection.Close();

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //FormPicker.additionForm.Show();
            FormPicker.formContainer.ElementAt(FormPicker.numberGeneration()).Show();
            this.Hide();
        } // start quiz method. Open First question of quiz

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                            "░░░░░░░░░░▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄░░░░░░░░░\n" +
                            "░░░░░░░░▄▀░░░░░░░░░░░░▄░░░░░░░▀▄░░░░░░░\n" +
                            "░░░░░░░░█░░▄░░░░▄░░░░░░░░░░░░░░█░░░░░░░\n" +
                            "░░░░░░░░█░░░░░░░░░░░░▄█▄▄░░▄░░░█░▄▄▄░░░\n" +
                            "░▄▄▄▄▄░░█░░░░░░▀░░░░▀█░░▀▄░░░░░█▀▀░██░░\n" +
                            "░██▄▀██▄█░░░▄░░░░░░░██░░░░▀▀▀▀▀░░░░██░░\n" +
                            "░░▀██▄▀██░░░░░░░░▀░██▀░░░░░░░░░░░░░▀██░\n" +
                            "░░░░▀████░▀░░░░▄░░░██░░░▄█░░░░▄░▄█░░██░\n" +
                            "░░░░░░░▀█░░░░▄░░░░░██░░░░▄░░░▄░░▄░░░██░\n" +
                            "░░░░░░░▄█▄░░░░░░░░░░░▀▄░░▀▀▀▀▀▀▀▀░░▄▀░░\n" +
                            "░░░░░░█▀▀█████████▀▀▀▀████████████▀░░░░\n" +
                            "░░░░░░████▀░░███▀░░░░░░▀███░░▀██▀░░░░░░\n" +
                            "░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░";
            DBManager.RestoreStatusOfAllQuestions();
            //Console.WriteLine("Bye!");
            ////this.Hide(); 
            ////MessageBox.Show("Caramba");
            //Thread.Sleep(5000);
            //this.Close();
            ////Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string path = Path.Combine(Environment.CurrentDirectory, @"TryOut.mdf");

            actionaction(textBox1);
        }

        private void actionaction(TextBox tb) {
            tb.Text = "AlohaBitch";
            
        }
    }
}
