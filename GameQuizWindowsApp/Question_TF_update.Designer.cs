namespace GameQuizWindowsApp
{
    partial class Question_TF_update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question_TF_update));
            comboBox1 = new ComboBox();
            label5 = new Label();
            btn_Close = new Button();
            btn_Update = new Button();
            textBox_Question = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "True", "False" });
            comboBox1.Location = new Point(86, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(106, 28);
            comboBox1.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 70);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 31;
            label5.Text = "Correct : ";
            // 
            // btn_Close
            // 
            btn_Close.BackColor = SystemColors.ActiveBorder;
            btn_Close.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Close.Location = new Point(282, 293);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(80, 40);
            btn_Close.TabIndex = 30;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = false;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = SystemColors.ActiveBorder;
            btn_Update.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Update.Location = new Point(196, 293);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(80, 40);
            btn_Update.TabIndex = 29;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // textBox_Question
            // 
            textBox_Question.BackColor = SystemColors.Window;
            textBox_Question.Location = new Point(12, 12);
            textBox_Question.Name = "textBox_Question";
            textBox_Question.Size = new Size(350, 27);
            textBox_Question.TabIndex = 28;
            // 
            // Question_TF_update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(374, 345);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(btn_Close);
            Controls.Add(btn_Update);
            Controls.Add(textBox_Question);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Question_TF_update";
            Text = "Question_TF_update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label5;
        private Button btn_Close;
        private Button btn_Update;
        private TextBox textBox_Question;
    }
}