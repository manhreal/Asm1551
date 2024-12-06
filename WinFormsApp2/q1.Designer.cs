namespace WinFormsApp2
{
    partial class q1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(q1));
            label_Instruct = new Label();
            label_Questiontype = new Label();
            label_Questionnum = new Label();
            btnSubmit = new Button();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            lblQuestion = new Label();
            SuspendLayout();
            // 
            // label_Instruct
            // 
            label_Instruct.AutoSize = true;
            label_Instruct.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label_Instruct.Location = new Point(553, 348);
            label_Instruct.Name = "label_Instruct";
            label_Instruct.Size = new Size(282, 20);
            label_Instruct.TabIndex = 17;
            label_Instruct.Text = "Choose the best answer out of 4 options";
            // 
            // label_Questiontype
            // 
            label_Questiontype.AutoSize = true;
            label_Questiontype.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label_Questiontype.Location = new Point(28, 22);
            label_Questiontype.Name = "label_Questiontype";
            label_Questiontype.Size = new Size(277, 30);
            label_Questiontype.TabIndex = 16;
            label_Questiontype.Text = "Multiple Choice Questions";
            // 
            // label_Questionnum
            // 
            label_Questionnum.AutoSize = true;
            label_Questionnum.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_Questionnum.Location = new Point(26, 81);
            label_Questionnum.Name = "label_Questionnum";
            label_Questionnum.Size = new Size(48, 23);
            label_Questionnum.TabIndex = 15;
            label_Questionnum.Text = "Num";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveBorder;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSubmit.ForeColor = SystemColors.ControlText;
            btnSubmit.Location = new Point(26, 348);
            btnSubmit.Margin = new Padding(4, 5, 4, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(74, 40);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(75, 272);
            radioButton4.Margin = new Padding(4, 5, 4, 5);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(90, 24);
            radioButton4.TabIndex = 13;
            radioButton4.TabStop = true;
            radioButton4.Text = "Answer 4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(75, 226);
            radioButton3.Margin = new Padding(4, 5, 4, 5);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(90, 24);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "Answer 3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(75, 180);
            radioButton2.Margin = new Padding(4, 5, 4, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(90, 24);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Answer 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(75, 134);
            radioButton1.Margin = new Padding(4, 5, 4, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Answer 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblQuestion.Location = new Point(110, 81);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(79, 23);
            lblQuestion.TabIndex = 9;
            lblQuestion.Text = "Question";
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
            Name = "q1";
            Text = "Multichoice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Instruct;
        private Label label_Questiontype;
        private Label label_Questionnum;
        private Button btnSubmit;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label lblQuestion;
    }
}