namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cb_role = new ComboBox();
            btlogin = new Button();
            tb_username = new TextBox();
            tb_password = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 60);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(10, 110);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Role";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Items.AddRange(new object[] { "Player", "Admin" });
            cb_role.Location = new Point(95, 110);
            cb_role.Margin = new Padding(1);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(153, 28);
            cb_role.TabIndex = 3;
            // 
            // btlogin
            // 
            btlogin.BackColor = SystemColors.ActiveBorder;
            btlogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btlogin.Location = new Point(315, 103);
            btlogin.Margin = new Padding(1);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(80, 35);
            btlogin.TabIndex = 4;
            btlogin.Text = "Login";
            btlogin.UseVisualStyleBackColor = false;
            btlogin.Click += btlogin_Click;
            // 
            // tb_username
            // 
            tb_username.Location = new Point(95, 10);
            tb_username.Margin = new Padding(1);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(300, 27);
            tb_username.TabIndex = 5;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(95, 60);
            tb_password.Margin = new Padding(1);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(300, 27);
            tb_password.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(413, 165);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(btlogin);
            Controls.Add(cb_role);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            Name = "Form1";
            Text = "Welcome";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cb_role;
        private Button btlogin;
        private TextBox tb_username;
        private TextBox tb_password;
    }
}
