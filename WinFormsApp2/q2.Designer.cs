namespace WinFormsApp2
{
    partial class q2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(q2));
            label_Instruct = new Label();
            label_Questiontype = new Label();
            label_Questionnum = new Label();
            btnOpenSubmit = new Button();
            textBoxOpenAnswer = new TextBox();
            lblOpenQuestion = new Label();
            SuspendLayout();
            // 
            // label_Instruct
            // 
            label_Instruct.AutoSize = true;
            label_Instruct.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label_Instruct.Location = new Point(538, 348);
            label_Instruct.Name = "label_Instruct";
            label_Instruct.Size = new Size(311, 20);
            label_Instruct.TabIndex = 15;
            label_Instruct.Text = "Fill in one or more answers (separated by ',')";
            // 
            // label_Questiontype
            // 
            label_Questiontype.AutoSize = true;
            label_Questiontype.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label_Questiontype.Location = new Point(13, 22);
            label_Questiontype.Name = "label_Questiontype";
            label_Questiontype.Size = new Size(246, 30);
            label_Questiontype.TabIndex = 14;
            label_Questiontype.Text = "Open-ended Questions";
            // 
            // label_Questionnum
            // 
            label_Questionnum.AutoSize = true;
            label_Questionnum.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_Questionnum.Location = new Point(11, 81);
            label_Questionnum.Name = "label_Questionnum";
            label_Questionnum.Size = new Size(48, 23);
            label_Questionnum.TabIndex = 13;
            label_Questionnum.Text = "Num";
            // 
            // btnOpenSubmit
            // 
            btnOpenSubmit.BackColor = SystemColors.ActiveBorder;
            btnOpenSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOpenSubmit.ForeColor = SystemColors.ControlText;
            btnOpenSubmit.Location = new Point(11, 348);
            btnOpenSubmit.Margin = new Padding(4, 5, 4, 5);
            btnOpenSubmit.Name = "btnOpenSubmit";
            btnOpenSubmit.Size = new Size(74, 40);
            btnOpenSubmit.TabIndex = 12;
            btnOpenSubmit.Text = "Submit";
            btnOpenSubmit.UseVisualStyleBackColor = false;
            btnOpenSubmit.Click += btnOpenSubmit_Click;
            // 
            // textBoxOpenAnswer
            // 
            textBoxOpenAnswer.BackColor = SystemColors.Window;
            textBoxOpenAnswer.Location = new Point(60, 134);
            textBoxOpenAnswer.Margin = new Padding(4, 5, 4, 5);
            textBoxOpenAnswer.Name = "textBoxOpenAnswer";
            textBoxOpenAnswer.Size = new Size(369, 27);
            textBoxOpenAnswer.TabIndex = 11;
            // 
            // lblOpenQuestion
            // 
            lblOpenQuestion.AutoSize = true;
            lblOpenQuestion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblOpenQuestion.Location = new Point(110, 81);
            lblOpenQuestion.Margin = new Padding(4, 0, 4, 0);
            lblOpenQuestion.Name = "lblOpenQuestion";
            lblOpenQuestion.Size = new Size(79, 23);
            lblOpenQuestion.TabIndex = 10;
            lblOpenQuestion.Text = "Question";
            // 
            // q2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(860, 410);
            Controls.Add(label_Instruct);
            Controls.Add(label_Questiontype);
            Controls.Add(label_Questionnum);
            Controls.Add(btnOpenSubmit);
            Controls.Add(textBoxOpenAnswer);
            Controls.Add(lblOpenQuestion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "q2";
            Text = "OpenEnded";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Instruct;
        private Label label_Questiontype;
        private Label label_Questionnum;
        private Button btnOpenSubmit;
        private TextBox textBoxOpenAnswer;
        private Label lblOpenQuestion;
    }
}