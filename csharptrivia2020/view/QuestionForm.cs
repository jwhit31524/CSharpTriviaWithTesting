using csharptrivia2020.controller;
using csharptrivia2020.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharptrivia2020.view
{
    public partial class QuestionForm : Form
    {
        private TriviaController triviaController;
        private Quiz quiz;

        public QuestionForm()
        {
            InitializeComponent();
        }

        // MVC Pattern
        //  - Model: Quiz
        //  - View: Question Form
        //  - Controller: Trivia Controller
        public QuestionForm(TriviaController triviaController, Form formOwner)
        {
            InitializeComponent();
            this.triviaController = triviaController;
            Owner = formOwner;
        }

        internal void Show(Quiz quiz)
        {
            this.quiz = quiz;
            this.Show();
        }

        private void QuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            quiz.CurrentQuestion.SelectAnswerOption = GetSelectedOption();
            // Law of Demeter (Ask, don't tell)
            if (quiz.OnLastQuestion)
            {
                triviaController.ShowViewResults();
            } else
            {
                quiz.NextQuestion();
                RefreshForm();
            }
        }

        private int? GetSelectedOption()
        {
            if (AnswerA.Checked) return 0;
            if (AnswerB.Checked) return 1;
            if (AnswerC.Checked) return 2;
            return null;
        }

        private void QuestionForm_Activated(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (!quiz.OnFirstQuestion)
            {
                quiz.PreviousQuestion();
                RefreshForm();
            }
    
      
         
        }

        private void RefreshForm()
        {
            AnswerA.Checked = quiz.CurrentQuestion.SelectAnswerOption == 0;
            AnswerB.Checked = quiz.CurrentQuestion.SelectAnswerOption == 1;
            AnswerC.Checked = quiz.CurrentQuestion.SelectAnswerOption == 2;


            var question = quiz.CurrentQuestion;
            QuestionNumberLabel.Text = $"Question {quiz.CurrentQuestionNumber} of {quiz.NumberOfQuestions}";
            QuestionTextLabel.Text = $"{question.QuestionText}";

            if (quiz.OnLastQuestion)
            {
                NextQuestionButton.Text = "Show Results";
            } else
            {
                NextQuestionButton.Text = "Next Question";
            }

            PreviousButton.Enabled = !quiz.OnFirstQuestion;

            AnswerA.Text = $"{question.AnswerOptions[0]}";
            AnswerB.Text = $"{question.AnswerOptions[1]}";
            AnswerC.Text = $"{question.AnswerOptions[2]}";
        }
    }
}
