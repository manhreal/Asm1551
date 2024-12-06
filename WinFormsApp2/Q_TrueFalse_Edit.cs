using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Q_TrueFalse_Edit : Form
    {
        public TrueFalseQuestion EditedQuestion { get; private set; }

        public Q_TrueFalse_Edit(TrueFalseQuestion question)
        {
            InitializeComponent();
            EditedQuestion = question;

            textBox1.Text = EditedQuestion.QuestionText;

            comboBox1.SelectedItem = EditedQuestion.CorrectAnswer ? "True" : "False";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string questionText = textBox1.Text.Trim();

                if (string.IsNullOrEmpty(questionText))
                {
                    MessageBox.Show("Please enter a question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string correctAnswerStr = comboBox1.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(correctAnswerStr))
                {
                    MessageBox.Show("Please select a correct answer (True/False).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool correctAnswer = correctAnswerStr.Equals("True", StringComparison.OrdinalIgnoreCase);

                EditedQuestion.QuestionText = questionText;
                EditedQuestion.CorrectAnswer = correctAnswer;

                MessageBox.Show("Question updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
