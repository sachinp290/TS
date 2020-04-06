using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TS.Web.Helpers;
using TS.Web.Models;

namespace TS.Web.Controllers
{
    public class TopicsController : Controller
    {
        // GET: Subject
        public ActionResult Index()
        {
            try
            {
                IEnumerable<TopicViewModel> items = APIHelper<TopicViewModel>.Get( "topic");
                return View(items);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }
        // GET: Topic/Create
        public ActionResult Create()
        {
            try
            {
                ViewBag.Subjects = PageHelper.GetSelectList("subject", "0", true);
                return View();
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        // POST: Topic/Create
        [HttpPost]
        public ActionResult Create(TopicViewModel item)
        {
            try
            {
                if (item.SubjectID != 0)
                {
                    var result = APIHelper<TopicViewModel>.Post("topic", item);
                    if (result)
                        return RedirectToAction("Index");
                    return View(item);
                }
                return RedirectToAction("Create");
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        // GET: Topic/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                TopicViewModel item = APIHelper<TopicViewModel>.Get( "topic", "id=" + id);
                ViewBag.Subjects = PageHelper.GetSelectList("subject", item.SubjectID.ToString(), false);
                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }
        // POST: Topic/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TopicViewModel item)
        {
            try
            {
                var result = APIHelper<TopicViewModel>.Post( "topic", item);
                if (result)
                    return RedirectToAction("Index");

                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        // GET: Topic/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                TopicViewModel item = APIHelper<TopicViewModel>.Get( "topic", "id=" + id);
                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }
        // POST: Topic/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var result = APIHelper<TopicViewModel>.Delete( "topic", id);
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