
namespace GameQuizWindowsApp
{
    partial class Question_Open_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question_Open_Add));
            textBox_Question = new TextBox();
            textBox_Answer = new TextBox();
            btn_Close = new Button();
            btn_Add = new Button();
            label5 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox_Question
            // 
            textBox_Question.BackColor = SystemColors.Window;
            textBox_Question.Location = new Point(12, 12);
            textBox_Question.Name = "textBox_Question";
            textBox_Question.Size = new Size(350, 27);
            textBox_Question.TabIndex = 29;
            // 
            // textBox_Answer
            // 
            textBox_Answer.Location = new Point(89, 67);
            textBox_Answer.Name = "textBox_Answer";
            textBox_Answer.Size = new Size(273, 27);
            textBox_Answer.TabIndex = 30;
            // 
            // btn_Close
            // 
            btn_Close.BackColor = SystemColors.ActiveBorder;
            btn_Close.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Close.Location = new Point(282, 293);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(80, 40);
            btn_Close.TabIndex = 32;
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
            btn_Add.TabIndex = 31;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 74);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 33;
            label5.Text = "Correct : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(89, 97);
            label1.Name = "label1";
            label1.Size = new Size(251, 20);
            label1.TabIndex = 39;
            label1.Text = "Correct answers are separated by ','";
            // 
            // Question_Open_Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(374, 345);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(btn_Close);
            Controls.Add(btn_Add);
            Controls.Add(textBox_Answer);
            Controls.Add(textBox_Question);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Question_Open_Add";
            Text = "Question_Open_Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Question;
        private TextBox textBox_Answer;
        private Button btn_Close;
        private Button btn_Add;
        private Label label5;
        private Label label1;
    }
}