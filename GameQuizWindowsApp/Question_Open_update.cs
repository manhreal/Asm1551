using Helper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameQuizWindowsApp
{
    public partial class Question_Open_update : Form
    {
        public int QuestionId { get; set; }
        public List<string> CorrectAnswers { get; set; }
        public string QuestionText
        {
            get => textBox_Question.Text;
            set => textBox_Question.Text = value;
        }

        private QuestionHelper _questionHelper;

        public Question_Open_update(int questionId, List<string> correctAnswers)
        {
            InitializeComponent();
            _questionHelper = new QuestionHelper();
            this.QuestionId = questionId;
            this.CorrectAnswers = correctAnswers; 
            LoadQuestionData();
        }

        private void LoadQuestionData()
        {
            string query = "SELECT q.text, a.answer FROM question q " +
                           "JOIN answer a ON q.id = a.id_question " +
                           "WHERE q.id = @questionId AND a.id_type = 2";

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
                                textBox_Question.Text = reader["text"].ToString();

                                List<string> answers = new List<string>();
                                do
                                {
                                    answers.Add(reader["answer"].ToString().Trim());
                                } while (reader.Read());

                                textBox_Answer.Text = string.Join(", ", answers);
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string questionText = textBox_Question.Text.Trim();
            string answersText = textBox_Answer.Text.Trim();

            if (string.IsNullOrEmpty(questionText) || string.IsNullOrEmpty(answersText))
            {
                MessageBox.Show("Please enter question and answers.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] answers = answersText.Split(',');

            string resultMessage = _questionHelper.UpdateOpenQuestionInDatabase(QuestionId, questionText, answers);

            MessageBox.Show(resultMessage, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultMessage.Contains("Success"))
            {
                this.Close();
            }
        }
    }
}
