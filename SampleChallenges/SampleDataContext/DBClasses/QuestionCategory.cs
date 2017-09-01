using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataContext.DBClasses
{
    public class QuestionCategory
    {
        public virtual ICollection<Question> Questions { get; set; }
        public QuestionCategory() 
        {
            Questions = new List<Question>();
        }
        [Key]
        public int QuestionCategoryId { get; set; }
        public string QuestionCategoryName { get; set; }
    }
}
