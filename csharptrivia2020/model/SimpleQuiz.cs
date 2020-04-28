using csharptrivia2020.model;

namespace csharptriviaUnitTest
{
    public class SimpleQuiz : Quiz
    {
        public int CorrectAnswers => throw new System.NotImplementedException();

        public Question CurrentQuestion => throw new System.NotImplementedException();

        public int CurrentQuestionNumber => throw new System.NotImplementedException();

        public int NumberOfQuestions => 0;

        public bool OnFirstQuestion => throw new System.NotImplementedException();

        public bool OnLastQuestion => throw new System.NotImplementedException();

        public void NextQuestion()
        {
            throw new System.NotImplementedException();
        }

        public void PreviousQuestion()
        {
            throw new System.NotImplementedException();
        }
    }
}