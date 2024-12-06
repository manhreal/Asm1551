namespace GameQuizWindowsApp
{
    partial class q3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(q3));
            lblQuestion = new Label();
            btnTrue = new Button();
            btnFalse = new Button();
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
            // btnTrue
            // 
            btnTrue.BackColor = SystemColors.ActiveBorder;
            btnTrue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnTrue.ForeColor = SystemColors.ControlText;
            btnTrue.Location = new Point(62, 142);
            btnTrue.Margin = new Padding(4, 5, 4, 5);
            btnTrue.Name = "btnTrue";
            btnTrue.Size = new Size(74, 40);
            btnTrue.TabIndex = 1;
            btnTrue.Text = "True";
            btnTrue.UseVisualStyleBackColor = false;
            btnTrue.Click += btnTrue_Click;
            // 
            // btnFalse
            // 
            btnFalse.BackColor = SystemColors.ActiveBorder;
            btnFalse.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFalse.ForeColor = SystemColors.ControlText;
            btnFalse.Location = new Point(144, 142);
            btnFalse.Margin = new Padding(4, 5, 4, 5);
            btnFalse.Name = "btnFalse";
            btnFalse.Size = new Size(74, 40);
            btnFalse.TabIndex = 2;
            btnFalse.Text = "False";
            btnFalse.UseVisualStyleBackColor = false;
            btnFalse.Click += btnFalse_Click;
            // 
            // label_Questionnum
            // 
            label_Questionnum.AutoSize = true;
            label_Questionnum.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_Questionnum.Location = new Point(13, 89);
            label_Questionnum.Name = "label_Questionnum";
            label_Questionnum.Size = new Size(48, 23);
            label_Questionnum.TabIndex = 8;
            label_Questionnum.Text = "Num";
            // 
            // label_Questiontype
            // 
            label_Questiontype.AutoSize = true;
            label_Questiontype.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label_Questiontype.Location = new Point(15, 30);
            label_Questiontype.Name = "label_Questiontype";
            label_Questiontype.Size = new Size(216, 30);
            label_Questiontype.TabIndex = 9;
            label_Questiontype.Text = "True False Questions";
            // 
            // label_Instruct
            // 
            label_Instruct.AutoSize = true;
            label_Instruct.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label_Instruct.Location = new Point(540, 356);
            label_Instruct.Name = "label_Instruct";
            label_Instruct.Size = new Size(154, 20);
            label_Instruct.TabIndex = 10;
            label_Instruct.Text = "Choose 1 of 2 options";
            // 
            // q3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(860, 410);
            Controls.Add(label_Instruct);
            Controls.Add(label_Questiontype);
            Controls.Add(label_Questionnum);
            Controls.Add(btnFalse);
            Controls.Add(btnTrue);
            Controls.Add(lblQuestion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "q3";
            Text = "True False Questions";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnFalse;
        private Label label_Questionnum;
        private Label label_Questiontype;
        private Label label_Instruct;
    }
}
