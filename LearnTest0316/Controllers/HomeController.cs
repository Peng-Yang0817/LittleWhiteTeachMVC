using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnTest0316.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ErrorPage()
        {
            return View();
        }

        public ActionResult OpssPage()
        {
            return View();
        }

        public ActionResult ErrorCodingPag() {
            return View();
        }
        public ActionResult ErrorCodingPagReD()
        {
            return View();
        }
    }
}