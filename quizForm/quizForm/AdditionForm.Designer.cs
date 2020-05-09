namespace quizForm
{
    partial class AdditionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_themeTitle = new System.Windows.Forms.TextBox();
            this.btn_answer1 = new System.Windows.Forms.Button();
            this.btn_answer2 = new System.Windows.Forms.Button();
            this.btn_answer3 = new System.Windows.Forms.Button();
            this.btn_answer4 = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.textBox_question = new System.Windows.Forms.TextBox();
            this.label_anounce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_themeTitle
            // 
            this.textBox_themeTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_themeTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_themeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_themeTitle.Location = new System.Drawing.Point(131, 36);
            this.textBox_themeTitle.Multiline = true;
            this.textBox_themeTitle.Name = "textBox_themeTitle";
            this.textBox_themeTitle.ReadOnly = true;
            this.textBox_themeTitle.Size = new System.Drawing.Size(255, 42);
            this.textBox_themeTitle.TabIndex = 1;
            this.textBox_themeTitle.Text = "Додавання";
            this.textBox_themeTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_answer1
            // 
            this.btn_answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_answer1.Location = new System.Drawing.Point(37, 194);
            this.btn_answer1.Name = "btn_answer1";
            this.btn_answer1.Size = new System.Drawing.Size(88, 54);
            this.btn_answer1.TabIndex = 3;
            this.btn_answer1.UseVisualStyleBackColor = true;
            this.btn_answer1.Click += new System.EventHandler(this.btn_answer1_Click);
            // 
            // btn_answer2
            // 
            this.btn_answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_answer2.Location = new System.Drawing.Point(154, 194);
            this.btn_answer2.Name = "btn_answer2";
            this.btn_answer2.Size = new System.Drawing.Size(88, 54);
            this.btn_answer2.TabIndex = 4;
            this.btn_answer2.UseVisualStyleBackColor = true;
            this.btn_answer2.Click += new System.EventHandler(this.btn_answer2_Click);
            // 
            // btn_answer3
            // 
            this.btn_answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_answer3.Location = new System.Drawing.Point(274, 194);
            this.btn_answer3.Name = "btn_answer3";
            this.btn_answer3.Size = new System.Drawing.Size(88, 54);
            this.btn_answer3.TabIndex = 5;
            this.btn_answer3.UseVisualStyleBackColor = true;
            this.btn_answer3.Click += new System.EventHandler(this.btn_answer3_Click);
            // 
            // btn_answer4
            // 
            this.btn_answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_answer4.Location = new System.Drawing.Point(392, 194);
            this.btn_answer4.Name = "btn_answer4";
            this.btn_answer4.Size = new System.Drawing.Size(88, 54);
            this.btn_answer4.TabIndex = 6;
            this.btn_answer4.UseVisualStyleBackColor = true;
            this.btn_answer4.Click += new System.EventHandler(this.btn_answer4_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_continue.Location = new System.Drawing.Point(154, 385);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(208, 54);
            this.btn_continue.TabIndex = 7;
            this.btn_continue.Text = "Продовжити =>";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // textBox_question
            // 
            this.textBox_question.AccessibleDescription = "";
            this.textBox_question.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.textBox_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_question.Location = new System.Drawing.Point(37, 114);
            this.textBox_question.Multiline = true;
            this.textBox_question.Name = "textBox_question";
            this.textBox_question.ReadOnly = true;
            this.textBox_question.Size = new System.Drawing.Size(443, 35);
            this.textBox_question.TabIndex = 8;
            this.textBox_question.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_anounce
            // 
            this.label_anounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_anounce.Location = new System.Drawing.Point(12, 266);
            this.label_anounce.Name = "label_anounce";
            this.label_anounce.Size = new System.Drawing.Size(485, 102);
            this.label_anounce.TabIndex = 9;
            this.label_anounce.Text = "label1";
            this.label_anounce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 451);
            this.Controls.Add(this.label_anounce);
            this.Controls.Add(this.textBox_question);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_answer4);
            this.Controls.Add(this.btn_answer3);
            this.Controls.Add(this.btn_answer2);
            this.Controls.Add(this.btn_answer1);
            this.Controls.Add(this.textBox_themeTitle);
            this.Name = "AdditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdditionForm";
            this.Activated += new System.EventHandler(this.AdditionForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_themeTitle;
        private System.Windows.Forms.Button btn_answer1;
        private System.Windows.Forms.Button btn_answer2;
        private System.Windows.Forms.Button btn_answer3;
        private System.Windows.Forms.Button btn_answer4;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.TextBox textBox_question;
        private System.Windows.Forms.Label label_anounce;
    }
}