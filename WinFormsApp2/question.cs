using System;
using System.Collections.Generic;
using System.Linq;

namespace WinFormsApp2
{
    // Lớp cha là lớp abstract để các lớp con kế thừa
    public abstract class Question
    {
        public string QuestionText { get; set; }
        public string[] Options { get; set; }
        public string AnswerText { get; set; }
        public string QuestionType { get; set; }

        // Constructor
        protected Question(string questionText, string answerText)
        {
            QuestionText = questionText;
            AnswerText = answerText;
        }

        // Phương thức trừu tượng để kiểm tra câu trả lời
        public abstract bool CheckAnswer(string answer);

        // Phương thức trừu tượng để lấy câu trả lời đúng
        public abstract string GetCorrectAnswer();
    }

    // Câu hỏi trắc nghiệm
    public class MultipleChoiceQuestion : Question
    {
        public string[] Options { get; set; }
        public int CorrectOption { get; set; }

        // Constructor
        public MultipleChoiceQuestion(string questionText, string answerText, string[] options, int correctOption)
            : base(questionText, answerText)
        {
            Options = options;
            CorrectOption = correctOption;
        }

        public override bool CheckAnswer(string answer)
        {
            return int.TryParse(answer, out int option) && option - 1 == CorrectOption;
        }

        public override string GetCorrectAnswer()
        {
            return Options[CorrectOption];
        }
    }

    // Câu hỏi mở
    public class OpenEndedQuestion : Question
    {
        public List<string> CorrectAnswers { get; set; }

        // Constructor
        public OpenEndedQuestion(string questionText, string answerText, List<string> correctAnswers)
    : base(questionText, answerText)
        {
            CorrectAnswers = correctAnswers;
        }


        public override bool CheckAnswer(string answer)
        {
            return CorrectAnswers.Any(a => a.Equals(answer, StringComparison.OrdinalIgnoreCase));
        }

        public override string GetCorrectAnswer()
        {
            return string.Join(", ", CorrectAnswers);
        }
    }

    // Câu hỏi Đúng/Sai
    public class TrueFalseQuestion : Question
    {
        public bool CorrectAnswer { get; set; }

        // Constructor
        public TrueFalseQuestion(string questionText, string answerText, bool correctAnswer)
            : base(questionText, answerText)
        {
            CorrectAnswer = correctAnswer;
        }

        public override bool CheckAnswer(string answer)
        {
            return (answer.Equals("true", StringComparison.OrdinalIgnoreCase) && CorrectAnswer) ||
                   (answer.Equals("false", StringComparison.OrdinalIgnoreCase) && !CorrectAnswer);
        }

        public override string GetCorrectAnswer()
        {
            return CorrectAnswer ? "True" : "False";
        }
    }
}
