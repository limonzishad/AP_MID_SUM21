using Lab2.Models;
using Lab2.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Database db = new Database();
            var students = db.Students.GetAll();
            return View(students);
        }
        public ActionResult Add()
        {
            Student a = new Student();
            return View(a);
        }
        [HttpPost]
        public ActionResult Add(Student a)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Insert(a);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            Database db = new Database();
            var a = db.Students.Get(id);
            return View(a);
        }
        [HttpPost]
        public ActionResult Edit(Student a)
        {
            //update to db
            Database db = new Database();
            db.Students.Update(a);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Database db = new Database();
            db.Students.Delete(id);
            return RedirectToAction("Index");
        }
    }
}