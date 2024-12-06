using MySql.Data.MySqlClient;
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
    public partial class Question_delete : Form
    {
        private int questionId;
        public event Action QuestionDeleted;

        public Question_delete(int id, string questionText)
        {
            InitializeComponent();
            questionId = id;
            label_Question.Text = questionText;
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=dataGameQuiz;Uid=root;Pwd=;"))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM question WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", questionId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Question deleted successfully.");
                    QuestionDeleted?.Invoke();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting question: " + ex.Message);
                }
            }
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
