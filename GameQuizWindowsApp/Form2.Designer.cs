namespace GameQuizWindowsApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            resources.ApplyResources(button1, "button1");
            button1.BackColor = SystemColors.ActiveBorder;
            button1.ForeColor = SystemColors.ControlText;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // textBox_Username
            // 
            resources.ApplyResources(textBox_Username, "textBox_Username");
            textBox_Username.BackColor = SystemColors.Window;
            textBox_Username.Name = "textBox_Username";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // textBox_Pass
            // 
            resources.ApplyResources(textBox_Pass, "textBox_Pass");
            textBox_Pass.BackColor = SystemColors.Window;
            textBox_Pass.Name = "textBox_Pass";
            textBox_Pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.Desktop;
            label1.Name = "label1";
            // 
            // btn_TogglePassword1
            // 
            resources.ApplyResources(btn_TogglePassword1, "btn_TogglePassword1");
            btn_TogglePassword1.Name = "btn_TogglePassword1";
            // 

            // 
            // btn_TogglePassword1
            // 
            btn_TogglePassword1.Location = new Point(457, 142);
            btn_TogglePassword1.Name = "btn_TogglePassword1";
            btn_TogglePassword1.Size = new Size(30, 25);
            btn_TogglePassword1.TabIndex = 0;
            btn_TogglePassword1.Text = "👁";
            btn_TogglePassword1.Click += btn_TogglePassword1_Click;
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(btn_TogglePassword1);
            Controls.Add(label1);
            Controls.Add(textBox_Pass);
            Controls.Add(label3);
            Controls.Add(textBox_Username);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Form2";
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