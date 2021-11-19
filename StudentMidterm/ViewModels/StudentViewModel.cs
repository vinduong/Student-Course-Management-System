using StudentMidterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMidterm.ViewModels
{
    public class StudentViewModel
    {
        public Student Students { get; set; }

        public IEnumerable<Course> Courses { get; set; }

        public IEnumerable<Status> Status { get; set; }
    }
}