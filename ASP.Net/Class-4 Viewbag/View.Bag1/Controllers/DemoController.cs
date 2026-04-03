using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Bag1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            ViewBag.Message = "This message is from view bag";
            ViewBag.CurrentDate = DateTime.Now.ToString();
            string[] fruits = { "Apple", "Mango", "Orange" };
            ViewBag.FruitsArray = fruits;

            return View();
        }
    }
}