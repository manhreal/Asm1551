namespace WinFormsApp2
{
    partial class q3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(q3));
            label_Instruct = new Label();
            label_Questiontype = new Label();
            label_Questionnum = new Label();
            btnFalse = new Button();
            btnTrue = new Button();
            lblQuestion = new Label();
            SuspendLayout();
            // 
            // label_Instruct
            // 
            label_Instruct.AutoSize = true;
            label_Instruct.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label_Instruct.Location = new Point(617, 358);
            label_Instruct.Name = "label_Instruct";
            label_Instruct.Size = new Size(154, 20);
            label_Instruct.TabIndex = 16;
            label_Instruct.Text = "Choose 1 of 2 options";
            // 
            // label_Questiontype
            // 
            label_Questiontype.AutoSize = true;
            label_Questiontype.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label_Questiontype.Location = new Point(13, 22);
            label_Questiontype.Name = "label_Questiontype";
            label_Questiontype.Size = new Size(216, 30);
            label_Questiontype.TabIndex = 15;
            label_Questiontype.Text = "True False Questions";
            // 
            // label_Questionnum
            // 
            label_Questionnum.AutoSize = true;
            label_Questionnum.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_Questionnum.Location = new Point(10, 81);
            label_Questionnum.Name = "label_Questionnum";
            label_Questionnum.Size = new Size(48, 23);
            label_Questionnum.TabIndex = 14;
            label_Questionnum.Text = "Num";
            // 
            // btnFalse
            // 
            btnFalse.BackColor = SystemColors.ActiveBorder;
            btnFalse.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFalse.ForeColor = SystemColors.ControlText;
            btnFalse.Location = new Point(141, 134);
            btnFalse.Margin = new Padding(4, 5, 4, 5);
            btnFalse.Name = "btnFalse";
            btnFalse.Size = new Size(74, 40);
            btnFalse.TabIndex = 13;
            btnFalse.Text = "False";
            btnFalse.UseVisualStyleBackColor = false;
            btnFalse.Click += btnFalse_Click;
            // 
            // btnTrue
            // 
            btnTrue.BackColor = SystemColors.ActiveBorder;
            btnTrue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnTrue.ForeColor = SystemColors.ControlText;
            btnTrue.Location = new Point(59, 134);
            btnTrue.Margin = new Padding(4, 5, 4, 5);
            btnTrue.Name = "btnTrue";
            btnTrue.Size = new Size(74, 40);
            btnTrue.TabIndex = 12;
            btnTrue.Text = "True";
            btnTrue.UseVisualStyleBackColor = false;
            btnTrue.Click += btnTrue_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblQuestion.Location = new Point(110, 81);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(79, 23);
            lblQuestion.TabIndex = 11;
            lblQuestion.Text = "Question";
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
            Name = "q3";
            Text = "TrueFalse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Instruct;
        private Label label_Questiontype;
        private Label label_Questionnum;
        private Button btnFalse;
        private Button btnTrue;
        private Label lblQuestion;
    }
}