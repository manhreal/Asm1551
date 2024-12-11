using Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Helper
{
    public class QuestionHelper
    {
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

        public string AddMultichoiceQuestion(string questionText, string[] answers, int correctAnswerIndex)
        {
            try
            {
                string insertQuestionQuery = "INSERT INTO question (text, id_type) VALUES (@text, @id_type)";
                MySqlParameter[] questionParams = {
                    new MySqlParameter("@text", questionText),
                    new MySqlParameter("@id_type", 1) // Multichoice type
                };
                DatabaseHelper.ExecuteNonQuery(insertQuestionQuery, questionParams);

                string getLastIdQuery = "SELECT LAST_INSERT_ID()";
                int questionId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(getLastIdQuery));

                string insertAnswerQuery = "INSERT INTO answer (id_question, id_type, answer, is_correct) VALUES (@id_question, @id_type, @answer, @is_correct)";
                for (int i = 0; i < answers.Length; i++)
                {
                    MySqlParameter[] answerParams = {
                        new MySqlParameter("@id_question", questionId),
                        new MySqlParameter("@id_type", 1),
                        new MySqlParameter("@answer", answers[i]),
                        new MySqlParameter("@is_correct", i == correctAnswerIndex - 1 ? 1 : 0)
                    };
                    DatabaseHelper.ExecuteNonQuery(insertAnswerQuery, answerParams);
                }

                return "Question and answers added successfully.";
            }
            catch (Exception ex)
            {
                return "Error adding question: " + ex.Message;
            }
        }

        public string UpdateQuestionInDatabase(int questionId, string questionText, string answer1, string answer2, string answer3, string answer4, int correctAnswerIndex)
        {
            try
            {
                string updateQuestionQuery = "UPDATE question SET text = @text WHERE id = @id";
                MySqlParameter[] questionParams = {
                    new MySqlParameter("@text", questionText),
                    new MySqlParameter("@id", questionId)
                };
                DatabaseHelper.ExecuteNonQuery(updateQuestionQuery, questionParams);

                string getAnswersQuery = "SELECT id FROM answer WHERE id_question = @questionId";
                MySqlParameter[] getAnswerParams = { new MySqlParameter("@questionId", questionId) };
                DataTable answerTable = DatabaseHelper.ExecuteQuery(getAnswersQuery, getAnswerParams);

                if (answerTable.Rows.Count < 4)
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
                    MySqlParameter[] answerParams = {
                        new MySqlParameter("@answerId", Convert.ToInt32(answerTable.Rows[i]["id"])),
                        new MySqlParameter("@answer", answers[i]),
                        new MySqlParameter("@is_correct", i == correctAnswerIndex ? 1 : 0)
                    };
                    DatabaseHelper.ExecuteNonQuery(answerQuery, answerParams);
                }

                return "Question updated successfully.";
            }
            catch (Exception ex)
            {
                return "Error updating question: " + ex.Message;
            }
        }

        public string AddOpenQuestionToDatabase(string questionText, string[] answers)
        {
            try
            {
                string insertQuestionQuery = "INSERT INTO question (text, id_type) VALUES (@questionText, 2)";
                MySqlParameter[] questionParams = { new MySqlParameter("@questionText", questionText) };
                DatabaseHelper.ExecuteNonQuery(insertQuestionQuery, questionParams);

                string getLastIdQuery = "SELECT LAST_INSERT_ID()";
                int questionId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(getLastIdQuery));

                string insertAnswerQuery = "INSERT INTO answer (id_question, id_type, answer, is_correct) VALUES (@id_question, 2, @answer, 1)";
                foreach (var answer in answers)
                {
                    MySqlParameter[] answerParams = {
                        new MySqlParameter("@id_question", questionId),
                        new MySqlParameter("@answer", answer.Trim())
                    };
                    DatabaseHelper.ExecuteNonQuery(insertAnswerQuery, answerParams);
                }

                return "Open question added successfully.";
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
                string updateQuestionQuery = "UPDATE question SET text = @questionText WHERE id = @questionId";
                MySqlParameter[] questionParams = {
                    new MySqlParameter("@questionText", questionText),
                    new MySqlParameter("@questionId", questionId)
                };
                DatabaseHelper.ExecuteNonQuery(updateQuestionQuery, questionParams);

                string deleteAnswersQuery = "DELETE FROM answer WHERE id_question = @questionId AND id_type = 2";
                MySqlParameter[] deleteParams = { new MySqlParameter("@questionId", questionId) };
                DatabaseHelper.ExecuteNonQuery(deleteAnswersQuery, deleteParams);

                string insertAnswerQuery = "INSERT INTO answer (id_question, id_type, answer, is_correct) VALUES (@questionId, 2, @answer, 1)";
                foreach (var answer in answers)
                {
                    MySqlParameter[] answerParams = {
                        new MySqlParameter("@questionId", questionId),
                        new MySqlParameter("@answer", answer.Trim())
                    };
                    DatabaseHelper.ExecuteNonQuery(insertAnswerQuery, answerParams);
                }

                return "Open question updated successfully.";
            }
            catch (Exception ex)
            {
                return "Error updating question: " + ex.Message;
            }
        }

        public string AddTFQuestion(string questionText, int questionTypeId)
        {
            try
            {
                string insertQuestionQuery = "INSERT INTO question (text, id_type) VALUES (@text, @id_type)";
                MySqlParameter[] questionParams = {
                    new MySqlParameter("@text", questionText),
                    new MySqlParameter("@id_type", questionTypeId)
                };
                DatabaseHelper.ExecuteNonQuery(insertQuestionQuery, questionParams);

                string getLastIdQuery = "SELECT LAST_INSERT_ID()";
                int questionId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(getLastIdQuery));

                return questionId.ToString();
            }
            catch (Exception ex)
            {
                return "Error adding question: " + ex.Message;
            }
        }

        public void AddTFAnswer(string questionId, int questionTypeId, string answer, int isCorrect)
        {
            try
            {
                string insertAnswerQuery = "INSERT INTO answer (id_question, id_type, answer, is_correct) VALUES (@id_question, @id_type, @answer, @is_correct)";
                MySqlParameter[] answerParams = {
                    new MySqlParameter("@id_question", questionId),
                    new MySqlParameter("@id_type", questionTypeId),
                    new MySqlParameter("@answer", answer),
                    new MySqlParameter("@is_correct", isCorrect)
                };
                DatabaseHelper.ExecuteNonQuery(insertAnswerQuery, answerParams);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding answer: " + ex.Message);
            }
        }

        public void UpdateTFQuestion(int questionId, string questionText)
        {
            try
            {
                string updateQuestionQuery = "UPDATE question SET text = @text WHERE id = @id";
                MySqlParameter[] questionParams = {
                    new MySqlParameter("@text", questionText),
                    new MySqlParameter("@id", questionId)
                };
                DatabaseHelper.ExecuteNonQuery(updateQuestionQuery, questionParams);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating question: " + ex.Message);
            }
        }

        public void UpdateTFAnswer(int questionId, string correctAnswer)
        {
            try
            {
                string updateAnswerQuery = "UPDATE answer SET answer = @answer WHERE id_question = @questionId AND id_type = 3 AND is_correct = 1";
                MySqlParameter[] answerParams = {
                    new MySqlParameter("@answer", correctAnswer.Equals("True", StringComparison.OrdinalIgnoreCase) ? "True" : "False"),
                    new MySqlParameter("@questionId", questionId)
                };
                DatabaseHelper.ExecuteNonQuery(updateAnswerQuery, answerParams);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating answer: " + ex.Message);
            }
        }
    }
}
