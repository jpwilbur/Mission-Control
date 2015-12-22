using MVCProject1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject1.Controllers
{
    public class HomeController : Controller
    {
        private MissionControlContext db = new MissionControlContext();

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Mission()
        {
            return View();
        }

        public ActionResult About()
        {
           return View();
        }

        public ActionResult Contact()
        {
           return View();
        }

        public String getUserName (string email)
        {
            string fname = db.Database.SqlQuery<string>("SELECT userfirstname FROM [User] WHERE userEmail = '" + email + "';").Single();
            string lname = db.Database.SqlQuery<string>("SELECT userlastname FROM [User] WHERE userEmail = '" + email + "';").Single();
            string name = fname + " " + lname;
            return name;
        }
    }
}