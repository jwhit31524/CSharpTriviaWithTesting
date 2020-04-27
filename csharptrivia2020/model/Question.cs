namespace csharptrivia2020.model
{
    public interface Question
    {
        string[] AnswerOptions { get; }
        string QuestionText { get; }
        bool IsCorrectAnswer { get; }
        bool IsAnswered { get; }

        void SelectOptionIndex(int v);
    }
}