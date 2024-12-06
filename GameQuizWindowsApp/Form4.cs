using System;
using System.Windows.Forms;
using Helper;

namespace GameQuizWindowsApp
{
    public partial class Form4 : Form
    {
        private AuthenticationHelper _authHelper;

        public Form4()
        {
            InitializeComponent();
            _authHelper = new AuthenticationHelper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text.Trim();
            string password = textBox_Pass.Text.Trim();
            string confirmPassword = textBox_ConfirmPass.Text.Trim();
            string displayName = textBox_DisplayName.Text.Trim();

            // Check input conditions
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(displayName))
            {
                MessageBox.Show("Please fill in all information.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username.Length < 8)
            {
                MessageBox.Show("Username must be at least 8 characters.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_authHelper.IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters, including uppercase, lowercase and numbers.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Confirm password does not match.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đăng ký
            if (_authHelper.Register(username, password, displayName))
            {
                MessageBox.Show("Registration successful! You can log in now.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Ẩn Form4
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TogglePassword1_Click(object sender, EventArgs e)
        {
            // State toggle
            textBox_Pass.UseSystemPasswordChar = !textBox_Pass.UseSystemPasswordChar;
            btn_TogglePassword1.Text = textBox_Pass.UseSystemPasswordChar ? "👁" : "🔒";
        }

        private void btn_TogglePassword2_Click(object sender, EventArgs e)
        {
            // State toggle
            textBox_ConfirmPass.UseSystemPasswordChar = !textBox_ConfirmPass.UseSystemPasswordChar;
            btn_TogglePassword2.Text = textBox_Pass.UseSystemPasswordChar ? "👁" : "🔒";
        }
    }
}
