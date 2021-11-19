using StudentMidterm.Models;
using StudentMidterm.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace StudentMidterm.Controllers
{
    public class StudentsController : Controller
    {
        private StudentMidtermContext _context;

        public StudentsController()
        {
            _context = new StudentMidtermContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //Index display with eager loading from two tables.
        public ActionResult Index()
        {
            var students = _context.Students.
                Include(c => c.Course).Include(c => c.CourseStatus).ToList();
            return View(students);
        }

        //Create student form using viewmodel.
        public ActionResult Create()
        {
            var courses = _context.Courses.ToList();
            var status = _context.Status.ToList();

            var model = new StudentViewModel
            {
                Students = new Student(),
                Courses = courses,
                Status = status
            };
            
            return View(model);
        }

        //Add new student and update student.
        [HttpPost]
        public ActionResult Create(Student students)
        {
            if (!ModelState.IsValid)
            {
                var model = new StudentViewModel
                {        
                    Students = new Student(),
                    Courses = _context.Courses.ToList(),
                    Status = _context.Status.ToList()
            };
                return View("Create", model);
            }

            //Check to see if student exists. If student exists then update otherwise add student.
            if (students.Id > 0)
                _context.Entry(students).State = EntityState.Modified;
            else
                _context.Students.Add(students);
            
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //Update student using viewmodel and populate the form with selected student values.
        public ActionResult Edit(int? id)
        {
            var student = _context.Students.SingleOrDefault(c => c.Id == id);

            if (student == null)
                return HttpNotFound();

            var model = new StudentViewModel
            {
                Students =student,
                Courses = _context.Courses.ToList(),
                Status = _context.Status.ToList()
            };
            return View("Create", model);
        }

        //Check to see if student exists and then delete student.
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var student = _context.Students.SingleOrDefault(c => c.Id == id);

            if (student == null)
                return HttpNotFound();

            _context.Students.Remove(student);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }

}