using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class q3 : Form
    {
        private TrueFalseQuestion currentQuestion;
        private List<Question> questionBank;
        private int currentQuestionIndex;
        private startGame parentGame; 

        public q3(TrueFalseQuestion question, List<Question> questionBank, int questionIndex, startGame parentGame)
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
            label_Questionnum.Text = $"Question {currentQuestionIndex + 1}";
            lblQuestion.Text = currentQuestion.QuestionText;
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            ProcessAnswer("true");
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            ProcessAnswer("false");
        }

        private void ProcessAnswer(string userAnswer)
        {
            if (currentQuestion.CheckAnswer(userAnswer))
            {
                MessageBox.Show("Correct answer!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parentGame.Score++;
            }
            else
            {
                MessageBox.Show($"Wrong answer. The correct answer is: {currentQuestion.GetCorrectAnswer()}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
