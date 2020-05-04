using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace csharptrivia2020.database
{
    [Table("Quizes")]
    public class QuizEntity
    {
        [Key]
        public int Id { get; set; }

        
        public string Name { get; set; }

       public virtual List<QuestionEntity> Questions { get; set; }
    }

    [Table("Questions")]
    public class QuestionEntity
    {
        [Key]
        public int Id { get; set; }

       
        public string QuestionText { get; set; }

        public string CorrectAnswer { get; set; }

        public virtual List<QuestionAnswerEntity> QuestionAnswers { get; set; }
    }

    [Table("QuestionAnswers")]
    public class QuestionAnswerEntity
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }

        public string AnswerText { get; set; }
    }
}
