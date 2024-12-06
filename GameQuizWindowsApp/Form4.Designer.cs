namespace GameQuizWindowsApp
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            btn_SignUp = new Button();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox_Username = new TextBox();
            label3 = new Label();
            textBox_Pass = new TextBox();
            label1 = new Label();
            textBox_DisplayName = new TextBox();
            label_Topic = new Label();
            textBox_ConfirmPass = new TextBox();
            label5 = new Label();
            btn_TogglePassword1 = new Button();
            btn_TogglePassword2 = new Button();
            SuspendLayout();
            // 
            // btn_SignUp
            // 
            btn_SignUp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_SignUp.BackColor = SystemColors.ActiveBorder;
            btn_SignUp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_SignUp.ForeColor = SystemColors.ControlText;
            btn_SignUp.Location = new Point(413, 206);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(74, 40);
            btn_SignUp.TabIndex = 0;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = false;
            btn_SignUp.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Username : ";
            // 
            // textBox_Username
            // 
            textBox_Username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Username.BackColor = SystemColors.Window;
            textBox_Username.Location = new Point(12, 77);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(475, 27);
            textBox_Username.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // textBox_Pass
            // 
            textBox_Pass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Pass.BackColor = SystemColors.Window;
            textBox_Pass.Location = new Point(12, 130);
            textBox_Pass.Name = "textBox_Pass";
            textBox_Pass.Size = new Size(254, 27);
            textBox_Pass.TabIndex = 4;
            textBox_Pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(314, 137);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 5;
            label1.Text = "Display name :";
            // 
            // textBox_DisplayName
            // 
            textBox_DisplayName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_DisplayName.BackColor = SystemColors.Window;
            textBox_DisplayName.Location = new Point(314, 161);
            textBox_DisplayName.Name = "textBox_DisplayName";
            textBox_DisplayName.Size = new Size(173, 27);
            textBox_DisplayName.TabIndex = 6;
            // 
            // label_Topic
            // 
            label_Topic.AutoSize = true;
            label_Topic.BackColor = SystemColors.InactiveCaption;
            label_Topic.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label_Topic.Location = new Point(130, 9);
            label_Topic.Name = "label_Topic";
            label_Topic.Size = new Size(240, 35);
            label_Topic.TabIndex = 7;
            label_Topic.Text = "Create new account";
            // 
            // textBox_ConfirmPass
            // 
            textBox_ConfirmPass.Location = new Point(12, 183);
            textBox_ConfirmPass.Name = "textBox_ConfirmPass";
            textBox_ConfirmPass.Size = new Size(254, 27);
            textBox_ConfirmPass.TabIndex = 8;
            textBox_ConfirmPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 161);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 9;
            label5.Text = "Confirm Password :";
            // 
            // btn_TogglePassword1
            // 
            btn_TogglePassword1.Location = new Point(263, 130);
            btn_TogglePassword1.Name = "btn_TogglePassword1";
            btn_TogglePassword1.Size = new Size(30, 25);
            btn_TogglePassword1.TabIndex = 0;
            btn_TogglePassword1.Text = "👁";
            btn_TogglePassword1.Click += btn_TogglePassword1_Click;
            // 
            // btn_TogglePassword2
            // 
            btn_TogglePassword2.Location = new Point(263, 183);
            btn_TogglePassword2.Name = "btn_TogglePassword2";
            btn_TogglePassword2.Size = new Size(30, 25);
            btn_TogglePassword2.TabIndex = 10;
            btn_TogglePassword2.Text = "👁";
            btn_TogglePassword2.Click += btn_TogglePassword2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(499, 258);
            Controls.Add(btn_TogglePassword2);
            Controls.Add(btn_TogglePassword1);
            Controls.Add(label5);
            Controls.Add(textBox_ConfirmPass);
            Controls.Add(label_Topic);
            Controls.Add(textBox_DisplayName);
            Controls.Add(label1);
            Controls.Add(textBox_Pass);
            Controls.Add(label3);
            Controls.Add(textBox_Username);
            Controls.Add(label2);
            Controls.Add(btn_SignUp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_SignUp;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox_Username;
        private Label label3;
        private TextBox textBox_Pass;
        private Label label1;
        private TextBox textBox_DisplayName;
        private Label label_Topic;
        private TextBox textBox_ConfirmPass;
        private Label label5;
        private Button btn_TogglePassword1;
        private Button btn_TogglePassword2;
    }
}