namespace WinFormsApp2
{
    partial class startGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startGame));
            label5 = new Label();
            buttonStart = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.Location = new Point(51, 183);
            label5.Name = "label5";
            label5.Size = new Size(758, 25);
            label5.TabIndex = 14;
            label5.Text = "Your task is to answer as many questions correctly as possible (and in the shortest time)";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.ActiveBorder;
            buttonStart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            buttonStart.Location = new Point(395, 317);
            buttonStart.Margin = new Padding(4, 5, 4, 5);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(74, 40);
            buttonStart.TabIndex = 9;
            buttonStart.Text = "Start !";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // startGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(860, 410);
            Controls.Add(label5);
            Controls.Add(buttonStart);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "startGame";
            Text = "Start Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button buttonStart;
    }
}