using csharptrivia2020.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptriviaUnitTest.model
{
    public class SimpleQuizTestFixture
    {

        public static Quiz BuildSimpleMathQuiz()
        {
            SimpleQuiz quiz = new SimpleQuiz();
            quiz.AddQuestion(BuildTwoPlusTwoMultipleChoiceQuestion());
            quiz.AddQuestion(BuildThreePlusThreeMultipleChoiceQuestion());
            return quiz;
        }

        public static Question BuildTwoPlusTwoMultipleChoiceQuestion()
        {
            return new MultipleChoiceQuestion("What is 2+2?", new string[] { "2", "4", "5" }, 1);
        }
        public static Question BuildThreePlusThreeMultipleChoiceQuestion()
        {
            return new MultipleChoiceQuestion("What is 3 + 3?", new string[] { "6", "8", "9" }, 0);
        }
    }
}
