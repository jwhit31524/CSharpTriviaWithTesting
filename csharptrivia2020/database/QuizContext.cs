using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace csharptrivia2020.database
{
    public class QuizContext : DbContext
    {
        public DbSet<QuizEntity> QuizEntities { get; set; }
        public DbSet<QuestionEntity> QuestionEntities { get; set; }
        public DbSet<QuestionAnswerEntity> QuestionAnswerEntities { get; set; }

        public QuizContext() : base("name=QuizDatabase") { }
    }
}
