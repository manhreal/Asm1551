using Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace GameQuizWindowsApp
{
    public partial class q3 : Form
    {
        private Stopwatch stopwatch;
        private startGame mainForm;
        private userPlayGameForm userForm;
        private List<QuestionHelper.Question> questions;
        private int currentQuestionIndex;
        private AuthenticationHelper.User currentUser;

        public int Score { get; set; }

        public q3(List<QuestionHelper.Question> questionsForPlay, int score, Stopwatch stopwatch, startGame mainForm, AuthenticationHelper.User currentUser, userPlayGameForm userForm)
        {
            InitializeComponent();
            questions = questionsForPlay;
            Score = score;
            this.stopwatch = stopwatch;
            this.mainForm = mainForm;
            this.userForm = userForm;
            this.currentUser = currentUser;
            currentQuestionIndex = 10;
            LoadTrueFalseQuestion();           
        }

        private void LoadTrueFalseQuestion()
        {
            if (currentQuestionIndex < 15)
            {
                label_Questionnum.Text = $"Q{currentQuestionIndex + 1}/{questions.Count} :";
                lblQuestion.Text = questions[currentQuestionIndex].Text;
            }
            else
            {
                stopwatch.Stop();
                double timeElapsed = stopwatch.Elapsed.TotalSeconds;

                MessageBox.Show($"Result: {Score}/15\nTime: {timeElapsed:F2}s", "Score");
                mainForm.SaveHighScore(Score, timeElapsed, currentUser.Id);

                DialogResult result = MessageBox.Show("Do you want to see the correct answers to the questions above?", "View answer", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ShowCorrectAnswers();
                }

                this.Close();
            }
        }

        private void ShowCorrectAnswers()
        {
            string correctAnswersText = "";

            for (int i = 0; i < questions.Count; i++)
            {
                var question = questions[i];
                string correctAnswer = "";

                // Process the correct answer according to the question type
                switch (question.Type.Id)
                {
                    case 1: // Multiple choice
                        correctAnswer = question.Answers.Find(a => a.IsCorrect)?.Text ?? "No answer";
                        break;

                    case 2: // Open
                        var openAnswers = question.Answers.FindAll(a => a.IsCorrect);
                        correctAnswer = string.Join(", ", openAnswers.ConvertAll(a => a.Text));
                        break;

                    case 3: // True/False
                        correctAnswer = question.Answers.Find(a => a.IsCorrect)?.Text ?? "No answer";
                        break;

                    default:
                        correctAnswer = "Unspecified question type";
                        break;
                }

                // Add questions and answers to the display content
                correctAnswersText += $"Q{i + 1}: {question.Text}\n";
                correctAnswersText += $"Answer: {correctAnswer}\n\n";
            }

            MessageBox.Show(correctAnswersText, "Correct answer");
        }


        private void btnTrue_Click(object sender, EventArgs e)
        {
            EvaluateAnswer(true);
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            EvaluateAnswer(false);
        }

        private void EvaluateAnswer(bool userAnswer)
        {
            if (currentQuestionIndex < questions.Count)
            {
                bool isCorrect = string.Equals(questions[currentQuestionIndex].CorrectAnswer, userAnswer ? "True" : "False", StringComparison.OrdinalIgnoreCase);

                if (isCorrect)
                {
                    Score++;
                    MessageBox.Show("Correct!", "Result");
                }

                currentQuestionIndex++;
                LoadTrueFalseQuestion();
            }
            else
            {
                MessageBox.Show("No further questions.", "Error");
                this.Close();
            }
        }
    }
}
