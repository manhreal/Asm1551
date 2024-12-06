using Helper;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace GameQuizWindowsApp
{
    public partial class Question_TF_Add : Form
    {
        public Question_TF_Add()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Question.Text) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please enter a question and select an answer.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string questionText = textBox_Question.Text.Trim();
            string correctAnswer = comboBox1.SelectedItem.ToString();

            try
            {
                var helper = new QuestionHelper();

                string questionId = helper.AddTFQuestion(questionText, 3);

                helper.AddTFAnswer(questionId, 3, correctAnswer, 1);

                MessageBox.Show("Question added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding question: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
