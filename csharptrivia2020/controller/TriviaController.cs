using csharptrivia2020.database;
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
        private readonly ManageQuestionsForm manageQuestionsForm;
        private Quiz quiz;
        private readonly QuizContext db;
     

        public TriviaController(Form mainForm)
        {
            this.mainForm = mainForm;

            db = new QuizContext();
        

            questionForm = new QuestionForm(this, mainForm);
            resultsForm = new ResultsForm(this, mainForm);
            manageQuestionsForm = new ManageQuestionsForm(this, mainForm);
        }

        internal void StartNewGame(string QuizTopicName)
        {
            var quizTestProvider = new QuizTestProvider();
            quiz = quizTestProvider.GetTestByName(QuizTopicName);
            HideAllForms();
            questionForm.Show(quiz);
        }

        internal void CloseTheApplication()
        {
            mainForm.Close();
        }

        public void ShowViewResults()
        {
            HideAllForms();
            resultsForm.Show(quiz);
        }

        internal void ShowQuestionManager()
        {
            HideAllForms();
            manageQuestionsForm.Show();
        }

        private void HideAllForms()
        {
            mainForm.Hide();
            resultsForm.Hide();
            questionForm.Hide();
            manageQuestionsForm.Hide();
        }

        internal void ShowViewHome()
        {
            HideAllForms();
            mainForm.Show();
        }
    }
}