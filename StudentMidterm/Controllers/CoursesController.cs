using StudentMidterm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace StudentMidterm.Controllers
{
    public class CoursesController : Controller
    {
        private StudentMidtermContext _context;

        public CoursesController()
        {
            _context = new StudentMidtermContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //Course index page.
        public ActionResult Index()
        {
            var course = _context.Courses.ToList();
            return View(course);
        }

        //Create
        public ActionResult Create()
        {
            return View(new Course { Id = 0 });
        }

        //Add new course and update course.
        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (!ModelState.IsValid)
                return View("Create", course);

            if (course.Id > 0)
                _context.Entry(course).State = EntityState.Modified;           
            else   
                _context.Courses.Add(course);
                            
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //Update student using create view and populate form with selected course values.
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var course = _context.Courses.SingleOrDefault(c => c.Id == id);

            if (course == null)
                return HttpNotFound();
            
            return View("Create", course);
        }

        //Check to see if course exists and then delete course.
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
       
            var course = _context.Courses.SingleOrDefault(c => c.Id == id);

            if (course == null)
                return HttpNotFound();

            _context.Courses.Remove(course);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}