using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Helper;
using MySql.Data.MySqlClient;

namespace GameQuizWindowsApp
{
    public partial class startGame : Form
    {
        private const string ConnectionString = "Server=localhost;Database=dataGameQuiz;Uid=root;Pwd=;";
        public List<QuestionHelper.Question> questionsForPlay { get; set; }
        private AuthenticationHelper.User currentUser;
        public int Score { get; set; }
        private Stopwatch stopwatch;
        public userPlayGameForm userForm;

        public startGame(AuthenticationHelper.User user, userPlayGameForm userForm)
        {
            InitializeComponent();
            this.userForm = userForm;
            currentUser = user ?? throw new ArgumentNullException(nameof(currentUser), "User cannot be null.");
            stopwatch = new Stopwatch();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            LoadQuestionsForPlay();
            if (questionsForPlay != null && questionsForPlay.Count > 0)
            {
                stopwatch.Start();
                int initialScore = 0;
                userForm.OpenChildForm(new q1(questionsForPlay, initialScore, stopwatch, this, currentUser, userForm));
                this.Hide();
            }
            else
            {
                MessageBox.Show("No questions loaded. Please check the database.");
            }
        }

        private void LoadQuestionsForPlay()
        {
            questionsForPlay = new List<QuestionHelper.Question>();
            using (var connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                // Get 5 random multiple choice questions
                string query = "SELECT * FROM Question WHERE id_type = 1 ORDER BY RAND() LIMIT 5";
                LoadQuestionsByType(query, connection);
                // Get 5 random open questions
                query = "SELECT * FROM Question WHERE id_type = 2 ORDER BY RAND() LIMIT 5";
                LoadQuestionsByType(query, connection);
                // Get 5 random true/false questions
                query = "SELECT * FROM Question WHERE id_type = 3 ORDER BY RAND() LIMIT 5";
                LoadQuestionsByType(query, connection);
            }
        }

        private void LoadQuestionsByType(string query, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var question = new QuestionHelper.Question
                    {
                        Id = reader.GetInt32("id"),
                        Text = reader.GetString("text"),
                        Type = new QuestionHelper.QuestionType
                        {
                            Id = reader.GetInt32("id_type"),
                            Name = GetQuestionTypeName(reader.GetInt32("id_type"))
                        }
                    };
                    questionsForPlay.Add(question);
                }
            }
            foreach (var question in questionsForPlay)
            {
                question.Answers = LoadAnswersForQuestion(question.Id, connection);
            }
        }

        private List<QuestionHelper.Answer> LoadAnswersForQuestion(int questionId, MySqlConnection connection)
        {
            List<QuestionHelper.Answer> answers = new List<QuestionHelper.Answer>();
            string query = "SELECT * FROM Answer WHERE id_question = @questionId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@questionId", questionId);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    answers.Add(new QuestionHelper.Answer
                    {
                        Id = reader.GetInt32("id"),
                        Text = reader.GetString("answer"),
                        IsCorrect = reader.GetBoolean("is_correct")
                    });
                }
            }
            return answers;
        }

        private string GetQuestionTypeName(int typeId)
        {
            return typeId switch
            {
                1 => "Multiple choice",
                2 => "Open",
                3 => "True/False",
                _ => "Unknown"
            };
        }

        public void SaveHighScore(int score, double time, int userId)
        {
            using (var connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                var command = new MySqlCommand
                {
                    Connection = connection,
                    CommandText = @"SELECT score, time FROM score WHERE user_id = @userId"
                };
                command.Parameters.AddWithValue("@userId", userId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int existingScore = reader.GetInt32(0);
                        double existingTime = reader.GetDouble(1);

                        if (score > existingScore || (score == existingScore && time < existingTime))
                        {
                            reader.Close();
                            command.CommandText = @"UPDATE score SET score = @score, time = @time WHERE user_id = @userId";
                            command.Parameters.AddWithValue("@score", score);
                            command.Parameters.AddWithValue("@time", time);
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        reader.Close();
                        command.CommandText = @"INSERT INTO score (user_id, score, time) VALUES (@userId, @score, @time)";
                        command.Parameters.AddWithValue("@score", score);
                        command.Parameters.AddWithValue("@time", time);
                        command.ExecuteNonQuery();
                    }
                }
                command.CommandText = @"UPDATE user SET has_played = 1 WHERE id = @userId";
                command.ExecuteNonQuery();
            }
        }
    }
}
