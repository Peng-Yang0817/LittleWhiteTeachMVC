using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnTest0316.DAL;

namespace LearnTest0316.BLL
{
    public class MVCAchPOC_DB_BLL
    {
        public static List<Users> getList() {
            using (MVCAchPOC_DB_DAL db = new MVCAchPOC_DB_DAL())
            {
                List<Users> Users = db.Users.ToList();
                return Users;
            }
        }
    }
}