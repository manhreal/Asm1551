namespace WinFormsApp2
{
    partial class Q_OpenEnded_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Q_OpenEnded_Edit));
            button1 = new Button();
            label6 = new Label();
            label1 = new Label();
            textBox6 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(310, 333);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 30;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(12, 119);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 29;
            label6.Text = "Correct";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 28;
            label1.Text = "Question";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 145);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(378, 27);
            textBox6.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 27);
            textBox1.TabIndex = 26;
            // 
            // Q_OpenEnded_Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(402, 375);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Q_OpenEnded_Edit";
            Text = "Edit OpenEnded Question";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label6;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox1;
    }
}