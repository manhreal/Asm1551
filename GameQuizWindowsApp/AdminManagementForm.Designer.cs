namespace GameQuizWindowsApp
{
    partial class AdminManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManagementForm));
            label_Welcome = new Label();
            panel_Top = new Panel();
            btn_delete = new Button();
            btn_add = new Button();
            btn_update = new Button();
            panel_Body = new Panel();
            panel_Top.SuspendLayout();
            SuspendLayout();
            // 
            // label_Welcome
            // 
            label_Welcome.AutoSize = true;
            label_Welcome.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label_Welcome.Location = new Point(12, 9);
            label_Welcome.Name = "label_Welcome";
            label_Welcome.Size = new Size(203, 35);
            label_Welcome.TabIndex = 0;
            label_Welcome.Text = "Welcome Admin";
            // 
            // panel_Top
            // 
            panel_Top.BackColor = SystemColors.ActiveCaption;
            panel_Top.Controls.Add(btn_delete);
            panel_Top.Controls.Add(label_Welcome);
            panel_Top.Controls.Add(btn_add);
            panel_Top.Controls.Add(btn_update);
            panel_Top.Dock = DockStyle.Top;
            panel_Top.Location = new Point(0, 0);
            panel_Top.Name = "panel_Top";
            panel_Top.Size = new Size(1182, 52);
            panel_Top.TabIndex = 1;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ActiveBorder;
            btn_delete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_delete.Location = new Point(1090, 6);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(80, 40);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Log Out";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ActiveBorder;
            btn_add.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_add.Location = new Point(395, 6);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(80, 40);
            btn_add.TabIndex = 1;
            btn_add.Text = "User";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ActiveBorder;
            btn_update.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_update.Location = new Point(481, 6);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(80, 40);
            btn_update.TabIndex = 2;
            btn_update.Text = "Question";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = SystemColors.InactiveCaption;
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(0, 52);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1182, 501);
            panel_Body.TabIndex = 2;
            // 
            // AdminManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1182, 553);
            Controls.Add(panel_Body);
            Controls.Add(panel_Top);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminManagementForm";
            Text = "Admin";
            panel_Top.ResumeLayout(false);
            panel_Top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_Welcome;
        private Panel panel_Top;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Panel panel_Body;
    }
}