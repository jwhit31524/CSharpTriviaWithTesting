namespace csharptrivia2020.model
{
    public interface Quiz
    {
        int CorrectAnswers { get; }
        Question CurrentQuestion { get; }
        int CurrentQuestionNumber { get; }
        int NumberOfQuestions { get; }
        bool OnFirstQuestion { get; }
        bool OnLastQuestion { get; }

        void NextQuestion();
        void PreviousQuestion();


    }
}