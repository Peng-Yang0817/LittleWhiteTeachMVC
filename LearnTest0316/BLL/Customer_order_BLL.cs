using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnTest0316.DAL;

namespace LearnTest0316.BLL
{
    public class Customer_order_BLL
    {
        public static List<customer_order> getList() {
            using (ViewImageLearnEntities db = new ViewImageLearnEntities())
                return db.customer_order.ToList();
            }
    }
}