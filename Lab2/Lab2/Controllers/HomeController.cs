using Lab2.Models;
using Lab2.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin a)
        {
            Database db = new Database();
            var b = db.Admins.Get(a.Username, a.Password);
            if (b == a.Password)
            {
                return RedirectToAction("Home1");
            }
            return RedirectToAction("Index");
        }
        public ActionResult Home1()
        {
            return View();
        }
    }
}