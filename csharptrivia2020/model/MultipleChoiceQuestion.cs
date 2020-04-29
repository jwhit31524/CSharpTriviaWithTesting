namespace csharptrivia2020.model
{
    public class MultipleChoiceQuestion : Question
    {
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
            get { return SelectAnswerOption == _correctAnswerIndex; } 
        }

        public bool IsAnswered { 
            get { return SelectAnswerOption != null;  } 
        }

        public int? SelectAnswerOption { get; set; }
    }
}