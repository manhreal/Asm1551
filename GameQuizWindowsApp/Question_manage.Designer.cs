namespace GameQuizWindowsApp
{
    partial class Question_manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question_manage));
            cbb_typequestion = new ComboBox();
            textBox_search = new TextBox();
            btn_search = new Button();
            dataGridView_question = new DataGridView();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            panel_Body = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_question).BeginInit();
            SuspendLayout();
            // 
            // cbb_typequestion
            // 
            cbb_typequestion.BackColor = SystemColors.Window;
            cbb_typequestion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            cbb_typequestion.FormattingEnabled = true;
            cbb_typequestion.Location = new Point(680, 10);
            cbb_typequestion.Name = "cbb_typequestion";
            cbb_typequestion.Size = new Size(219, 28);
            cbb_typequestion.TabIndex = 0;
            cbb_typequestion.Text = "Type";
            // 
            // textBox_search
            // 
            textBox_search.BackColor = SystemColors.Window;
            textBox_search.Location = new Point(905, 11);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(247, 27);
            textBox_search.TabIndex = 1;
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.ActiveBorder;
            btn_search.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_search.Location = new Point(680, 50);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(74, 40);
            btn_search.TabIndex = 2;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            // 
            // dataGridView_question
            // 
            dataGridView_question.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView_question.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_question.Location = new Point(12, 50);
            dataGridView_question.Name = "dataGridView_question";
            dataGridView_question.RowHeadersWidth = 51;
            dataGridView_question.Size = new Size(662, 392);
            dataGridView_question.TabIndex = 3;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ActiveBorder;
            btn_add.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_add.Location = new Point(680, 96);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(74, 40);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ActiveBorder;
            btn_update.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_update.Location = new Point(680, 142);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(74, 40);
            btn_update.TabIndex = 6;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ActiveBorder;
            btn_delete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_delete.Location = new Point(680, 402);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(74, 40);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = SystemColors.GradientInactiveCaption;
            panel_Body.Location = new Point(760, 50);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(392, 392);
            panel_Body.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 35);
            label1.TabIndex = 9;
            label1.Text = "Question Manager";
            // 
            // Question_manage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1164, 454);
            Controls.Add(label1);
            Controls.Add(panel_Body);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dataGridView_question);
            Controls.Add(btn_search);
            Controls.Add(textBox_search);
            Controls.Add(cbb_typequestion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Question_manage";
            Text = "Question_manage";
            Load += Question_manage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_question).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbb_typequestion;
        private TextBox textBox_search;
        private Button btn_search;
        private DataGridView dataGridView_question;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Panel panel_Body;
        private Label label1;
    }
}