using OnlineExamBD.Models;
using OnlineExamBD.Models.Questions;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ServiceQ;
using CoreModel;

namespace OnlineExamBD.Controllers
{
    public class QuestionsController : Controller
    {
        public QuestionMaker _QuestionMaker;
        public QuestionsController()
        {
            _QuestionMaker = new QuestionMaker();
        }
        public ActionResult Index()
        {
            return View(_QuestionMaker.GetAllQuestions());
        }


        public ActionResult Details(int id)
        {
           
            return View(_QuestionMaker.GetQuestionDetails(id));
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( QuestionViewModel question)
        {


            if (ModelState.IsValid)
            {

                if (ModelState.IsValid)
                {

                    _QuestionMaker.SaveOrUpdate(question);
                    return RedirectToAction("Index");
                }

            
            }
            return View(question);
        }
    }
     
            //public ActionResult Edit(int? id)
            //{
            //    if (id == null)
            //    {
            //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //    }
            //    Question question = db.questions.Find(id);
            //    if (question == null)
            //    {
            //        return HttpNotFound();
            //    }
            //    return View(question);
            //}

        
            //[HttpPost]
            //    [ValidateAntiForgeryToken]
            //    public ActionResult Edit([Bind(Include = "Id,Qustions")] Question question)
            //    {
            //        if (ModelState.IsValid)
            //        {
            //            db.Entry(question).State = EntityState.Modified;
            //            db.SaveChanges();
            //            return RedirectToAction("Index");
            //        }
            //        return View(question);
            //    }

            //// GET: Questions/Delete/5
            //public ActionResult Delete(int? id)
            //{
            //    if (id == null)
            //    {
            //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //    }
            //    Question question = db.questions.Find(id);
            //    if (question == null)
            //    {
            //        return HttpNotFound();
            //    }
            //    return View(question);
            //}

            //// POST: Questions/Delete/5
            //[HttpPost, ActionName("Delete")]
            //[ValidateAntiForgeryToken]
            //public ActionResult DeleteConfirmed(int id)
            //{
            //    Question question = db.questions.Find(id);
            //    db.questions.Remove(question);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}


       // }
    }
