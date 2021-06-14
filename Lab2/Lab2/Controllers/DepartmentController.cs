using Lab2.Models;
using Lab2.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            Database db = new Database();
            var departments = db.Departments.GetAll();
            return View(departments);
        }
        public ActionResult Add()
        {
            Department a = new Department();
            return View(a);
        }
        [HttpPost]
        public ActionResult Add(Department p)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Departments.Insert(p);
                return RedirectToAction("Index");
            }
            return View();

        }
        public ActionResult Edit(int id)
        {
            Database db = new Database();
            var a = db.Departments.Get(id);
            return View(a);
        }
        [HttpPost]
        public ActionResult Edit(Department a)
        {
            Database db = new Database();
            db.Departments.Update(a);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Database db = new Database();
            db.Departments.Delete(id);
            return RedirectToAction("Index");
        }
    }
}