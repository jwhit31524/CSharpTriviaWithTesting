using csharptrivia2020.model;

namespace csharptriviaUnitTest.model
{
    public class MultipleChoiceQuestion : Question
    {
        private int? _selectedAnswer = null;
        private int _correctAnswerIndex;

        public MultipleChoiceQuestion(string questionText, string[] answerOptions)
        {
            QuestionText = questionText;
            AnswerOptions = answerOptions;

        }

        public MultipleChoiceQuestion(string questionText, string[] answerOptions, int correctAnswerIndex) : this(questionText, answerOptions)
        {
            this._correctAnswerIndex = correctAnswerIndex;
        }

        public string[] AnswerOptions { get; }

        public string QuestionText { get; }

        public bool IsCorrectAnswer { 
            get { return _selectedAnswer == _correctAnswerIndex; } 
        }

        public bool IsAnswered { 
            get { return _selectedAnswer != null;  } 
        }

        public void SelectAnswerOption(int AnswerIndex)
        {
            _selectedAnswer = AnswerIndex;
        }
    }
}