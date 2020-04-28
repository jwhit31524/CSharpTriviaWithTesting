using csharptrivia2020.model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace csharptriviaUnitTest
{
    public class SimpleQuiz : Quiz
    {
        private readonly List<Question> _questions = new List<Question>();
        private int _currentIndex = 0;

        public int CorrectAnswers {
            get {
                int total = 0;
                foreach (var question in _questions)
                {
                    if (question.IsCorrectAnswer)
                        total++;
                }

                return total;
            }
        }

        public Question CurrentQuestion => _questions[_currentIndex];

        public int CurrentQuestionNumber => _currentIndex + 1;


        public void AddQuestion(Question question)
        {
            _questions.Add(question);
        }

        public int NumberOfQuestions => _questions.Count;

        public bool OnFirstQuestion => _currentIndex == 0;

        public bool OnLastQuestion => CurrentQuestionNumber >= _questions.Count;

        public int Score => 0;

        public void NextQuestion()
        {
            _currentIndex++;
        }

        public void PreviousQuestion()
        {
            throw new System.NotImplementedException();
        }
    }
}