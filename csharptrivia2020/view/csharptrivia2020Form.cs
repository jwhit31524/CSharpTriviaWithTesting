using csharptrivia2020.controller;
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
    public partial class CSharpTrivia2020Form : Form
    {
        private readonly TriviaController triviaController;

        public CSharpTrivia2020Form()
        {
            InitializeComponent();
            triviaController = new TriviaController(this);
            listBox1.Items.Add("General Knowledge Quiz");
            listBox1.Items.Add("Math Quiz");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            triviaController.StartNewGame(listBox1.SelectedItem.ToString());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NavigateToQuestionsFormButton_Click(object sender, EventArgs e)
        {
            triviaController.ShowQuestionManager();
        }
    }
}
