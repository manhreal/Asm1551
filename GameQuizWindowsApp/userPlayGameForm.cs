using Helper;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Helper;

namespace GameQuizWindowsApp
{
    public partial class userPlayGameForm : Form
    {
        private AuthenticationHelper.User currentUser;

        public userPlayGameForm(AuthenticationHelper.User user)
        {
            InitializeComponent();
            currentUser = user;
            label_Welcome.Text = $"Welcome, {currentUser.Name}";
        }

        private Form currentFormChild;

        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // Close current form if any
            }
            currentFormChild = childForm; // Assign new form
            childForm.TopLevel = false; // Set to be embedded in panel
            childForm.FormBorderStyle = FormBorderStyle.None; // No border
            childForm.Dock = DockStyle.Fill; // Fill the panel
            panel_Body.Controls.Add(childForm); // Add form to panel
            panel_Body.Tag = childForm; // Assign tags to the panel
            childForm.BringToFront(); // Move the form to the top
            childForm.Show();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            OpenChildForm(new startGame(currentUser, this));
        }

        private void btn_Rank_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ranking(currentUser));
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
