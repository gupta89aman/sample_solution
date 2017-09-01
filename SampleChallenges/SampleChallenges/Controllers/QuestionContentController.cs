using SampleChallenges.Models;
using SampleDataContext.DBClasses;
using SampleDataContext.Repository;
using System.Data;
using System.Web.Mvc;

namespace SampleChallenges.Controllers
{
    public class QuestionContentController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public QuestionContentController()
        {
            _unitOfWork = new UnitOfWork();
        }
        //
        // GET: /QuestionContent/
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Insert()
        {
            QuestionContent questionContent = new QuestionContent();
            return View(questionContent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert(QuestionContentModel questionContentModel)
        {
            QuestionContent entity = null;
            try
            {
                if (ModelState.IsValid)
                {
                    entity = AutoMapper.Mapper.Map<QuestionContent>(questionContentModel);
                    _unitOfWork.QuestionContentRepository.Insert(entity);
                    _unitOfWork.Save();
                    //return View(entity);
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("InsertQuestionContentError", "Error occured while adding question content");
            }
            return RedirectToAction("Index");
        }
	}
}