using Helper;
using System;
using System.Windows.Forms;

namespace GameQuizWindowsApp
{
    public partial class Question_Mutilchoice_update : Form
    {
        public int QuestionId { get; set; }

        public string QuestionText
        {
            get => textBox_Question.Text;
            set => textBox_Question.Text = value;
        }
        public string Answer1
        {
            get => textBox_Answer1.Text;
            set => textBox_Answer1.Text = value;
        }
        public string Answer2
        {
            get => textBox_Answer2.Text;
            set => textBox_Answer2.Text = value;
        }
        public string Answer3
        {
            get => textBox_Answer3.Text;
            set => textBox_Answer3.Text = value;
        }
        public string Answer4
        {
            get => textBox_Answer4.Text;
            set => textBox_Answer4.Text = value;
        }

        private QuestionHelper _questionHelper;

        public Question_Mutilchoice_update()
        {
            InitializeComponent();
            _questionHelper = new QuestionHelper();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Correct.Text))
            {
                MessageBox.Show("Please fill in the correct answer in the 'Correct' box.");
                return;
            }

            if (int.TryParse(textBox_Correct.Text.Trim(), out int correctAnswerIndex))
            {
                string resultMessage = _questionHelper.UpdateQuestionInDatabase(QuestionId, QuestionText, Answer1, Answer2, Answer3, Answer4, correctAnswerIndex);
                MessageBox.Show(resultMessage);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the correct answer.");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
