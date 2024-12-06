using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Helper;
using MySql.Data.MySqlClient;

namespace GameQuizWindowsApp
{
    public partial class userLogin : Form
    {
        private AuthenticationHelper authHelper;
        public userLogin()
        {
            InitializeComponent();
            authHelper = new AuthenticationHelper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text.Trim();
            string password = textBox_Pass.Text.Trim();

            AuthenticationHelper.User user = authHelper.Login(username, password);
            if (user != null && user.Role == 0) 
            {
                MessageBox.Show("Login successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userPlayGameForm userForm = new userPlayGameForm(user);
                userForm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your account and password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_TogglePassword1_Click(object sender, EventArgs e)
        {
            textBox_Pass.UseSystemPasswordChar = !textBox_Pass.UseSystemPasswordChar;
            btn_TogglePassword1.Text = textBox_Pass.UseSystemPasswordChar ? "👁" : "🔒";
        }
    }
}
