using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnTest0316.DAL;
using LearnTest0316.BLL;
using System.IO;
using System.Collections;
using LearnTest0316.Utility;
using System.Data.Entity;

namespace LearnTest0316.Controllers
{
    public class FirstController : Controller
    {
        // 導入Utility，這樣才可以對log4net日誌做操作
        Logger _logger = new Logger(typeof(FirstController));
        MVCAchPOC_DB_DAL db = new MVCAchPOC_DB_DAL();
        public ActionResult Index()
        {
            ViewBag.Name_001 = "孫鵬鵬";
            ViewBag.Name_002 = "林霏霏";
            ViewData["Address_001"] = "臺灣_新北";
            ViewData["Address_002"] = "韓國_首爾";

            List<Users> UsersData = MVCAchPOC_DB_BLL.getList();
            ViewBag.UserList = UsersData;

            ArrayList myAl = new ArrayList();
            myAl.Add("Hello");
            myAl.Add("World");
            myAl.Add("~!!!");
            ViewBag.myAl = myAl;
            return View();
        }
        public ActionResult About(int Id)
        {
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
            return File(iStream, "application/js", "DaGG.js");
        }


        public ActionResult ChangeUserId()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangeUserId(string UserName, string Password)
        {
            Users ChangeUser = db.Users.Where(x => x.UserName == UserName).ToList()[0];
            ChangeUser.Password = Password;
            db.Entry(ChangeUser).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "First");
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(string UserName, string Password, int RoleId)
        {
            int lastNum = db.Users.ToList().Count;
            Users LastUser = db.Users.ToList()[lastNum - 1];
            int NewId = LastUser.Id + 1;
            Users NewUsers = new Users();

            NewUsers.UserId = "acc" + NewId.ToString();
            NewUsers.UserName = UserName;
            NewUsers.Password = Password;
            NewUsers.RoleId = RoleId;
            db.Users.Add(NewUsers);
            db.SaveChanges();
            return RedirectToAction("Index", "First");
        }

        public ActionResult DeleteUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteUser(string UserName, string Password)
        {
            Users DeleteTarget = db.Users.FirstOrDefault(x => x.UserName == UserName && x.Password == Password);
            if (DeleteTarget == null)
            {
                return RedirectToAction("Index", "First");
            }
            else
            {
                db.Users.Remove(DeleteTarget);
                db.SaveChanges();
                return RedirectToAction("Index", "First");
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult TownView()
        {
            DateTime Time = DateTime.Now;

            // 指定First控制器底下的Action TownView
            this._logger.Info("FirstController-TownView-Info" + " __ " + Time.ToString());
            this._logger.Warn("FirstController-TownView-Warn" + " __ " + Time.ToString());
            this._logger.Error("FirstController-TownView-Error" + " __ " + Time.ToString());
            this._logger.Debug("FirstController-TownView-Debug" + " __ " + Time.ToString());
            return View();
        }
        public ActionResult GetListData(ICollection<Users> Users)
        {
            List<Users> DataList = (List<Users>)Users;
            ViewBag.Users = Users;
            return View(Users);
        }
    }
}