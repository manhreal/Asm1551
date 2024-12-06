namespace GameQuizWindowsApp
{
    partial class q2
    {
        private System.ComponentModel.IContainer _components = null; // Đổi tên thành _components
        private System.Windows.Forms.Label lblOpenQuestion;
        private System.Windows.Forms.TextBox textBoxOpenAnswer;
        private System.Windows.Forms.Button btnOpenSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (_components != null))
            {
                _components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(q2));
            lblOpenQuestion = new Label();
            textBoxOpenAnswer = new TextBox();
            btnOpenSubmit = new Button();
            label_Questionnum = new Label();
            label_Questiontype = new Label();
            label_Instruct = new Label();
            SuspendLayout();
            // 
            // lblOpenQuestion
            // 
            lblOpenQuestion.AutoSize = true;
            lblOpenQuestion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblOpenQuestion.Location = new Point(80, 90);
            lblOpenQuestion.Margin = new Padding(4, 0, 4, 0);
            lblOpenQuestion.Name = "lblOpenQuestion";
            lblOpenQuestion.Size = new Size(79, 23);
            lblOpenQuestion.TabIndex = 0;
            lblOpenQuestion.Text = "Question";
            // 
            // textBoxOpenAnswer
            // 
            textBoxOpenAnswer.BackColor = SystemColors.Window;
            textBoxOpenAnswer.Location = new Point(62, 142);
            textBoxOpenAnswer.Margin = new Padding(4, 5, 4, 5);
            textBoxOpenAnswer.Name = "textBoxOpenAnswer";
            textBoxOpenAnswer.Size = new Size(369, 27);
            textBoxOpenAnswer.TabIndex = 1;
            // 
            // btnOpenSubmit
            // 
            btnOpenSubmit.BackColor = SystemColors.ActiveBorder;
            btnOpenSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOpenSubmit.ForeColor = SystemColors.ControlText;
            btnOpenSubmit.Location = new Point(13, 356);
            btnOpenSubmit.Margin = new Padding(4, 5, 4, 5);
            btnOpenSubmit.Name = "btnOpenSubmit";
            btnOpenSubmit.Size = new Size(74, 40);
            btnOpenSubmit.TabIndex = 2;
            btnOpenSubmit.Text = "Submit";
            btnOpenSubmit.UseVisualStyleBackColor = false;
            btnOpenSubmit.Click += btnOpenSubmit_Click;
            // 
            // label_Questionnum
            // 
            label_Questionnum.AutoSize = true;
            label_Questionnum.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_Questionnum.Location = new Point(13, 89);
            label_Questionnum.Name = "label_Questionnum";
            label_Questionnum.Size = new Size(48, 23);
            label_Questionnum.TabIndex = 7;
            label_Questionnum.Text = "Num";
            // 
            // label_Questiontype
            // 
            label_Questiontype.AutoSize = true;
            label_Questiontype.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label_Questiontype.Location = new Point(15, 30);
            label_Questiontype.Name = "label_Questiontype";
            label_Questiontype.Size = new Size(246, 30);
            label_Questiontype.TabIndex = 8;
            label_Questiontype.Text = "Open-ended Questions";
            // 
            // label_Instruct
            // 
            label_Instruct.AutoSize = true;
            label_Instruct.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label_Instruct.Location = new Point(540, 356);
            label_Instruct.Name = "label_Instruct";
            label_Instruct.Size = new Size(311, 20);
            label_Instruct.TabIndex = 9;
            label_Instruct.Text = "Fill in one or more answers (separated by ',')";
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "q2";
            Text = "Open questions";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label_Questionnum;
        private Label label_Questiontype;
        private Label label_Instruct;
    }
}
