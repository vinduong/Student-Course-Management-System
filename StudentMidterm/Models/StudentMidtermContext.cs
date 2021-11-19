using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentMidterm.Models
{
    public class StudentMidtermContext : DbContext
    {
        //Made three tables in database. 

        public StudentMidtermContext() : base("StudentMidtermContext")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}