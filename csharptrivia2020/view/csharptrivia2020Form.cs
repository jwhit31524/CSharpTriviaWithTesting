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
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            triviaController.StartNewGame();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
