namespace GameQuizWindowsApp
{
    partial class Question_TF_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question_TF_Add));
            textBox_Question = new TextBox();
            btn_Close = new Button();
            btn_Add = new Button();
            label5 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox_Question
            // 
            textBox_Question.Location = new Point(12, 12);
            textBox_Question.Name = "textBox_Question";
            textBox_Question.Size = new Size(350, 27);
            textBox_Question.TabIndex = 14;
            // 
            // btn_Close
            // 
            btn_Close.BackColor = SystemColors.ActiveBorder;
            btn_Close.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Close.Location = new Point(282, 293);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(80, 40);
            btn_Close.TabIndex = 21;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = false;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = SystemColors.ActiveBorder;
            btn_Add.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Add.Location = new Point(196, 293);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(80, 40);
            btn_Add.TabIndex = 20;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 70);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 26;
            label5.Text = "Correct : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "True", "False" });
            comboBox1.Location = new Point(86, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(106, 28);
            comboBox1.TabIndex = 27;
            // 
            // Question_TF_Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(374, 345);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(btn_Close);
            Controls.Add(btn_Add);
            Controls.Add(textBox_Question);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Question_TF_Add";
            Text = "Question_TF_Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Question;
        private Button btn_Close;
        private Button btn_Add;
        private Label label5;
        private ComboBox comboBox1;
    }
}