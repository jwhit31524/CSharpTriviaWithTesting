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
        [TestMethod]
        public void Test()
        {
            Quiz quiz = SimpleQuizTestFixture.BuildSimpleMathQuiz();
            Assert.AreEqual(2, quiz.NumberOfQuestions);
            Assert.AreEqual(0, quiz.Score);
            Assert.AreEqual(0, quiz.CorrectAnswers);
            Assert.AreEqual(1, quiz.CurrentQuestionNumber);
            Assert.AreEqual("What is 2+2?", quiz.CurrentQuestion.QuestionText);
            Assert.IsTrue(quiz.OnFirstQuestion);
            Assert.IsFalse(quiz.OnLastQuestion);


        }


    }
}
