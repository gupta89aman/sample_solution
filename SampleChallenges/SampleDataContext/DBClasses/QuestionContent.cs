using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataContext.DBClasses
{
    public class QuestionContent
    {
        public QuestionContent() 
        {
            Questions = new List<Question>();
        }
        [Key]
        public int QuestionContentID { get; set; }
        public string QuestionContentName { get; set; }
        public string  QuestionContentType { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
