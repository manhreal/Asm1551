namespace GameQuizWindowsApp
{
    partial class Ranking
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
            lblPlayer1 = new Label();
            lblPlayer2 = new Label();
            lblPlayer3 = new Label();
            lblPlayer4 = new Label();
            lblPlayer5 = new Label();
            lblCurrentUserRank = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblPlayer1
            // 
            lblPlayer1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPlayer1.AutoSize = true;
            lblPlayer1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblPlayer1.Location = new Point(107, 75);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(265, 30);
            lblPlayer1.TabIndex = 0;
            lblPlayer1.Text = "Player 1 - Score 1 - Time 1";
            lblPlayer1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2
            // 
            lblPlayer2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPlayer2.AutoSize = true;
            lblPlayer2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPlayer2.Location = new Point(107, 125);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(253, 28);
            lblPlayer2.TabIndex = 1;
            lblPlayer2.Text = "Player 2 - Score 2 - Time 2";
            lblPlayer2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayer3
            // 
            lblPlayer3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPlayer3.AutoSize = true;
            lblPlayer3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPlayer3.Location = new Point(107, 175);
            lblPlayer3.Name = "lblPlayer3";
            lblPlayer3.Size = new Size(238, 25);
            lblPlayer3.TabIndex = 2;
            lblPlayer3.Text = "Player 3 - Score 3 - Time 3";
            lblPlayer3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayer4
            // 
            lblPlayer4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPlayer4.AutoSize = true;
            lblPlayer4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPlayer4.Location = new Point(107, 225);
            lblPlayer4.Name = "lblPlayer4";
            lblPlayer4.Size = new Size(215, 23);
            lblPlayer4.TabIndex = 3;
            lblPlayer4.Text = "Player 4 - Score 4 - Time 4";
            lblPlayer4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayer5
            // 
            lblPlayer5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPlayer5.AutoSize = true;
            lblPlayer5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPlayer5.Location = new Point(107, 275);
            lblPlayer5.Name = "lblPlayer5";
            lblPlayer5.Size = new Size(187, 20);
            lblPlayer5.TabIndex = 4;
            lblPlayer5.Text = "Player 5 - Score 5 - Time 5";
            lblPlayer5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentUserRank
            // 
            lblCurrentUserRank.AutoSize = true;
            lblCurrentUserRank.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCurrentUserRank.Location = new Point(69, 358);
            lblCurrentUserRank.Name = "lblCurrentUserRank";
            lblCurrentUserRank.Size = new Size(147, 28);
            lblCurrentUserRank.TabIndex = 5;
            lblCurrentUserRank.Text = "Your rank: N/A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label1.Location = new Point(392, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 30);
            label1.TabIndex = 6;
            label1.Text = "Ranking";
            // 
            // Ranking
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(860, 410);
            Controls.Add(label1);
            Controls.Add(lblPlayer1);
            Controls.Add(lblPlayer2);
            Controls.Add(lblPlayer3);
            Controls.Add(lblPlayer4);
            Controls.Add(lblPlayer5);
            Controls.Add(lblCurrentUserRank);
            Name = "Ranking";
            Text = "Leaderboard";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblPlayer1;
        private Label lblPlayer2;
        private Label lblPlayer3;
        private Label lblPlayer4;
        private Label lblPlayer5;
        private Label lblCurrentUserRank;
        private Label label1;
    }
}
