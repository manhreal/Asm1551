using Helper;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace GameQuizWindowsApp
{
    public partial class Question_TF_update : Form
    {
        public int QuestionId { get; set; }
        public string CorrectAnswer { get; set; }
        public string QuestionText
        {
            get => textBox_Question.Text;
            set => textBox_Question.Text = value;
        }

        private QuestionHelper _questionHelper;

        public Question_TF_update(int questionId, string correctAnswer)
        {
            this.QuestionId = questionId;
            this.CorrectAnswer = correctAnswer;
            InitializeComponent();
            _questionHelper = new QuestionHelper();
            LoadQuestionData();
        }

        private void LoadQuestionData()
        {
            if (QuestionId <= 0)
            {
                MessageBox.Show("No questions selected.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT q.text, a.answer FROM question q " +
                           "JOIN answer a ON q.id = a.id_question " +
                           "WHERE q.id = @questionId AND a.id_type = 3 AND a.is_correct = 1";

            using (var conn = new MySqlConnection("Server=localhost;Database=dataGameQuiz;Uid=root;Pwd=;"))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@questionId", QuestionId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                // Hiển thị câu hỏi
                                textBox_Question.Text = reader["text"].ToString();

                                // Hiển thị đáp án đúng (không phân biệt hoa thường)
                                string correctAnswer = reader["answer"].ToString().Trim();
                                if (correctAnswer.Equals("True", StringComparison.OrdinalIgnoreCase))
                                {
                                    comboBox1.SelectedItem = "True";
                                }
                                else if (correctAnswer.Equals("False", StringComparison.OrdinalIgnoreCase))
                                {
                                    comboBox1.SelectedItem = "False";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy dữ liệu câu hỏi hoặc đáp án đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading question data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string questionText = textBox_Question.Text.Trim();
            string correctAnswer = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(questionText) || string.IsNullOrEmpty(correctAnswer))
            {
                MessageBox.Show("Please fill in the question information completely and choose the correct answer.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Update questions and answers via QuestionHelper
                _questionHelper.UpdateTFQuestion(QuestionId, questionText);
                _questionHelper.UpdateTFAnswer(QuestionId, correctAnswer);

                MessageBox.Show("Question updated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating question: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
