using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizForm
{
    public partial class InsideForm : Form
    {
        public InsideForm()
        {
            InitializeComponent();
        }

        private void InsideForm_Load(object sender, EventArgs e)
        {
            
            if (FormPicker.formContainer.Count != 0)
            {
                //FormPicker.additionForm.Show();
                FormPicker.formContainer.ElementAt(FormPicker.numberGeneration()).Show();
            }
            else
            {
                EndForm endForm = new EndForm();
                endForm.Show();
            }
        }

        
    }
}
