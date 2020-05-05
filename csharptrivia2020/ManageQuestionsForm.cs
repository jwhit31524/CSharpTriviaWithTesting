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

namespace csharptrivia2020
{
    public partial class ManageQuestionsForm : Form
    {
        private TriviaController triviaController;
        private Form mainForm;

        public ManageQuestionsForm()
        {
            InitializeComponent();
        }

        public ManageQuestionsForm(TriviaController triviaController, Form mainForm)
        {
            this.triviaController = triviaController;
            this.mainForm = mainForm;
        }
    }
}
