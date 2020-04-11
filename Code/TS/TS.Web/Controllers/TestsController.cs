using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TS.Web.Helpers;
using TS.Web.Models;

namespace TS.Web.Controllers
{
    public class TestsController : Controller
    {
        // GET: Tests
        public ActionResult Index()
        {
            try
            {
                IEnumerable<TestViewModel> items = APIHelper<TestViewModel>.Get("test");
                return View(items);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        public ActionResult Create()
        {
            try
            {
                ViewBag.Configurations = PageHelper.GetSelectList("testconfiguration", "0", true);
                return View();
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        [HttpPost]
        public ActionResult Create(TestViewModel item)
        {
            try
            {
                var result = APIHelper<TestViewModel>.Post("test", item);
                if (result)
                    return RedirectToAction("Index");
                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        public ActionResult Edit(int id)
        {
            try
            {
                TestViewModel item = APIHelper<TestViewModel>.Get("test", "id=" + id);
                ViewBag.Configurations = PageHelper.GetSelectList("testconfiguration", item.TestConfigurationID.ToString(), false);
                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, TestViewModel item)
        {
            try
            {
                var result = APIHelper<TestViewModel>.Post("test", item);
                if (result)
                    return RedirectToAction("Index");

                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                TestViewModel item = APIHelper<TestViewModel>.Get("test", "id=" + id);
                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var result = APIHelper<TestViewModel>.Delete("test", id);
                if (result)
                    return RedirectToAction("Index");
                return View();
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        public ActionResult TestSubjects(int id)
        {
            try
            {
                TestSubjectListViewModel item = new TestSubjectListViewModel();
                item.TestID = id;
                item.TestSubjects = APIHelper<TestSubjectViewModel>.Get("testsubject/" + id.ToString());
                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        public ActionResult TestSubjectAdd(int TestID)
        {
            TestSubjectViewModel item = new TestSubjectViewModel();
            item.TestID = TestID;
            ViewBag.Subjects = PageHelper.GetSelectList("subject", "0", true);
            return View(item);
        }

        [HttpPost]
        public ActionResult TestSubjectAdd(int TestID, TestSubjectViewModel item)
        {
            try
            {
                var result = APIHelper<TestSubjectViewModel>.Post("testsubject", item);
                if (result)
                    return RedirectToAction("TestSubjects", new { id = TestID });

                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        public ActionResult TestSubjectDelete(int id, int testID)
        {
            try
            {
                var result = APIHelper<TestViewModel>.Delete("testsubject", id);
                if (result)
                    return RedirectToAction("TestSubjects", new { id = testID });

                return View();
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }
    }
}