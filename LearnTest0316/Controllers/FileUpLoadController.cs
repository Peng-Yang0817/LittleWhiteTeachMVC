using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnTest0316.Controllers
{
    public class FileUpLoadController : Controller
    {
        // GET: FileUpLoad
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            var fileValid = true;
            // Limit File size below : 5MB
            if (file.ContentLength <= 0 || file.ContentLength > 5242880)
            {
                fileValid = false;
            }
            if (file.ContentType != "image/png" && file.ContentType != "image/jpeg")
            {
                fileValid = false;
            }
            if (fileValid == true)
            {
                string extension = Path.GetExtension(file.FileName);
                string fileName = $"{Guid.NewGuid()}{extension}";
                string savePath = Path.Combine(Server.MapPath("~/Content/image"), fileName);
                file.SaveAs(savePath);
                ViewBag.Message = "檔案上傳成功";
                ViewBag.fileName = fileName;
                ViewBag.fileType = file.ContentType;
            }
            else {
                ViewBag.Message = "Upload Failed 😫";
            }
            return View();
        }
        public ActionResult GetFile(string Name,string Type)
        {
            string filepath = Server.MapPath("~/Content/image/"+Name);
            string filename = System.IO.Path.GetFileName(filepath);
            //讀成串流
            Stream iStream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read);
            return File(iStream, Type, Name);
        }
    }
}