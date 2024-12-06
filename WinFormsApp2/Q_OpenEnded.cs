using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Q_OpenEnded : Form
    {
        private List<Question> questionBank;
        public Q_OpenEnded(List<Question> questionBank)
        {
            this.questionBank = questionBank;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string questionText = textBox1.Text.Trim();

                if (string.IsNullOrWhiteSpace(questionText))
                {
                    MessageBox.Show("Question cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string correctAnswersInput = textBox6.Text.Trim();
                if (string.IsNullOrWhiteSpace(correctAnswersInput))
                {
                    MessageBox.Show("Correct answers cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] correctAnswers = correctAnswersInput.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                             .Select(answer => answer.Trim())
                                                             .ToArray();

                if (correctAnswers.Length == 0)
                {
                    MessageBox.Show("You must provide at least one correct answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                OpenEndedQuestion newQuestion = new OpenEndedQuestion(
                    questionText, 
                    string.Join(", ", correctAnswers), 
                    new List<string>(correctAnswers)
                );

                questionBank.Add(newQuestion);

                MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
