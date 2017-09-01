using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleChallenges.Models
{
    public class QuestionModel
    {
        [System.Web.Mvc.HiddenInput(DisplayValue=false)]
        public int QuestionId { get; set; }

        [Required]
        [Display(Name = "Question TopicName")]
        public string QuesionTopicName { get; set; }

        [Display(Name = "Question Category")]
        public List<QuestionCategoryModel> QuestionCategory { get; set; }

        [Display(Name = "Question Content")]
        public List<QuestionContentModel> QuestionContent { get; set; }

        [Display(Name = "CreatedOrModifiedDate")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy HH:mm}")]
        public DateTime CreatedOrModified { get; set; }
    }
}