using Helper;
using System;
using System.Windows.Forms;

namespace GameQuizWindowsApp
{
    public partial class Question_Open_Add : Form
    {
        private QuestionHelper _questionHelper;

        public Question_Open_Add()
        {
            InitializeComponent();
            _questionHelper = new QuestionHelper();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Question.Text) || string.IsNullOrEmpty(textBox_Answer.Text))
            {
                MessageBox.Show("Please enter question and answer.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string questionText = textBox_Question.Text.Trim();
            string[] answers = textBox_Answer.Text.Trim().Split(',');

            string resultMessage = _questionHelper.AddOpenQuestionToDatabase(questionText, answers);

            MessageBox.Show(resultMessage, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultMessage.Contains("Success"))
            {
                this.Close();
            }
        }
    }
}
