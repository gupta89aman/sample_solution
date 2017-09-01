using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataContext.DBClasses
{
    public class Question
    {
        public Question()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionId { get; set; }
        public string QuesionTopicName { get; set; }
        public int QuestionCategoryRefId { get; set; }

        [ForeignKey("QuestionCategoryRefId")]
        public virtual QuestionCategory QuestionCategory { get; set; }

        public int QuestionContentRefId { get; set; }
        [ForeignKey("QuestionContentRefId")]
        public virtual QuestionContent QuestionContent { get; set; }

        public DateTime CreatedOrModified { get; set; }
    }
}
