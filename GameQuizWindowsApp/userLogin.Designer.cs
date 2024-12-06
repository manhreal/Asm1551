namespace GameQuizWindowsApp
{
    partial class userLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userLogin));
            button1 = new Button();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox_Username = new TextBox();
            label3 = new Label();
            textBox_Pass = new TextBox();
            label1 = new Label();
            btn_TogglePassword1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(413, 206);
            button1.Name = "button1";
            button1.Size = new Size(74, 40);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Username : ";
            // 
            // textBox_Username
            // 
            textBox_Username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Username.BackColor = SystemColors.Window;
            textBox_Username.Location = new Point(12, 89);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(475, 27);
            textBox_Username.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // textBox_Pass
            // 
            textBox_Pass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Pass.BackColor = SystemColors.Window;
            textBox_Pass.Location = new Point(12, 142);
            textBox_Pass.Name = "textBox_Pass";
            textBox_Pass.Size = new Size(450, 27);
            textBox_Pass.TabIndex = 4;
            textBox_Pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label1.Location = new Point(158, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 35);
            label1.TabIndex = 5;
            label1.Text = "Login as player";
            // 
            // btn_TogglePassword1
            // 
            btn_TogglePassword1.Location = new Point(457, 142);
            btn_TogglePassword1.Name = "btn_TogglePassword1";
            btn_TogglePassword1.Size = new Size(30, 25);
            btn_TogglePassword1.TabIndex = 0;
            btn_TogglePassword1.Text = "👁";
            btn_TogglePassword1.Click += btn_TogglePassword1_Click;
            // 
            // userLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(499, 258);
            Controls.Add(btn_TogglePassword1);
            Controls.Add(label1);
            Controls.Add(textBox_Pass);
            Controls.Add(label3);
            Controls.Add(textBox_Username);
            Controls.Add(label2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "userLogin";
            Text = "Player Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox_Username;
        private Label label3;
        private TextBox textBox_Pass;
        private Label label1;
        private Button btn_TogglePassword1;
    }
}