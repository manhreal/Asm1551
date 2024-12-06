using Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Helper
{
    public class QuestionHelper
    {
        private DatabaseHelper _database;
        private string _connectionString = "Server=localhost;Database=dataGameQuiz;Uid=root;Pwd=;";

       
        public class QuestionType
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Question
        {
            public int Id { get; set; }
            public string Text { get; set; }
            public QuestionType Type { get; set; }
            public List<Answer> Answers { get; set; }
            public string CorrectAnswer { get; set; }

            public Question()
            {
                Answers = new List<Answer>();
            }
        }

        public class Answer
        {
            public int Id { get; set; }
            public string Text { get; set; }
            public bool IsCorrect { get; set; }
        }



        public QuestionHelper() { }

        public string AddMultichoiceQuestion(string questionText, string[] answers, int correctAnswerIndex)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuestionQuery = "INSERT INTO question (text, id_type) VALUES (@text, @id_type)";
                    MySqlCommand questionCommand = new MySqlCommand(insertQuestionQuery, connection);
                    questionCommand.Parameters.AddWithValue("@text", questionText);
                    questionCommand.Parameters.AddWithValue("@id_type", 1); 

                    questionCommand.ExecuteNonQuery();
                    int questionId = (int)questionCommand.LastInsertedId;

                    string insertAnswerQuery = "INSERT INTO answer (id_question, id_type, answer, is_correct) VALUES (@id_question, @id_type, @answer, @is_correct)";
                    for (int i = 0; i < answers.Length; i++)
                    {
                        MySqlCommand answerCommand = new MySqlCommand(insertAnswerQuery, connection);
                        answerCommand.Parameters.AddWithValue("@id_question", questionId);
                        answerCommand.Parameters.AddWithValue("@id_type", 1);
                        answerCommand.Parameters.AddWithValue("@answer", answers[i]);
                        answerCommand.Parameters.AddWithValue("@is_correct", i == correctAnswerIndex - 1 ? 1 : 0);

                        answerCommand.ExecuteNonQuery();
                    }

                    return "Question and answer added successfully.";
                }
                catch (Exception ex)
                {
                    return "Error adding question: " + ex.Message;
                }
            }
        }

        public string UpdateQuestionInDatabase(int questionId, string questionText, string answer1, string answer2, string answer3, string answer4, int correctAnswerIndex)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string questionQuery = "UPDATE question SET text = @text WHERE id = @id";
                    MySqlCommand questionCmd = new MySqlCommand(questionQuery, connection);
                    questionCmd.Parameters.AddWithValue("@id", questionId);
                    questionCmd.Parameters.AddWithValue("@text", questionText);
                    questionCmd.ExecuteNonQuery();

                    string getAnswersQuery = "SELECT id FROM answer WHERE id_question = @questionId";
                    MySqlCommand getAnswersCmd = new MySqlCommand(getAnswersQuery, connection);
                    getAnswersCmd.Parameters.AddWithValue("@questionId", questionId);

                    var answerIds = new List<int>();
                    using (var reader = getAnswersCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            answerIds.Add(reader.GetInt32("id"));
                        }
                    }

                    if (answerIds.Count < 4)
                    {
                        return "There are not enough 4 answers for this question in the database.";
                    }

                    if (correctAnswerIndex < 1 || correctAnswerIndex > 4)
                    {
                        return "Please choose the correct answer from 1 to 4.";
                    }

                    correctAnswerIndex -= 1;

                    string[] answers = { answer1, answer2, answer3, answer4 };

                    for (int i = 0; i < answers.Length; i++)
                    {
                        string answerQuery = "UPDATE answer SET answer = @answer, is_correct = @is_correct WHERE id = @answerId";
                        MySqlCommand answerCmd = new MySqlCommand(answerQuery, connection);
                        answerCmd.Parameters.AddWithValue("@answerId", answerIds[i]);
                        answerCmd.Parameters.AddWithValue("@answer", answers[i]);
                        answerCmd.Parameters.AddWithValue("@is_correct", i == correctAnswerIndex ? 1 : 0);

                        answerCmd.ExecuteNonQuery();
                    }

                    return "Question updated successfully.";
                }
            }
            catch (Exception ex)
            {
                return "Error updating questionError updating question: " + ex.Message;
            }
        }
        public string AddOpenQuestionToDatabase(string questionText, string[] answers)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string queryInsertQuestion = "INSERT INTO question (text, id_type) VALUES (@questionText, 2)";

                    using (var cmdInsertQuestion = new MySqlCommand(queryInsertQuestion, connection))
                    {
                        cmdInsertQuestion.Parameters.AddWithValue("@questionText", questionText);
                        cmdInsertQuestion.ExecuteNonQuery();
                    }

                    var result = new MySqlCommand("SELECT LAST_INSERT_ID();", connection).ExecuteScalar();
                    long questionId = Convert.ToInt64(result);

                    string queryInsertAnswer = "INSERT INTO answer (id_question, id_type, answer, is_correct) VALUES (@questionId, 2, @answer, @isCorrect)";

                    foreach (var answer in answers)
                    {
                        string trimmedAnswer = answer.Trim();
                        int isCorrect = 1;

                        using (var cmdInsertAnswer = new MySqlCommand(queryInsertAnswer, connection))
                        {
                            cmdInsertAnswer.Parameters.AddWithValue("@questionId", questionId);
                            cmdInsertAnswer.Parameters.AddWithValue("@answer", trimmedAnswer);
                            cmdInsertAnswer.Parameters.AddWithValue("@isCorrect", isCorrect);
                            cmdInsertAnswer.ExecuteNonQuery();
                        }
                    }

                    return "Open question added successfully.";
                }
            }
            catch (Exception ex)
            {
                return "Error adding question: " + ex.Message;
            }
        }

        public string UpdateOpenQuestionInDatabase(int questionId, string questionText, string[] answers)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string updateQuestionQuery = "UPDATE question SET text = @questionText WHERE id = @questionId";
                            using (var cmdUpdateQuestion = new MySqlCommand(updateQuestionQuery, connection, transaction))
                            {
                                cmdUpdateQuestion.Parameters.AddWithValue("@questionText", questionText);
                                cmdUpdateQuestion.Parameters.AddWithValue("@questionId", questionId);
                                cmdUpdateQuestion.ExecuteNonQuery();
                            }

                            string deleteAnswersQuery = "DELETE FROM answer WHERE id_question = @questionId AND id_type = 2";
                            using (var cmdDeleteAnswers = new MySqlCommand(deleteAnswersQuery, connection, transaction))
                            {
                                cmdDeleteAnswers.Parameters.AddWithValue("@questionId", questionId);
                                cmdDeleteAnswers.ExecuteNonQuery();
                            }

                            string insertAnswerQuery = "INSERT INTO answer (id_question, id_type, answer, is_correct) VALUES (@questionId, 2, @answer, 1)";
                            foreach (var answer in answers)
                            {
                                using (var cmdInsertAnswer = new MySqlCommand(insertAnswerQuery, connection, transaction))
                                {
                                    cmdInsertAnswer.Parameters.AddWithValue("@questionId", questionId);
                                    cmdInsertAnswer.Parameters.AddWithValue("@answer", answer.Trim());
                                    cmdInsertAnswer.ExecuteNonQuery();
                                }
                            }
                            // Commit transaction
                            transaction.Commit();
                            return "Question updated successfully!";
                        }
                        catch (Exception ex)
                        {
                            // If there is an error, rollback the transaction
                            transaction.Rollback();
                            return "Error updating questionError updating question: " + ex.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error connecting to database: " + ex.Message;
            }
        }

        public string AddTFQuestion(string questionText, int questionTypeId)
        {
            string queryInsertQuestion = "INSERT INTO question (text, id_type) VALUES (@questionText, @questionTypeId)";

            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (var cmd = new MySqlCommand(queryInsertQuestion, connection))
                    {
                        cmd.Parameters.AddWithValue("@questionText", questionText);
                        cmd.Parameters.AddWithValue("@questionTypeId", questionTypeId);
                        cmd.ExecuteNonQuery();
                    }

                    var result = new MySqlCommand("SELECT LAST_INSERT_ID();", connection).ExecuteScalar();
                    return result.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding question: " + ex.Message);
                }
            }
        }

        public void AddTFAnswer(string questionId, int questionTypeId, string answer, int isCorrect)
        {
            string queryInsertAnswer = "INSERT INTO answer (id_question, id_type, answer, is_correct) VALUES (@questionId, @questionTypeId, @answer, @isCorrect)";

            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (var cmd = new MySqlCommand(queryInsertAnswer, connection))
                    {
                        cmd.Parameters.AddWithValue("@questionId", questionId);
                        cmd.Parameters.AddWithValue("@questionTypeId", questionTypeId);
                        cmd.Parameters.AddWithValue("@answer", answer);
                        cmd.Parameters.AddWithValue("@isCorrect", isCorrect);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding answer: " + ex.Message);
                }
            }
        }

        public void UpdateTFQuestion(int questionId, string questionText)
        {
            string updateQuestionQuery = "UPDATE question SET text = @questionText WHERE id = @questionId";

            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (var cmdUpdateQuestion = new MySqlCommand(updateQuestionQuery, connection))
                    {
                        cmdUpdateQuestion.Parameters.AddWithValue("@questionText", questionText);
                        cmdUpdateQuestion.Parameters.AddWithValue("@questionId", questionId);
                        cmdUpdateQuestion.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating questionError updating question: " + ex.Message);
                }
            }
        }

        public void UpdateTFAnswer(int questionId, string correctAnswer)
        {
            string updateAnswerQuery = "UPDATE answer SET answer = @correctAnswer WHERE id_question = @questionId AND id_type = 3 AND is_correct = 1";

            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (var cmdUpdateAnswer = new MySqlCommand(updateAnswerQuery, connection))
                    {
                        cmdUpdateAnswer.Parameters.AddWithValue("@correctAnswer", correctAnswer.Equals("True", StringComparison.OrdinalIgnoreCase) ? "True" : "False");
                        cmdUpdateAnswer.Parameters.AddWithValue("@questionId", questionId);
                        cmdUpdateAnswer.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating answer: " + ex.Message);
                }
            }
        }
    }
}
