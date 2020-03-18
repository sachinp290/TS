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
    public class SubjectController : Controller
    {
        const string baseURL = "http://localhost:49755/api/";
        // GET: Subject
        public ActionResult Index()
        {
            IEnumerable<SubjectViewModel> items = null;

            using (var client = new HttpClient())
            {
                items = APIHelper<SubjectViewModel>.Get(baseURL, "subject");
                if (items == null)
                {
                    items = Enumerable.Empty<SubjectViewModel>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(items);
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
            var result = APIHelper<SubjectViewModel>.Post(baseURL, "subject", item);
            if (result)
                return RedirectToAction("Index");

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(item);
        }

        // GET: Subject/Edit/5
        public ActionResult Edit(int id)
        {
            SubjectViewModel item = null;

            using (var client = new HttpClient())
            {
                item = APIHelper<SubjectViewModel>.Get(baseURL, "subject", "id=" + id);
                if (item == null)
                {
                    item = null;
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(item);

        }

        // POST: Subject/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SubjectViewModel item)
        {
            try
            {
                var result = APIHelper<SubjectViewModel>.Post(baseURL, "subject", item);
                if (result)
                    return RedirectToAction("Index");

                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

                return View(item);
            }
            catch
            {
                return View();
            }
        }

        // GET: Subject/Delete/5
        public ActionResult Delete(int id)
        {
            SubjectViewModel item = null;

            using (var client = new HttpClient())
            {
                item = APIHelper<SubjectViewModel>.Get(baseURL, "subject", "id=" + id);
                if (item == null)
                {
                    item = null;
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(item);
        }

        // POST: Subject/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection item)
        {
            try
            {
                var result = APIHelper<SubjectViewModel>.Delete(baseURL, "subject", id);
                if (result)
                    return RedirectToAction("Index");

                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
