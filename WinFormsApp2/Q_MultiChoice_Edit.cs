using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Q_MultiChoice_Edit : Form
    {
        public MultipleChoiceQuestion EditedQuestion { get; private set; }

        public Q_MultiChoice_Edit(MultipleChoiceQuestion question)
        {
            InitializeComponent();

            EditedQuestion = question;
            textBox1.Text = EditedQuestion.QuestionText;

            if (EditedQuestion.Options.Length >= 4)
            {
                textBox2.Text = EditedQuestion.Options[0];
                textBox3.Text = EditedQuestion.Options[1];
                textBox4.Text = EditedQuestion.Options[2];
                textBox5.Text = EditedQuestion.Options[3];
            }

            textBox6.Text = (EditedQuestion.CorrectOption + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EditedQuestion.QuestionText = textBox1.Text;

                EditedQuestion.Options[0] = textBox2.Text;
                EditedQuestion.Options[1] = textBox3.Text;
                EditedQuestion.Options[2] = textBox4.Text;
                EditedQuestion.Options[3] = textBox5.Text;

                if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Please fill in all the options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (int.TryParse(textBox6.Text, out int correctOption) && correctOption >= 1 && correctOption <= 4)
                {
                    EditedQuestion.CorrectOption = correctOption - 1;
                }
                else
                {
                    MessageBox.Show("Please enter a valid correct answer (1-4).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
