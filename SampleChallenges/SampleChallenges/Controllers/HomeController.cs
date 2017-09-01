using SampleChallenges.Helper;
using SampleChallenges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleChallenges.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            QuestionModel viewmodel = new QuestionModel();
            int[] intarr = new int[] { 1, 2, 3, 4, 6, 8, 2, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 6 };
            //char[] chararr = viewmodel.EnterInput.ToArray();
            ViewBag.Question = "Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number";
            ViewData.Add("Result", Convert.ToString(GlobalHelper.CalculateMostRepeatedCharInArray(intarr)));
            return View(viewmodel);
        }
        [HttpPost]
        public ActionResult Post(QuestionModel viewmodel)
        {
            //another way to update model
            //QuestionModel viewmodel = new QuestionModel();
            //UpdateModel(viewmodel);
            string input = viewmodel.QuesionTopicName;
            int[] intarr = new int[] { 1, 2, 3, 4, 6, 8, 2, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 6 };
            ViewBag.Question = "Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number";
            ViewData.Add("Result", Convert.ToString(GlobalHelper.CalculateMostRepeatedCharInArray(intarr)));
            return View(viewmodel);
        }

        [HttpGet]
        //Need to write a HTTPGET verb for the method
        //public ActionResult Get()
        public ActionResult Post()
        {
            QuestionModel viewmodel = new QuestionModel();
            //can be written as below also
            //return View("Post",viewmodel);
            return View(viewmodel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}