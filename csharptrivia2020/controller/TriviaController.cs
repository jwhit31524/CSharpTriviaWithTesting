using csharptrivia2020.model;
using csharptrivia2020.view;
using System;
using System.Windows.Forms;

namespace csharptrivia2020.controller
{
    public class TriviaController
    {
        private readonly Form mainForm;
        private readonly QuestionForm questionForm;
        private readonly ResultsForm resultsForm;
        private Quiz quiz;

        public TriviaController(Form mainForm)
        {
            this.mainForm = mainForm;

            questionForm = new QuestionForm(this, mainForm);
            resultsForm = new ResultsForm(this, mainForm);
        }

        internal void StartNewGame(string QuizTopicName)
        {
            var quizTestProvider = new QuizTestProvider();
            quiz = quizTestProvider.GetTestByName(QuizTopicName);
            mainForm.Hide();
            resultsForm.Hide();
            questionForm.Show(quiz);
        }

        public void ShowViewResults()
        {
            questionForm.Hide();
            resultsForm.Show(quiz);


        }

        internal void ShowViewHome()
        {
            resultsForm.Hide();
            mainForm.Show();
        }
    }
}