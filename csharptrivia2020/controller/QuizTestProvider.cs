using csharptrivia2020.model;
using System;

namespace csharptrivia2020.controller
{
    internal class QuizTestProvider 
    {
        internal Quiz GetTestByName(string quizTopicName)
        {
            if (quizTopicName == "Math Quiz")
                return BuildMathQuiz();

            return BuildGenericQuiz();
        }

        private Quiz BuildMathQuiz()
        {
            var quiz = new SimpleQuiz();

            quiz.AddQuestion(new MultipleChoiceQuestion(
                "What is 2 x 14?",
                new[] { "28", "48", "56" },
                1
                ));
            quiz.AddQuestion(new MultipleChoiceQuestion(
            "What is 11 x 6?",
           new[] { "122", "66", "70" },
           2
           ));
            quiz.AddQuestion(new MultipleChoiceQuestion(
          "What is 10 x 5?",
         new[] { "122", "50", "70" },
         2
         ));
            quiz.AddQuestion(new MultipleChoiceQuestion(
          "What is 11 x 9?",
         new[] { "122", "234", "99" },
         2
         ));
            quiz.AddQuestion(new MultipleChoiceQuestion(
          "What is 100 x 7?",
         new[] { "700", "234", "70" },
         2
         ));
            return quiz;
        }

        private Quiz BuildGenericQuiz()
        {
            var quiz = new SimpleQuiz();

            quiz.AddQuestion(new MultipleChoiceQuestion(
                "What is 2 x 24?",
                new[] { "24", "48", "56" },
                1
                ));
            quiz.AddQuestion(new MultipleChoiceQuestion(
               "What is the capital of Michigan?",
               new[] { "Detroit", "Lansing", "Farmington Hills" },
               1
               ));
            quiz.AddQuestion(new MultipleChoiceQuestion(
                 "What is 14 x 5?",
                new[] { "122", "234", "70" },
                2
                ));
            quiz.AddQuestion(new MultipleChoiceQuestion(
                "What is a branch of U.S. government?",
                new[] { "Executive", "Crayon", "Vehicle" },
                0
                ));
            quiz.AddQuestion(new MultipleChoiceQuestion(
                "What is a type of bear",
                new[] { "Leopard", "Giraffe", "Polar" },
                2

                ));
            return quiz;
        }

    }
}