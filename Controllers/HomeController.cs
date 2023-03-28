using RepositoryPatternInMVC.Models;
using RepositoryPatternInMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryPatternInMVC.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee<Student> obj;

        public HomeController()
        {
           this.obj = new Employee<Student>();
        }
        // GET: Home
        public ActionResult Index()
        {
            var data = obj.GetAll();
            return View(data);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            Student model = obj.GetById(id);
            return View(model);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Student s)
        {
            obj.Insert(s);
            obj.Save();
            return RedirectToAction("Index");
            
            
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            Student model = obj.GetById(id);
            return View(model);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            obj.Update(s);
            obj.Save();
            return RedirectToAction("Index");
           
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            var model = obj.GetById(id);
            return View(model);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Student s)
        {
            obj.Delete(id);
            obj.Save();

                return RedirectToAction("Index");
            
        }
    }
}
