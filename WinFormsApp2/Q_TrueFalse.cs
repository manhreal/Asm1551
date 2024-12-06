using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Q_TrueFalse : Form
    {
        private List<Question> questionBank;
        public Q_TrueFalse(List<Question> questions)
        {
            InitializeComponent();
            questionBank = questions;
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

                var newQuestion = new TrueFalseQuestion(questionText, correctAnswer ? "True" : "False", correctAnswer);
                questionBank.Add(newQuestion);

                MessageBox.Show("Question added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
