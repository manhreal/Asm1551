namespace GameQuizWindowsApp
{
    partial class Welcome
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            btn_Admin = new Button();
            btn_User = new Button();
            btn_SignUp = new Button();
            panel_Top = new Panel();
            label1 = new Label();
            panel_Body = new Panel();
            pictureBox1 = new PictureBox();
            panel_Top.SuspendLayout();
            panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Admin
            // 
            btn_Admin.BackColor = SystemColors.ActiveBorder;
            btn_Admin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_Admin.ForeColor = SystemColors.ControlText;
            btn_Admin.Location = new Point(198, 9);
            btn_Admin.Name = "btn_Admin";
            btn_Admin.Size = new Size(94, 48);
            btn_Admin.TabIndex = 0;
            btn_Admin.Text = "Admin";
            btn_Admin.UseVisualStyleBackColor = false;
            btn_Admin.Click += button1_Click;
            // 
            // btn_User
            // 
            btn_User.BackColor = SystemColors.ActiveBorder;
            btn_User.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_User.ForeColor = SystemColors.ControlText;
            btn_User.Location = new Point(298, 9);
            btn_User.Name = "btn_User";
            btn_User.Size = new Size(94, 48);
            btn_User.TabIndex = 1;
            btn_User.Text = "User";
            btn_User.UseVisualStyleBackColor = false;
            btn_User.Click += button2_Click;
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = SystemColors.ActiveBorder;
            btn_SignUp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_SignUp.ForeColor = SystemColors.ControlText;
            btn_SignUp.Location = new Point(398, 9);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(94, 48);
            btn_SignUp.TabIndex = 2;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = false;
            btn_SignUp.Click += button3_Click;
            // 
            // panel_Top
            // 
            panel_Top.BackColor = SystemColors.ActiveCaption;
            panel_Top.Controls.Add(label1);
            panel_Top.Controls.Add(btn_Admin);
            panel_Top.Controls.Add(btn_User);
            panel_Top.Controls.Add(btn_SignUp);
            panel_Top.Dock = DockStyle.Top;
            panel_Top.Location = new Point(0, 0);
            panel_Top.Name = "panel_Top";
            panel_Top.Size = new Size(499, 67);
            panel_Top.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 41);
            label1.TabIndex = 3;
            label1.Text = "Welcome !";
            label1.Click += label1_Click;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = SystemColors.AppWorkspace;
            panel_Body.Controls.Add(pictureBox1);
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(0, 67);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(499, 275);
            panel_Body.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.Image = Properties.Resources.hinh_nen_real_madrid_14__1_;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 272);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 342);
            Controls.Add(panel_Body);
            Controls.Add(panel_Top);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Welcome";
            Text = "Welcome";
            panel_Top.ResumeLayout(false);
            panel_Top.PerformLayout();
            panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Admin;
        private Button btn_User;
        private Button btn_SignUp;
        private Panel panel_Top;
        private Panel panel_Body;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
