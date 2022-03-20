using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnTest0316.DAL;
using LearnTest0316.BLL;

namespace LearnTest0316.Controllers
{
    public class FirstController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Name_001 = "孫鵬鵬";
            ViewBag.Name_002 = "林霏霏";
            ViewBag.Data = Newtonsoft.Json.JsonConvert.SerializeObject(MVCAchPOC_DB_BLL.getList());
            ViewData["Address_001"] = "臺灣_新北";
            ViewData["Address_002"] = "韓國_首爾";
            return View();
        }
        public ActionResult About(int Id) {
            ViewBag.User_Id_001 = Id;
            return View();
        }
    }
}