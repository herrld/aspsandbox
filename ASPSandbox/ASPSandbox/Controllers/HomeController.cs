using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPSandbox.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HttpContext.Session.Add("testOBj", new SessionObject() { test = 5 });
            return View();
        }

        public ActionResult About()
        {
            var b = HttpContext.Session["testOBj"] as SessionObject;
            var a = System.Web.HttpContext.Current.GetSessionObject();
            //ViewBag.Message = "Your application description page.";
            //var a = System.Web.HttpContext.Current.Session[""];

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}