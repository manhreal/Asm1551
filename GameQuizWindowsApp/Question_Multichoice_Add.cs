using System;
using System.Windows.Forms;
using Helper;

namespace GameQuizWindowsApp
{
    public partial class Question_Multichoice_Add : Form
    {
        private QuestionHelper _questionHelper;

        public Question_Multichoice_Add()
        {
            InitializeComponent();
            _questionHelper = new QuestionHelper();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string questionText = textBox_Question.Text;
            string[] answers = { textBox_Answer1.Text, textBox_Answer2.Text, textBox_Answer3.Text, textBox_Answer4.Text };
            int correctAnswerIndex;

            if (!int.TryParse(textBox_Correct.Text, out correctAnswerIndex) || correctAnswerIndex < 1 || correctAnswerIndex > answers.Length)
            {
                MessageBox.Show("The correct answer must be a number from 1 to 4.");
                return;
            }
            string resultMessage = _questionHelper.AddMultichoiceQuestion(questionText, answers, correctAnswerIndex);

            MessageBox.Show(resultMessage);
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
