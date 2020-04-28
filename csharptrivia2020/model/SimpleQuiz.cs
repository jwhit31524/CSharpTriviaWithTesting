using csharptrivia2020.model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace csharptriviaUnitTest
{
    public class SimpleQuiz : Quiz
    {
        private readonly List<Question> _questions = new List<Question>();
        public int CorrectAnswers => 0;

        public Question CurrentQuestion => _questions[0];

        public int CurrentQuestionNumber => 1;


        public void AddQuestion(Question question)
        {
            _questions.Add(question);
        }

        public int NumberOfQuestions => _questions.Count;

        public bool OnFirstQuestion => true;

        public bool OnLastQuestion => false;

        public int Score => 0;

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