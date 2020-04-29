using csharptrivia2020.model;
using System;
using System.Collections.Generic;

namespace csharptrivia2020
{
    public class QuizTestDouble : SimpleQuiz
    {

        public QuizTestDouble()
        {
            AddQuestion(new MultipleChoiceQuestion(
                "What is 2 x 24?",
                new[] { "24", "48", "56" },
                1
                ));
            AddQuestion(new MultipleChoiceQuestion(
               "What is the capital of Michigan?",
               new[] { "Detroit", "Lansing", "Farmington Hills" },
               1
               ));
            AddQuestion(new MultipleChoiceQuestion(
                 "What is 14 x 5?",
                new[] { "122", "234", "70" },
                2
                ));
            AddQuestion(new MultipleChoiceQuestion(
                "What is a branch of U.S. government?",
                new[] { "Executive", "Crayon", "Vehicle" },
                0
                ));
            AddQuestion(new MultipleChoiceQuestion(
                "What is a type of bear",
                new[] { "Leopard", "Giraffe", "Polar" },
                2

                ));
        }

     
    }
}