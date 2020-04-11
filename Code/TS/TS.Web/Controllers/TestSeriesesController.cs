using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TS.Web.Helpers;
using TS.Web.Models;

namespace TS.Web.Controllers
{
    public class TestSeriesesController : Controller
    {
        // GET: TestSeriess
        public ActionResult Index()
        {
            try
            {
                IEnumerable<TestSeriesViewModel> items = APIHelper<TestSeriesViewModel>.Get("TestSeries");
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
                ViewBag.Configurations = PageHelper.GetSelectList("TestConfiguration", "0", true);
                return View();
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        [HttpPost]
        public ActionResult Create(TestSeriesViewModel item)
        {
            try
            {
                var result = APIHelper<TestSeriesViewModel>.Post("TestSeries", item);
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
                TestSeriesViewModel item = APIHelper<TestSeriesViewModel>.Get("TestSeries", "id=" + id);
                ViewBag.Configurations = PageHelper.GetSelectList("Testconfiguration", item.TestConfigurationID.ToString(), false);
                return View(item);
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, TestSeriesViewModel item)
        {
            try
            {
                var result = APIHelper<TestSeriesViewModel>.Post("TestSeries", item);
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
                TestSeriesViewModel item = APIHelper<TestSeriesViewModel>.Get("TestSeries", "id=" + id);
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
                var result = APIHelper<TestSeriesViewModel>.Delete("TestSeries", id);
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