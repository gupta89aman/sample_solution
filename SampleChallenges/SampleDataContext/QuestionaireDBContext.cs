using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SampleDataContext.DBClasses;

namespace SampleDataContext
{
    public class QuestionaireDBContext:DbContext
    {
        public QuestionaireDBContext() : base("name=QuestionaireDBContext") {
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionContent> QuestionContents { get; set; }
        public DbSet<QuestionCategory> QuestionCategories { get; set; }
    }
}
