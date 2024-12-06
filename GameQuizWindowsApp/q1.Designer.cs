namespace GameQuizWindowsApp
{
    partial class q1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(q1));
            lblQuestion = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            btnSubmit = new Button();
            label_Questionnum = new Label();
            label_Questiontype = new Label();
            label_Instruct = new Label();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblQuestion.Location = new Point(80, 90);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(79, 23);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Question";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(62, 142);
            radioButton1.Margin = new Padding(4, 5, 4, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Answer 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(62, 188);
            radioButton2.Margin = new Padding(4, 5, 4, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(90, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Answer 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(62, 234);
            radioButton3.Margin = new Padding(4, 5, 4, 5);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(90, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Answer 3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(62, 280);
            radioButton4.Margin = new Padding(4, 5, 4, 5);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(90, 24);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Answer 4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveBorder;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSubmit.ForeColor = SystemColors.ControlText;
            btnSubmit.Location = new Point(13, 356);
            btnSubmit.Margin = new Padding(4, 5, 4, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(74, 40);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label_Questionnum
            // 
            label_Questionnum.AutoSize = true;
            label_Questionnum.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_Questionnum.Location = new Point(13, 89);
            label_Questionnum.Name = "label_Questionnum";
            label_Questionnum.Size = new Size(48, 23);
            label_Questionnum.TabIndex = 6;
            label_Questionnum.Text = "Num";
            // 
            // label_Questiontype
            // 
            label_Questiontype.AutoSize = true;
            label_Questiontype.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label_Questiontype.Location = new Point(15, 30);
            label_Questiontype.Name = "label_Questiontype";
            label_Questiontype.Size = new Size(277, 30);
            label_Questiontype.TabIndex = 7;
            label_Questiontype.Text = "Multiple Choice Questions";
            // 
            // label_Instruct
            // 
            label_Instruct.AutoSize = true;
            label_Instruct.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label_Instruct.Location = new Point(540, 356);
            label_Instruct.Name = "label_Instruct";
            label_Instruct.Size = new Size(282, 20);
            label_Instruct.TabIndex = 8;
            label_Instruct.Text = "Choose the best answer out of 4 options";
            // 
            // q1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(860, 410);
            Controls.Add(label_Instruct);
            Controls.Add(label_Questiontype);
            Controls.Add(label_Questionnum);
            Controls.Add(btnSubmit);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(lblQuestion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "q1";
            Text = "Multiple choice questions";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btnSubmit;
        private Label label_Questionnum;
        private Label label_Questiontype;
        private Label label_Instruct;
    }
}
