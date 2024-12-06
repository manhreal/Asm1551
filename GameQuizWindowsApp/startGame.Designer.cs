namespace GameQuizWindowsApp
{
    partial class startGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startGame));
            labelWelcome = new Label();
            buttonStart = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Microsoft Sans Serif", 14F);
            labelWelcome.Location = new Point(174, 77);
            labelWelcome.Margin = new Padding(4, 0, 4, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(0, 29);
            labelWelcome.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.ActiveBorder;
            buttonStart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            buttonStart.Location = new Point(393, 317);
            buttonStart.Margin = new Padding(4, 5, 4, 5);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(74, 40);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start !";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label1.Location = new Point(101, 53);
            label1.Name = "label1";
            label1.Size = new Size(337, 30);
            label1.TabIndex = 2;
            label1.Text = "This game will have 15 questions";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(467, 59);
            label2.Name = "label2";
            label2.Size = new Size(237, 23);
            label2.TabIndex = 3;
            label2.Text = "- 5 Multiple Choice Questions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(467, 99);
            label3.Name = "label3";
            label3.Size = new Size(214, 23);
            label3.TabIndex = 4;
            label3.Text = "- 5 Open-ended Questions";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(467, 139);
            label4.Name = "label4";
            label4.Size = new Size(192, 23);
            label4.TabIndex = 5;
            label4.Text = "- 5 True False Questions";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.Location = new Point(49, 183);
            label5.Name = "label5";
            label5.Size = new Size(758, 25);
            label5.TabIndex = 6;
            label5.Text = "Your task is to answer as many questions correctly as possible (and in the shortest time)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label6.Location = new Point(129, 255);
            label6.Name = "label6";
            label6.Size = new Size(575, 30);
            label6.TabIndex = 7;
            label6.Text = "Try to get a high position in the leaderboard! Good luck!";
            // 
            // startGame
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(860, 410);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonStart);
            Controls.Add(labelWelcome);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "startGame";
            Text = "Start Game";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonStart;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
