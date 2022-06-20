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

        public ActionResult ErrorCoddingPag() {
            return View();
        }
        public ActionResult ErrorCoddingPagReD()
        {
            return View();
        }
        
        // 編輯Form表單，在POST的Action接
        public ActionResult FormEdit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FormEditGet(int Stu_Num, string Stu_Name, string Stu_Score)
        {
            ViewBag.Stu_Num = Stu_Num;
            ViewBag.Stu_Name = Stu_Name;
            ViewBag.Stu_Score = Stu_Score;
            return View();
        }
    }
}