using csharptrivia2020.model;

namespace csharptrivia2020
{
    public class QuestionTestDouble : Question
    {

        public string QuestionText { get; private set; }

        public string[] AnswerOptions { get; private set; }

        public bool IsCorrectAnswer => throw new System.NotImplementedException();

        public bool IsAnswered => throw new System.NotImplementedException();

        public QuestionTestDouble(string questionText, string[] answerOptions)
        {
            QuestionText = questionText;
            AnswerOptions = answerOptions;
        }

        public void SelectOptionIndex(int v)
        {
            throw new System.NotImplementedException();
        }
    }
}