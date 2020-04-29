namespace csharptrivia2020.model
{
    public class MultipleChoiceQuestion : Question
    {
        private int? _selectedAnswer = null;
        private int _correctAnswerIndex;

        public MultipleChoiceQuestion(string questionText, string[] answerOptions, int correctAnswerIndex)
        {
            QuestionText = questionText;
            AnswerOptions = answerOptions;
            _correctAnswerIndex = correctAnswerIndex;
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