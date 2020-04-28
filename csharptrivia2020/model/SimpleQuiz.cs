using csharptrivia2020.model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace csharptriviaUnitTest
{
    public class SimpleQuiz : Quiz
    {
        private readonly List<Question> _questions = new List<Question>();
        public int CorrectAnswers => throw new System.NotImplementedException();

        public Question CurrentQuestion => throw new System.NotImplementedException();

        public int CurrentQuestionNumber => throw new System.NotImplementedException();


        public void AddQuestion(Question question)
        {
            _questions.Add(question);
        }

        public int NumberOfQuestions => _questions.Count;

        public bool OnFirstQuestion => throw new System.NotImplementedException();

        public bool OnLastQuestion => throw new System.NotImplementedException();

        public void NextQuestion()
        {
            throw new System.NotImplementedException();
        }

        public void PreviousQuestion()
        {
            throw new System.NotImplementedException();
        }
    }
}