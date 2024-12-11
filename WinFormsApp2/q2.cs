using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class q2 : Form
    {
        private OpenEndedQuestion currentQuestion;
        private List<Question> questionBank;
        private int currentQuestionIndex;
        private startGame parentGame; 

        public q2(OpenEndedQuestion question, List<Question> questionBank, int questionIndex, startGame parentGame)
        {
            InitializeComponent();
            this.currentQuestion = question;
            this.questionBank = questionBank;
            this.currentQuestionIndex = questionIndex;
            this.parentGame = parentGame;

            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            label_Questionnum.Text = $"Q{currentQuestionIndex + 1} :";
            lblOpenQuestion.Text = currentQuestion.QuestionText;

            textBoxOpenAnswer.Text = string.Empty;
        }

        private void btnOpenSubmit_Click(object sender, EventArgs e)
        {
            string userAnswer = textBoxOpenAnswer.Text.Trim();

            if (string.IsNullOrEmpty(userAnswer))
            {
                MessageBox.Show("Please enter an answer before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool isCorrect = currentQuestion.CheckAnswer(userAnswer);
            if (isCorrect)
            {
                MessageBox.Show("Correct answer!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parentGame.Score++; 
            }
            else
            {
                string correctAnswers = string.Join(", ", currentQuestion.CorrectAnswers);
                MessageBox.Show($"Wrong answer. Correct answers are: {correctAnswers}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GoToNextQuestion();
        }

        private void GoToNextQuestion()
        {
            currentQuestionIndex++;

            if (currentQuestionIndex < questionBank.Count)
            {
                var nextQuestion = questionBank[currentQuestionIndex];
                Form nextForm = null;

                if (nextQuestion is MultipleChoiceQuestion mcq)
                {
                    nextForm = new q1(mcq, questionBank, currentQuestionIndex, parentGame);
                }
                else if (nextQuestion is OpenEndedQuestion oeq)
                {
                    nextForm = new q2(oeq, questionBank, currentQuestionIndex, parentGame);
                }
                else if (nextQuestion is TrueFalseQuestion tfq)
                {
                    nextForm = new q3(tfq, questionBank, currentQuestionIndex, parentGame);
                }

                if (nextForm != null)
                {
                    parentGame.userForm.OpenChildForm(nextForm); 
                }
            }
            else
            {
                parentGame.FinishGame(); 
                this.Close();

            }
        }
    }
}
