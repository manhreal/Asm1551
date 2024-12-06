using Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GameQuizWindowsApp
{
    public partial class q1 : Form
    {
        private Stopwatch stopwatch;
        private List<QuestionHelper.Question> questions;
        private int currentQuestionIndex = 0;
        private startGame mainForm;
        private userPlayGameForm userForm;
        private AuthenticationHelper.User currentUser;
        public int Score { get; set; }

        public q1(List<QuestionHelper.Question> questionsForPlay, int score, Stopwatch stopwatch, startGame mainForm, AuthenticationHelper.User currentUser, userPlayGameForm userForm)
        {
            InitializeComponent();
            questions = questionsForPlay;
            Score = score;
            this.stopwatch = stopwatch;
            this.mainForm = mainForm;
            this.currentUser = currentUser;
            this.userForm = userForm;
            LoadQuestion();
        }


        private void LoadQuestion()
        {
            if (currentQuestionIndex < 5)
            {
                label_Questionnum.Text = $"Q{currentQuestionIndex + 1}/{questions.Count} :";
                var question = questions[currentQuestionIndex];
                lblQuestion.Text = question.Text;

                if (question.Answers.Count >= 4)
                {
                    radioButton1.Text = question.Answers[0].Text;
                    radioButton2.Text = question.Answers[1].Text;
                    radioButton3.Text = question.Answers[2].Text;
                    radioButton4.Text = question.Answers[3].Text;
                }

                // Reset RadioButton
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            else
            {
                userForm.OpenChildForm(new q2(questions, Score, stopwatch, mainForm, currentUser, userForm));
                this.Close();
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Please select one answer before submitting!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isCorrect = CheckAnswer();
            if (isCorrect)
            {
                Score++;
                MessageBox.Show("Correct!", "Result");
            }
            currentQuestionIndex++;
            LoadQuestion();
        }

        private bool CheckAnswer()
        {
            var question = questions[currentQuestionIndex];
            string selectedAnswer = GetSelectedAnswer();
            foreach (var answer in question.Answers)
            {
                if (answer.IsCorrect && answer.Text == selectedAnswer)
                {
                    return true;
                }
            }
            return false;
        }

        private string GetSelectedAnswer()
        {
            if (radioButton1.Checked) return radioButton1.Text;
            if (radioButton2.Checked) return radioButton2.Text;
            if (radioButton3.Checked) return radioButton3.Text;
            if (radioButton4.Checked) return radioButton4.Text;
            return null;
        }
    }
}
