using System;
using csharptrivia2020.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharptriviaUnitTest.model
{
    [TestClass]
    public class SimpleQuizTest
    {
        [TestMethod]
        public void NewSimpleQuizHasZeroQuestions()
        {
            Quiz quiz = new SimpleQuiz();
            Assert.AreEqual(0, quiz.NumberOfQuestions);
        }

    }
}
