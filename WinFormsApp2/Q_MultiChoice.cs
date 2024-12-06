using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Q_MultiChoice : Form
    {
        private List<Question> questionBank = new List<Question>();
        public Q_MultiChoice(List<Question> questionBank)
        {
            this.questionBank = questionBank;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string questionText = textBox1.Text;
            string[] options = new string[4]
            {
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text
            };
            string correctOptionText = textBox6.Text;

            if (string.IsNullOrEmpty(questionText) || options.Any(opt => string.IsNullOrEmpty(opt)))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(correctOptionText, out int correctOption) || correctOption < 1 || correctOption > 4)
            {
                MessageBox.Show("Please enter a valid correct option (1 to 4).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MultipleChoiceQuestion newQuestion = new MultipleChoiceQuestion(
                questionText,
                options[correctOption - 1],
                options,
                correctOption - 1
            );

            questionBank.Add(newQuestion);
            MessageBox.Show("Multiple Choice Question added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Q_MultiChoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
