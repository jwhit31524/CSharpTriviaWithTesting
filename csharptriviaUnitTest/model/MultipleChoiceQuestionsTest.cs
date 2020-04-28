using System;
using csharptrivia2020.model;
using csharptriviaUnitTest.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharptriviaUnitTest
{
    [TestClass]
    public class MultipleChoiceQuestionsTest
    {
        private const string questionText = "What is 2+2?";
        private readonly string[] answerOptions = new string[] { "2", "4", "5" };

 

        [TestMethod]
        public void CreateMultipleChoiceQuestion()
        {
            Question question = GetTwoPlusTwoQuestion();

            Assert.AreEqual(questionText, question.QuestionText);
            Assert.AreEqual("2", question.AnswerOptions[0]);
            Assert.AreEqual("4", question.AnswerOptions[1]);
            Assert.AreEqual("5", question.AnswerOptions[2]);
        }

        [TestMethod]
        public void UnansweredQuestionIsNotCorrect()
        {
            Question question = GetTwoPlusTwoQuestion();

            Assert.IsFalse(question.IsAnswered);
            Assert.IsFalse(question.IsCorrectAnswer);
        }

        [TestMethod]
        public void AnsweredQuestionIsNotCorrect()
        {
            Question question = GetTwoPlusTwoQuestion();
            question.SelectOptionIndex(2);

            Assert.IsTrue(question.IsAnswered);
            Assert.IsFalse(question.IsCorrectAnswer);
        }


        [TestMethod]
        public void AnsweredQuestionIsCorrect()
        {
            Question question = GetTwoPlusTwoQuestion();
            question.SelectOptionIndex(1);

            Assert.IsTrue(question.IsAnswered);
            Assert.IsTrue(question.IsCorrectAnswer);
        }

        private MultipleChoiceQuestion GetTwoPlusTwoQuestion()
        {
            return new MultipleChoiceQuestion(questionText, answerOptions, 1);
        }

        [TestMethod]
        public void CreateNewMultipleChoiceQuestion()
        {
            Question question = new MultipleChoiceQuestion("What is 3 + 3?", new string[]{ "6", "8", "9" }, 0);
            question.SelectOptionIndex(0);
            Assert.IsTrue(question.IsCorrectAnswer);
        }

    }
}

