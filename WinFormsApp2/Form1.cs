namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public List<Question> questionBank = new List<Question>();
        private Admin form_admin;
        private userPlayGameForm form_user;

        public Form1()
        {
            InitializeComponent();
            form_admin = new Admin(questionBank);
            form_user = new userPlayGameForm(questionBank);
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();
            string role = cb_role.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username == "test1" && password == "123")
            {
                if (role == "Player")
                {
                    form_user.ShowDialog();
                }
                else if (role == "Admin")
                {
                    form_admin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_role.SelectedIndex = -1;
        }

    }
}
