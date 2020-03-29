using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TS.Web.Helpers;
using TS.Web.Models;

namespace TS.Web.Controllers
{
    public class SubjectsController : Controller
    {
        // GET: Subject
        public ActionResult Index()
        {
            try
            {
                IEnumerable<SubjectViewModel> items = APIHelper<SubjectViewModel>.Get("subject");
                return View(items);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        // GET: Subject/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subject/Create
        [HttpPost]
        public ActionResult Create(SubjectViewModel item)
        {
            try
            {
                var result = APIHelper<SubjectViewModel>.Post("subject", item);
                if (result)
                    return RedirectToAction("Index");

                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        // GET: Subject/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                SubjectViewModel item = APIHelper<SubjectViewModel>.Get( "subject", "id=" + id);
                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        // POST: Subject/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SubjectViewModel item)
        {
            try
            {
                var result = APIHelper<SubjectViewModel>.Post( "subject", item);
                if (result)
                    return RedirectToAction("Index");

                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        // GET: Subject/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                SubjectViewModel item = APIHelper<SubjectViewModel>.Get( "subject", "id=" + id);
                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        // POST: Subject/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection item)
        {
            try
            {
                var result = APIHelper<SubjectViewModel>.Delete( "subject", id);
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
