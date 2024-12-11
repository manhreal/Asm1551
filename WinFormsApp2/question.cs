using System;
using System.Collections.Generic;
using System.Linq;

namespace WinFormsApp2
{
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

        public abstract bool CheckAnswer(string answer);
        public abstract string GetCorrectAnswer();
    }

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
