using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TS.Web.Helpers;
using TS.Web.Models;

namespace TS.Web.Controllers
{
    public class QuestionsController : Controller
    {
        // GET: Subject
        public ActionResult Index()
        {
            try
            {
                IEnumerable<QuestionViewModel> items = APIHelper<QuestionViewModel>.Get("Question");
                return View(items);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }
        // GET: Question/Create
        public ActionResult Create()
        {
            try
            {
                ViewBag.Topics = PageHelper.GetSelectList("topic", "0", true);
                ViewBag.Complexities = PageHelper.GetSelectList("complexity", "0", true);
                ViewBag.Options = new SelectList((new List<IDNamePair>() { new IDNamePair(0, "Select"),  new IDNamePair(0, "Option1"), 
                    new IDNamePair(0, "Option2"), new IDNamePair(0, "Option3"), new IDNamePair(0, "Option4"), }),
                                    "Name",
                                    "Name",
                                    null);
                return View();
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        // POST: Question/Create
        [HttpPost]
        public ActionResult Create(QuestionViewModel item)
        {
            try
            {
                var result = APIHelper<QuestionViewModel>.Post("Question", item);
                if (result)
                    return RedirectToAction("Index");
                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        // GET: Question/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                QuestionViewModel item = APIHelper<QuestionViewModel>.Get("Question", "id=" + id);
                ViewBag.Topics = PageHelper.GetSelectList("topic", item.TopicID.ToString(), false);
                ViewBag.Complexities = PageHelper.GetSelectList("complexity", item.ComplexityID.ToString(), false);
                ViewBag.Options = new SelectList((new List<IDNamePair>() { new IDNamePair(0, "Option1"), 
                    new IDNamePair(0, "Option2"), new IDNamePair(0, "Option3"), new IDNamePair(0, "Option4"), }),
                                    "Name",
                                    "Name",
                                    null);
                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }
        // POST: Question/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, QuestionViewModel item)
        {
            try
            {
                var result = APIHelper<QuestionViewModel>.Post("Question", item);
                if (result)
                    return RedirectToAction("Index");

                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        // GET: Question/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                QuestionViewModel item = APIHelper<QuestionViewModel>.Get("Question", "id=" + id);
                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }
        // POST: Question/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var result = APIHelper<QuestionViewModel>.Delete("Question", id);
                if (result)
                    return RedirectToAction("Index");
                return View();
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }
    }
}