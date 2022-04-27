using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnTest0316.DAL;
using LearnTest0316.BLL;
using System.IO;

namespace LearnTest0316.Controllers
{
    public class FirstController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Name_001 = "孫鵬鵬";
            ViewBag.Name_002 = "林霏霏";
            List<Users> UsersData = MVCAchPOC_DB_BLL.getList();
            ViewData["Address_001"] = "臺灣_新北";
            ViewData["Address_002"] = "韓國_首爾";
            ViewBag.UserList = UsersData;
            return View();
        }
        public ActionResult About(int Id) {
            ViewBag.User_Id_001 = Id;
            return View();
        }
        public ActionResult GetUserData()
        {
            //第一個物件
            List<Users> UserData = MVCAchPOC_DB_BLL.getList();
            return Json(UserData, "text/json", JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetJQFile()
        {
            string filepath = Server.MapPath("~/Scripts/jquery-3.4.1.js");
            string filename = System.IO.Path.GetFileName(filepath);
            //讀成串流
            Stream iStream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read);
            return File(iStream, "application/js", filename);
        }

    }
}