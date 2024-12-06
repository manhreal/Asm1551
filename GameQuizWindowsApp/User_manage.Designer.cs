namespace GameQuizWindowsApp
{
    partial class User_manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_manage));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btn_search = new Button();
            textBox_search = new TextBox();
            cbb_SearchType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1140, 383);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 35);
            label1.TabIndex = 1;
            label1.Text = "User Manager";
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.ActiveBorder;
            btn_search.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_search.Location = new Point(600, 10);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(74, 40);
            btn_search.TabIndex = 5;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // textBox_search
            // 
            textBox_search.BackColor = SystemColors.Window;
            textBox_search.Location = new Point(905, 10);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(247, 27);
            textBox_search.TabIndex = 4;
            // 
            // cbb_SearchType
            // 
            cbb_SearchType.BackColor = SystemColors.Window;
            cbb_SearchType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            cbb_SearchType.FormattingEnabled = true;
            cbb_SearchType.Items.AddRange(new object[] { "Id", "Username" });
            cbb_SearchType.Location = new Point(680, 10);
            cbb_SearchType.Name = "cbb_SearchType";
            cbb_SearchType.Size = new Size(219, 28);
            cbb_SearchType.TabIndex = 3;
            cbb_SearchType.Text = "Type";
            // 
            // User_manage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1164, 454);
            Controls.Add(btn_search);
            Controls.Add(textBox_search);
            Controls.Add(cbb_SearchType);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "User_manage";
            Text = "User_manage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btn_search;
        private TextBox textBox_search;
        private ComboBox cbb_SearchType;
    }
}