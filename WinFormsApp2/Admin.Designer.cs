namespace WinFormsApp2
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            bt_add = new Button();
            rt_all = new RichTextBox();
            bt_displayall = new Button();
            bt_edit = new Button();
            bt_delete = new Button();
            tb_index = new TextBox();
            comboBox_TypeQ = new ComboBox();
            label_Q = new Label();
            panel_Body = new Panel();
            SuspendLayout();
            // 
            // bt_add
            // 
            bt_add.BackColor = SystemColors.ActiveBorder;
            bt_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bt_add.Location = new Point(551, 28);
            bt_add.Margin = new Padding(1);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(80, 30);
            bt_add.TabIndex = 2;
            bt_add.Text = "Add";
            bt_add.UseVisualStyleBackColor = false;
            bt_add.Click += bt_add_Click;
            // 
            // rt_all
            // 
            rt_all.BackColor = SystemColors.GradientInactiveCaption;
            rt_all.Location = new Point(12, 75);
            rt_all.Margin = new Padding(1);
            rt_all.Name = "rt_all";
            rt_all.Size = new Size(420, 422);
            rt_all.TabIndex = 5;
            rt_all.Text = "";
            // 
            // bt_displayall
            // 
            bt_displayall.BackColor = SystemColors.ActiveBorder;
            bt_displayall.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bt_displayall.Location = new Point(12, 28);
            bt_displayall.Margin = new Padding(1);
            bt_displayall.Name = "bt_displayall";
            bt_displayall.Size = new Size(80, 30);
            bt_displayall.TabIndex = 6;
            bt_displayall.Text = "Display All";
            bt_displayall.UseVisualStyleBackColor = false;
            bt_displayall.Click += bt_displayall_Click;
            // 
            // bt_edit
            // 
            bt_edit.BackColor = SystemColors.ActiveBorder;
            bt_edit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bt_edit.Location = new Point(698, 28);
            bt_edit.Margin = new Padding(1);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(80, 30);
            bt_edit.TabIndex = 7;
            bt_edit.Text = "Edit";
            bt_edit.UseVisualStyleBackColor = false;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_delete
            // 
            bt_delete.BackColor = SystemColors.ActiveBorder;
            bt_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bt_delete.Location = new Point(781, 28);
            bt_delete.Margin = new Padding(1);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(80, 30);
            bt_delete.TabIndex = 8;
            bt_delete.Text = "Delete";
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // tb_index
            // 
            tb_index.Location = new Point(634, 28);
            tb_index.Margin = new Padding(1);
            tb_index.Name = "tb_index";
            tb_index.Size = new Size(62, 27);
            tb_index.TabIndex = 9;
            // 
            // comboBox_TypeQ
            // 
            comboBox_TypeQ.AutoCompleteCustomSource.AddRange(new string[] { "Multi Choice", "Open Ended", "True False" });
            comboBox_TypeQ.FormattingEnabled = true;
            comboBox_TypeQ.Items.AddRange(new object[] { "Multi Choice", "Open Ended", "True False" });
            comboBox_TypeQ.Location = new Point(296, 28);
            comboBox_TypeQ.Name = "comboBox_TypeQ";
            comboBox_TypeQ.Size = new Size(251, 28);
            comboBox_TypeQ.TabIndex = 10;
            // 
            // label_Q
            // 
            label_Q.AutoSize = true;
            label_Q.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_Q.Location = new Point(187, 32);
            label_Q.Name = "label_Q";
            label_Q.Size = new Size(109, 20);
            label_Q.TabIndex = 11;
            label_Q.Text = "Question Type";
            // 
            // panel_Body
            // 
            panel_Body.BackColor = SystemColors.GradientInactiveCaption;
            panel_Body.Location = new Point(445, 75);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(420, 422);
            panel_Body.TabIndex = 12;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(876, 508);
            Controls.Add(panel_Body);
            Controls.Add(label_Q);
            Controls.Add(comboBox_TypeQ);
            Controls.Add(tb_index);
            Controls.Add(bt_delete);
            Controls.Add(bt_edit);
            Controls.Add(bt_displayall);
            Controls.Add(rt_all);
            Controls.Add(bt_add);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt_add;
        private RichTextBox rt_all;
        private Button bt_displayall;
        private Button bt_edit;
        private Button bt_delete;
        private TextBox tb_index;
        private ComboBox comboBox_TypeQ;
        private Label label_Q;
        private Panel panel_Body;
    }
}