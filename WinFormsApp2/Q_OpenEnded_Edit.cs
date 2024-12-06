using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Q_OpenEnded_Edit : Form
    {
        public OpenEndedQuestion EditedQuestion { get; private set; }

        public Q_OpenEnded_Edit(OpenEndedQuestion question)
        {
            InitializeComponent();

            EditedQuestion = question;

            textBox1.Text = EditedQuestion.QuestionText; 
            textBox6.Text = string.Join(", ", EditedQuestion.CorrectAnswers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newQuestionText = textBox1.Text.Trim();
                string newCorrectAnswersInput = textBox6.Text.Trim();

                if (string.IsNullOrWhiteSpace(newQuestionText))
                {
                    MessageBox.Show("Question cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(newCorrectAnswersInput))
                {
                    MessageBox.Show("Correct answers cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] newCorrectAnswers = newCorrectAnswersInput
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(answer => answer.Trim())
                    .ToArray();

                if (newCorrectAnswers.Length == 0)
                {
                    MessageBox.Show("You must provide at least one correct answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EditedQuestion.QuestionText = newQuestionText;
                EditedQuestion.CorrectAnswers = new List<string>(newCorrectAnswers);

                MessageBox.Show("Question updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
