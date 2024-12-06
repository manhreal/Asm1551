using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class startGame : Form
    {
        public userPlayGameForm userForm;
        public List<Question> questionBank = new List<Question>();
        public int Score { get; set; } = 0; 
        public Stopwatch stopwatch = new Stopwatch(); 
        public int currentQuestionIndex = 0;

        public startGame(List<Question> questionBank, userPlayGameForm userForm)
        {
            InitializeComponent();
            this.questionBank = questionBank;
            this.userForm = userForm;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (questionBank == null || questionBank.Count == 0)
            {
                MessageBox.Show("No questions available in the question bank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stopwatch.Start();
            var firstQuestion = questionBank[currentQuestionIndex];

            if (firstQuestion is MultipleChoiceQuestion)
            {
                q1 q1Form = new q1((MultipleChoiceQuestion)firstQuestion, questionBank, currentQuestionIndex, this);
                userForm.OpenChildForm(q1Form);
            }
            else if (firstQuestion is OpenEndedQuestion)
            {
                q2 q2Form = new q2((OpenEndedQuestion)firstQuestion, questionBank, currentQuestionIndex, this);
                userForm.OpenChildForm(q2Form);
            }
            else if (firstQuestion is TrueFalseQuestion)
            {
                q3 q3Form = new q3((TrueFalseQuestion)firstQuestion, questionBank, currentQuestionIndex, this);
                userForm.OpenChildForm(q3Form);
            }
            else
            {
                MessageBox.Show("Unsupported question type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FinishGame()
        {
            stopwatch.Stop();

            TimeSpan elapsed = stopwatch.Elapsed;
            int minutes = elapsed.Minutes;
            int seconds = elapsed.Seconds;

            MessageBox.Show($"You have completed all questions!\nScore: {Score}/{questionBank.Count}\nTime taken: {minutes} minutes {seconds} seconds.",
                "Game Over",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            stopwatch.Reset();
            currentQuestionIndex = 0;
            Score = 0;
        }
    }
}
