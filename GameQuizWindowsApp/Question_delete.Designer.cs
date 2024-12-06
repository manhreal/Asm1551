namespace GameQuizWindowsApp
{
    partial class Question_delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question_delete));
            label_Question = new Label();
            btn_Yes = new Button();
            btn_No = new Button();
            label_Delete = new Label();
            SuspendLayout();
            // 
            // label_Question
            // 
            label_Question.AutoSize = true;
            label_Question.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label_Question.Location = new Point(24, 102);
            label_Question.Name = "label_Question";
            label_Question.Size = new Size(70, 20);
            label_Question.TabIndex = 0;
            label_Question.Text = "Question";
            // 
            // btn_Yes
            // 
            btn_Yes.BackColor = SystemColors.ActiveBorder;
            btn_Yes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Yes.Location = new Point(196, 293);
            btn_Yes.Name = "btn_Yes";
            btn_Yes.Size = new Size(80, 40);
            btn_Yes.TabIndex = 1;
            btn_Yes.Text = "Yes";
            btn_Yes.UseVisualStyleBackColor = false;
            btn_Yes.Click += btn_Yes_Click;
            // 
            // btn_No
            // 
            btn_No.BackColor = SystemColors.ActiveBorder;
            btn_No.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_No.Location = new Point(282, 293);
            btn_No.Name = "btn_No";
            btn_No.Size = new Size(80, 40);
            btn_No.TabIndex = 2;
            btn_No.Text = "No";
            btn_No.UseVisualStyleBackColor = false;
            btn_No.Click += btn_No_Click;
            // 
            // label_Delete
            // 
            label_Delete.AutoSize = true;
            label_Delete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label_Delete.Location = new Point(159, 25);
            label_Delete.Name = "label_Delete";
            label_Delete.Size = new Size(64, 20);
            label_Delete.TabIndex = 3;
            label_Delete.Text = "Delete ?";
            // 
            // Question_delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(374, 345);
            Controls.Add(label_Delete);
            Controls.Add(btn_No);
            Controls.Add(btn_Yes);
            Controls.Add(label_Question);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Question_delete";
            Text = "Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Question;
        private Button btn_Yes;
        private Button btn_No;
        private Label label_Delete;
    }
}