using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class q1 : Form
    {
        private MultipleChoiceQuestion currentQuestion;
        private List<Question> questionBank;
        private int currentQuestionIndex;
        private startGame parentGame; 

        public q1(MultipleChoiceQuestion question, List<Question> questionBank, int questionIndex, startGame parentGame)
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
            lblQuestion.Text = currentQuestion.QuestionText;

            radioButton1.Text = currentQuestion.Options.Length > 0 ? currentQuestion.Options[0] : "N/A";
            radioButton2.Text = currentQuestion.Options.Length > 1 ? currentQuestion.Options[1] : "N/A";
            radioButton3.Text = currentQuestion.Options.Length > 2 ? currentQuestion.Options[2] : "N/A";
            radioButton4.Text = currentQuestion.Options.Length > 3 ? currentQuestion.Options[3] : "N/A";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int selectedOption = -1;
            if (radioButton1.Checked) selectedOption = 0;
            if (radioButton2.Checked) selectedOption = 1;
            if (radioButton3.Checked) selectedOption = 2;
            if (radioButton4.Checked) selectedOption = 3;

            if (selectedOption == -1)
            {
                MessageBox.Show("Please select an answer before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isCorrect = currentQuestion.CheckAnswer((selectedOption + 1).ToString());
            if (isCorrect)
            {
                MessageBox.Show("Correct answer!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parentGame.Score++;
            }
            else
            {
                MessageBox.Show($"Wrong answer. The correct answer is: {currentQuestion.GetCorrectAnswer()}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
