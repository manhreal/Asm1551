namespace GameQuizWindowsApp
{
    partial class userPlayGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userPlayGameForm));
            panel_Top = new Panel();
            btn_Logout = new Button();
            label_Welcome = new Label();
            btn_Rank = new Button();
            btn_Start = new Button();
            panel_Body = new Panel();
            panel_Top.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Top
            // 
            panel_Top.BackColor = SystemColors.GradientActiveCaption;
            panel_Top.Controls.Add(btn_Logout);
            panel_Top.Controls.Add(label_Welcome);
            panel_Top.Controls.Add(btn_Rank);
            panel_Top.Controls.Add(btn_Start);
            panel_Top.Dock = DockStyle.Top;
            panel_Top.Location = new Point(0, 0);
            panel_Top.Name = "panel_Top";
            panel_Top.Size = new Size(862, 52);
            panel_Top.TabIndex = 1;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = SystemColors.ActiveBorder;
            btn_Logout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Logout.ForeColor = SystemColors.ControlText;
            btn_Logout.Location = new Point(776, 6);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(74, 40);
            btn_Logout.TabIndex = 3;
            btn_Logout.Text = "Log Out";
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // label_Welcome
            // 
            label_Welcome.AutoSize = true;
            label_Welcome.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label_Welcome.ForeColor = SystemColors.ControlText;
            label_Welcome.Location = new Point(12, 9);
            label_Welcome.Name = "label_Welcome";
            label_Welcome.Size = new Size(150, 35);
            label_Welcome.TabIndex = 0;
            label_Welcome.Text = "Play Game !";
            // 
            // btn_Rank
            // 
            btn_Rank.BackColor = SystemColors.ActiveBorder;
            btn_Rank.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Rank.ForeColor = SystemColors.ControlText;
            btn_Rank.Location = new Point(696, 6);
            btn_Rank.Name = "btn_Rank";
            btn_Rank.Size = new Size(74, 40);
            btn_Rank.TabIndex = 2;
            btn_Rank.Text = "Ranking";
            btn_Rank.UseVisualStyleBackColor = false;
            btn_Rank.Click += btn_Rank_Click;
            // 
            // btn_Start
            // 
            btn_Start.BackColor = SystemColors.ActiveBorder;
            btn_Start.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Start.ForeColor = SystemColors.ControlText;
            btn_Start.Location = new Point(616, 6);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(74, 40);
            btn_Start.TabIndex = 1;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = false;
            btn_Start.Click += btn_Start_Click;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = SystemColors.GradientInactiveCaption;
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(0, 52);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(862, 457);
            panel_Body.TabIndex = 2;
            // 
            // userPlayGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 509);
            Controls.Add(panel_Body);
            Controls.Add(panel_Top);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "userPlayGameForm";
            Text = "Quiz Game";
            panel_Top.ResumeLayout(false);
            panel_Top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_Top;
        private Panel panel_Body;
        private Label label_Welcome;
        private Button btn_Logout;
        private Button btn_Rank;
        private Button btn_Start;
    }
}