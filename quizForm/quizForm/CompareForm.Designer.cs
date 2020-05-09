namespace quizForm
{
    partial class CompareForm
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
            this.label_anounce = new System.Windows.Forms.Label();
            this.btn_continue = new System.Windows.Forms.Button();
            this.textBox_themeTitle = new System.Windows.Forms.TextBox();
            this.label_firstNumber = new System.Windows.Forms.Label();
            this.label_secondNumber = new System.Windows.Forms.Label();
            this.label_sign = new System.Windows.Forms.Label();
            this.btn_answer2 = new System.Windows.Forms.Button();
            this.btn_answer1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_anounce
            // 
            this.label_anounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_anounce.Location = new System.Drawing.Point(12, 254);
            this.label_anounce.Name = "label_anounce";
            this.label_anounce.Size = new System.Drawing.Size(485, 102);
            this.label_anounce.TabIndex = 12;
            this.label_anounce.Text = "label1";
            this.label_anounce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_continue
            // 
            this.btn_continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_continue.Location = new System.Drawing.Point(154, 373);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(208, 54);
            this.btn_continue.TabIndex = 11;
            this.btn_continue.Text = "Продовжити =>";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // textBox_themeTitle
            // 
            this.textBox_themeTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_themeTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_themeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_themeTitle.Location = new System.Drawing.Point(127, 22);
            this.textBox_themeTitle.Multiline = true;
            this.textBox_themeTitle.Name = "textBox_themeTitle";
            this.textBox_themeTitle.ReadOnly = true;
            this.textBox_themeTitle.Size = new System.Drawing.Size(255, 42);
            this.textBox_themeTitle.TabIndex = 10;
            this.textBox_themeTitle.Text = "Порівняння";
            this.textBox_themeTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_firstNumber
            // 
            this.label_firstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_firstNumber.Location = new System.Drawing.Point(121, 85);
            this.label_firstNumber.Name = "label_firstNumber";
            this.label_firstNumber.Size = new System.Drawing.Size(66, 62);
            this.label_firstNumber.TabIndex = 13;
            this.label_firstNumber.Text = "10";
            this.label_firstNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_secondNumber
            // 
            this.label_secondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_secondNumber.Location = new System.Drawing.Point(316, 85);
            this.label_secondNumber.Name = "label_secondNumber";
            this.label_secondNumber.Size = new System.Drawing.Size(66, 62);
            this.label_secondNumber.TabIndex = 14;
            this.label_secondNumber.Text = "10";
            this.label_secondNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_sign
            // 
            this.label_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sign.Location = new System.Drawing.Point(221, 85);
            this.label_sign.Name = "label_sign";
            this.label_sign.Size = new System.Drawing.Size(66, 62);
            this.label_sign.TabIndex = 15;
            this.label_sign.Text = "?";
            this.label_sign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_answer2
            // 
            this.btn_answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_answer2.Location = new System.Drawing.Point(298, 174);
            this.btn_answer2.Name = "btn_answer2";
            this.btn_answer2.Size = new System.Drawing.Size(112, 54);
            this.btn_answer2.TabIndex = 17;
            this.btn_answer2.UseVisualStyleBackColor = true;
            this.btn_answer2.Click += new System.EventHandler(this.btn_answer2_Click);
            // 
            // btn_answer1
            // 
            this.btn_answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_answer1.Location = new System.Drawing.Point(108, 174);
            this.btn_answer1.Name = "btn_answer1";
            this.btn_answer1.Size = new System.Drawing.Size(112, 54);
            this.btn_answer1.TabIndex = 16;
            this.btn_answer1.UseVisualStyleBackColor = true;
            this.btn_answer1.Click += new System.EventHandler(this.btn_answer1_Click);
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 451);
            this.Controls.Add(this.btn_answer2);
            this.Controls.Add(this.btn_answer1);
            this.Controls.Add(this.label_sign);
            this.Controls.Add(this.label_secondNumber);
            this.Controls.Add(this.label_firstNumber);
            this.Controls.Add(this.label_anounce);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.textBox_themeTitle);
            this.Name = "CompareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompareForm";
            this.Activated += new System.EventHandler(this.CompareForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_anounce;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.TextBox textBox_themeTitle;
        private System.Windows.Forms.Label label_firstNumber;
        private System.Windows.Forms.Label label_secondNumber;
        private System.Windows.Forms.Label label_sign;
        private System.Windows.Forms.Button btn_answer2;
        private System.Windows.Forms.Button btn_answer1;
    }
}