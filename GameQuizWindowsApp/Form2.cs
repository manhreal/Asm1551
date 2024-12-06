using Helper;
using System;
using System.Windows.Forms;

namespace GameQuizWindowsApp
{
    public partial class Form2 : Form
    {
        private AuthenticationHelper _authHelper;

        public Form2()
        {
            InitializeComponent();
            _authHelper = new AuthenticationHelper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text.Trim();
            string password = textBox_Pass.Text.Trim();

            AuthenticationHelper.User adminUser = _authHelper.Login(username, password);
            if (adminUser != null && adminUser.Role == 1)
            {
                MessageBox.Show("Login successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminManagementForm adminForm = new AdminManagementForm(adminUser);
                adminForm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your account and password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TogglePassword1_Click(object sender, EventArgs e)
        {
            // State toggle
            textBox_Pass.UseSystemPasswordChar = !textBox_Pass.UseSystemPasswordChar;
            btn_TogglePassword1.Text = textBox_Pass.UseSystemPasswordChar ? "👁" : "🔒";
        }

    }
}
