using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnTest0316.BLL;
using LearnTest0316.DAL;

namespace LearnTest0316.Controllers
{
    public class CustomerAndOrderController : Controller
    {
        // GET: CustomerAndOrder
        public ActionResult Index()
        {
            List<customer_order> CustomerData = LearnTest0316.BLL.Customer_order_BLL.getList();
            ViewBag.CustomerData = CustomerData;
            return View();
        }
    }
}