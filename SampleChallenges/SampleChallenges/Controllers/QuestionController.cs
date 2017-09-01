using SampleDataContext.Repository;
using System.Web.Mvc;
using System.Collections.Generic;
using SampleChallenges.Models;
using SampleChallenges.Helper;
using SampleDataContext.DBClasses;
using System;
using System.Data;

namespace SampleChallenges.Controllers
{
    public class QuestionController : Controller
    {
        private IUnitOfWork _unitOfWork;
        
        public QuestionController()
        {
            _unitOfWork = new UnitOfWork();
        }
        //public QuestionController(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //}
        // GET: /Question/
        public ActionResult Index()
        {
            //QuestionModel viewmodel = new QuestionModel();
            //var entity = AutoMapper.Mapper.Map<Question>(viewmodel);
            List<Question> questions = _unitOfWork.ModelRepository.Get();
            List<QuestionModel> questionModel = AutoMapper.Mapper.Map<List<QuestionModel>>(questions);
            return View(questionModel);
        }
        [HttpGet]
        public ActionResult Insert()
        {
            //var questions = _unitOfWork.ModelRepository.Get();
            QuestionModel question = new QuestionModel();
            return View(question);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert(QuestionModel questionmodel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var entity = AutoMapper.Mapper.Map<Question>(questionmodel);
                    _unitOfWork.ModelRepository.Insert(entity);
                    Question modelq = _unitOfWork.ModelRepository.GetByID(Convert.ToInt32(1));
                    modelq.QuesionTopicName = "Generics#";
                    _unitOfWork.ModelRepository.Update(modelq);
                    _unitOfWork.Save();
                    return RedirectToAction("Index");
                }
            }
            catch(DataException)
            {
                ModelState.AddModelError("InsertError","Error occured while adding question");
            }
            return View(questionmodel);
        }
	}
}