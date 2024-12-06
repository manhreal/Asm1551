namespace GameQuizWindowsApp
{
    public partial class Welcome : Form
    {
        private Form currentFormChild;

        public Welcome()
        {
            InitializeComponent();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            OpenChildForm(frm2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userLogin user_frm = new userLogin();
            OpenChildForm(user_frm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            OpenChildForm(form4);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
