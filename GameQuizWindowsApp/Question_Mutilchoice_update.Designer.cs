namespace GameQuizWindowsApp
{
    partial class Question_Mutilchoice_update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question_Mutilchoice_update));
            textBox_Question = new TextBox();
            textBox_Answer1 = new TextBox();
            textBox_Answer2 = new TextBox();
            textBox_Answer3 = new TextBox();
            textBox_Answer4 = new TextBox();
            btn_Update = new Button();
            btn_Close = new Button();
            textBox_Correct = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox_Question
            // 
            textBox_Question.BackColor = SystemColors.Window;
            textBox_Question.Location = new Point(12, 10);
            textBox_Question.Name = "textBox_Question";
            textBox_Question.Size = new Size(350, 27);
            textBox_Question.TabIndex = 0;
            textBox_Question.Text = "Question";
            // 
            // textBox_Answer1
            // 
            textBox_Answer1.BackColor = SystemColors.Window;
            textBox_Answer1.Location = new Point(41, 58);
            textBox_Answer1.Name = "textBox_Answer1";
            textBox_Answer1.Size = new Size(321, 27);
            textBox_Answer1.TabIndex = 1;
            textBox_Answer1.Text = "Answer1";
            // 
            // textBox_Answer2
            // 
            textBox_Answer2.BackColor = SystemColors.Window;
            textBox_Answer2.Location = new Point(41, 98);
            textBox_Answer2.Name = "textBox_Answer2";
            textBox_Answer2.Size = new Size(321, 27);
            textBox_Answer2.TabIndex = 2;
            textBox_Answer2.Text = "Answer2";
            // 
            // textBox_Answer3
            // 
            textBox_Answer3.BackColor = SystemColors.Window;
            textBox_Answer3.Location = new Point(41, 138);
            textBox_Answer3.Name = "textBox_Answer3";
            textBox_Answer3.Size = new Size(321, 27);
            textBox_Answer3.TabIndex = 3;
            textBox_Answer3.Text = "Answer3";
            // 
            // textBox_Answer4
            // 
            textBox_Answer4.BackColor = SystemColors.Window;
            textBox_Answer4.Location = new Point(41, 178);
            textBox_Answer4.Name = "textBox_Answer4";
            textBox_Answer4.Size = new Size(321, 27);
            textBox_Answer4.TabIndex = 4;
            textBox_Answer4.Text = "Answer4";
            // 
            // btn_Update
            // 
            btn_Update.BackColor = SystemColors.ActiveBorder;
            btn_Update.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Update.Location = new Point(196, 293);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(80, 40);
            btn_Update.TabIndex = 5;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Close
            // 
            btn_Close.BackColor = SystemColors.ActiveBorder;
            btn_Close.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Close.Location = new Point(282, 293);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(80, 40);
            btn_Close.TabIndex = 6;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = false;
            btn_Close.Click += btn_Close_Click;
            // 
            // textBox_Correct
            // 
            textBox_Correct.BackColor = SystemColors.Window;
            textBox_Correct.Location = new Point(86, 224);
            textBox_Correct.Name = "textBox_Correct";
            textBox_Correct.Size = new Size(49, 27);
            textBox_Correct.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 8;
            label1.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 9;
            label2.Text = "2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 10;
            label3.Text = "3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 178);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 11;
            label4.Text = "4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 228);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 12;
            label5.Text = "Correct : ";
            // 
            // Question_Mutilchoice_update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(374, 345);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Correct);
            Controls.Add(btn_Close);
            Controls.Add(btn_Update);
            Controls.Add(textBox_Answer4);
            Controls.Add(textBox_Answer3);
            Controls.Add(textBox_Answer2);
            Controls.Add(textBox_Answer1);
            Controls.Add(textBox_Question);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Question_Mutilchoice_update";
            Text = "Multichoice Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Question;
        private TextBox textBox_Answer1;
        private TextBox textBox_Answer2;
        private TextBox textBox_Answer3;
        private TextBox textBox_Answer4;
        private Button btn_Update;
        private Button btn_Close;
        private TextBox textBox_Correct;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}