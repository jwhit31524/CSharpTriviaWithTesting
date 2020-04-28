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
        public void InitializeState()
        {
            Quiz quiz = SimpleQuizTestFixture.BuildSimpleQuiz();
            Assert.AreEqual(2, quiz.NumberOfQuestions);
            Assert.AreEqual(0, quiz.Score);
            Assert.AreEqual(0, quiz.CorrectAnswers);
            Assert.AreEqual(1, quiz.CurrentQuestionNumber);
            Assert.IsTrue(quiz.OnFirstQuestion);
            Assert.IsFalse(quiz.OnLastQuestion);

        }

        [TestMethod]
        public void AnswerFirstQuestionCorrectly()
        {
            Quiz quiz = SimpleQuizTestFixture.BuildSimpleQuiz();
            Question question = quiz.CurrentQuestion;
            Assert.AreEqual("What is 2+2?", quiz.CurrentQuestion.QuestionText);
            Assert.AreEqual("2", question.AnswerOptions[0]);
            Assert.AreEqual("4", question.AnswerOptions[1]);
            Assert.AreEqual("5", question.AnswerOptions[2]);
            question.SelectAnswerOption(1);

            Assert.AreEqual(1, quiz.CorrectAnswers);
        }

        [TestMethod]
        public void MovingToNextQuestion()
        {
            Quiz quiz = SimpleQuizTestFixture.BuildSimpleQuiz();
            quiz.NextQuestion();

            Question question = quiz.CurrentQuestion;
            Assert.AreEqual("What is 3+3?", question.QuestionText);
            Assert.AreEqual("6", question.AnswerOptions[0]);
            Assert.AreEqual("8", question.AnswerOptions[1]);
            Assert.AreEqual("9", question.AnswerOptions[2]);
            Assert.AreEqual(2, quiz.CurrentQuestionNumber);
            Assert.IsFalse(quiz.OnFirstQuestion);
            Assert.IsTrue(quiz.OnLastQuestion);

        }


    }
}
