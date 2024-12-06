using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;

namespace GameQuizWindowsApp
{
    public partial class AdminManagementForm : Form
    {
        private AuthenticationHelper.User currentUser; // Thông tin người dùng
        public AdminManagementForm(AuthenticationHelper.User user)
        {
            InitializeComponent();
            currentUser = user; // Lưu thông tin người dùng
            label_Welcome.Text = $"Welcome, {currentUser.Name}";
        }

        private Form currentFormChild;
        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // Đóng form hiện tại nếu có
            }
            currentFormChild = childForm; // Gán form mới
            childForm.TopLevel = false; // Thiết lập để có thể nhúng vào panel
            childForm.FormBorderStyle = FormBorderStyle.None; // Không có viền
            childForm.Dock = DockStyle.Fill; // Đổ đầy panel
            panel_Body.Controls.Add(childForm); // Thêm form vào panel
            panel_Body.Tag = childForm; // Gán tag cho panel
            childForm.BringToFront(); // Đưa form lên trên cùng
            childForm.Show(); // Hiển thị form
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Question_manage());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            OpenChildForm(new User_manage());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
