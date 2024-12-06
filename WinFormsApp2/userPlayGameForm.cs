using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class userPlayGameForm : Form
    {
        public List<Question> questionBank = new List<Question>();
        public userPlayGameForm(List<Question> questionBank)
        {
            InitializeComponent();
            this.questionBank = questionBank;
        }
        public Form GetParentForm()
        {
            return this.ParentForm;
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
            OpenChildForm(new startGame(questionBank, this));
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
