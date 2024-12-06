using Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace GameQuizWindowsApp
{
    public partial class q2 : Form
    {
        private Stopwatch stopwatch;
        private startGame mainForm;
        private userPlayGameForm userForm;
        private List<QuestionHelper.Question> questions;
        private int currentQuestionIndex;
        private AuthenticationHelper.User currentUser;
        public int Score { get; set; }

        public q2(List<QuestionHelper.Question> questionsForPlay, int score, Stopwatch stopwatch, startGame mainForm, AuthenticationHelper.User currentUser, userPlayGameForm userForm)
        {
            InitializeComponent();
            questions = questionsForPlay;
            Score = score;
            this.stopwatch = stopwatch;
            this.mainForm = mainForm;
            this.userForm = userForm;
            this.currentUser = currentUser;
            currentQuestionIndex = 5;
            LoadOpenQuestion();
        }

        private void LoadOpenQuestion()
        {
            if (currentQuestionIndex < 10)
            {
                label_Questionnum.Text = $"Q{currentQuestionIndex + 1}/{questions.Count} :";
                lblOpenQuestion.Text = questions[currentQuestionIndex].Text;

                // Reset textbox
                textBoxOpenAnswer.Text = string.Empty;
            }
            else
            {
                userForm.OpenChildForm(new q3(questions, Score, stopwatch, mainForm, currentUser, userForm));
                this.Close();
            }
        }

        private void btnOpenSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOpenAnswer.Text))
            {
                MessageBox.Show("Please enter your answer before submitting!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userAnswer = textBoxOpenAnswer.Text;
            var correctAnswers = questions[currentQuestionIndex].Answers;
            bool isCorrect = false;

            foreach (var answer in correctAnswers)
            {
                if (string.Equals(userAnswer, answer.Text, StringComparison.OrdinalIgnoreCase) && answer.IsCorrect)
                {
                    isCorrect = true;
                    break;
                }
            }

            if (isCorrect)
            {
                Score++;
                MessageBox.Show("Correct!", "Result");
            }
            currentQuestionIndex++;
            LoadOpenQuestion();
        }

    }
}
