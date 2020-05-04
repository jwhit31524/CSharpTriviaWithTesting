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
        private Quiz quiz;
        private readonly QuizContext db;
     

        public TriviaController(Form mainForm)
        {
            this.mainForm = mainForm;

            db = new QuizContext();
            db.QuizEntities.Add(new QuizEntity
            {
                Id = 1,
                Name = "Test Quiz"
            });
            db.SaveChanges();

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

        internal void CloseTheApplication()
        {
            mainForm.Close();
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