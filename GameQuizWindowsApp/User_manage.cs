using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Helpers;
using MySql.Data.MySqlClient;

namespace GameQuizWindowsApp
{
    public partial class User_manage : Form
    {
        public User_manage()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadUsers();
            AddDeleteButtonColumn();
        }

        private void LoadUsers()
        {
            string query = @"SELECT 
                                u.id AS ID, 
                                u.username AS Username, 
                                u.name AS Name, 
                                u.has_played AS HasPlayed, 
                                s.score AS Score, 
                                s.time AS Time 
                             FROM 
                                user u
                             LEFT JOIN 
                                score s ON u.id = s.user_id
                             WHERE 
                                u.role = 0";

            try
            {
                DataTable table = DatabaseHelper.ExecuteQuery(query);
                dataGridView1.DataSource = table;
                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridView1.Columns["HasPlayed"] != null)
            {
                dataGridView1.Columns["HasPlayed"].ReadOnly = true;
            }
        }

        private void AddDeleteButtonColumn()
        {
            if (dataGridView1.Columns["DeleteButton"] == null)
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                {
                    Name = "DeleteButton",
                    HeaderText = "Delete",
                    Text = "X",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButton);
                dataGridView1.Columns["DeleteButton"].DisplayIndex = dataGridView1.Columns.Count - 1;
            }
        }

        private void DeleteUserFromDatabase(int userId)
        {
            string deleteQuery = "DELETE FROM user WHERE id = @userId AND role = 0";

            try
            {
                int rowsAffected = DatabaseHelper.ExecuteNonQuery(deleteQuery, new[]
                {
                    new MySqlParameter("@userId", userId)
                });

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Delete user successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("No user found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index)
            {
                int userId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete user ID {userId}?",
                    "Confirm deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    DeleteUserFromDatabase(userId);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchType = cbb_SearchType.SelectedItem?.ToString();
            string searchText = textBox_search.Text.Trim();

            if (string.IsNullOrEmpty(searchType) || string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please select search type and enter search content.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "";

            switch (searchType)
            {
                case "Id":
                    query = @"SELECT 
                                u.id AS ID, 
                                u.username AS Username, 
                                u.name AS Name, 
                                u.has_played AS HasPlayed, 
                                s.score AS Score, 
                                s.time AS Time 
                              FROM 
                                user u
                              LEFT JOIN 
                                score s ON u.id = s.user_id
                              WHERE 
                                u.role = 0 AND u.id = @searchValue";
                    break;

                case "Username":
                    query = @"SELECT 
                                u.id AS ID, 
                                u.username AS Username, 
                                u.name AS Name, 
                                u.has_played AS HasPlayed, 
                                s.score AS Score, 
                                s.time AS Time 
                              FROM 
                                user u
                              LEFT JOIN 
                                score s ON u.id = s.user_id
                              WHERE 
                                u.role = 0 AND u.username LIKE CONCAT('%', @searchValue, '%')";
                    break;

                default:
                    MessageBox.Show("Invalid search type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            try
            {
                DataTable table = DatabaseHelper.ExecuteQuery(query, new[]
                {
                    new MySqlParameter("@searchValue", searchText)
                });

                if (table.Rows.Count > 0)
                {
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("No results found.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
