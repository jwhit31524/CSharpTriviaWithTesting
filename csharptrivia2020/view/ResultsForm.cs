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
    public partial class ResultsForm : Form
    {
        private readonly TriviaController triviaController;
      
        private Quiz quiz;

        public ResultsForm()
        {
            InitializeComponent();
        }

        public ResultsForm(TriviaController triviaController, Form formOwner)
        {
            InitializeComponent();
            this.triviaController = triviaController;
            Owner = formOwner;

        }

        private void CloseGameButton_Click(object sender, EventArgs e)
        {
            triviaController.ShowViewHome();
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            triviaController.ShowViewHome();
        }

        private void Question1Label_Click(object sender, EventArgs e)
        {

        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {

        }

        private void ResultsForm_Activated(object sender, EventArgs e)
        {
            RefreshResultsForm();
        }
        internal void Show(Quiz quiz)
        {
            this.quiz = quiz;
            this.Show();
        }

        private void RefreshResultsForm()
        {
            //MaintextBox.AppendText(grade.ToString());
            // MaintextBox.AppendText("\r\n");
            ResultsTextBox.Clear();
            ResultsTextBox.AppendText($"TotalScore: {quiz.CorrectAnswers} / {quiz.NumberOfQuestions}");
        }
    }
}
