using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentMidterm.Models
{
    public class Student
    {
        //Student table with data annotations. 

        public int Id { get; set; }

        [Required(ErrorMessage ="First name is required.")]
        [StringLength(50, ErrorMessage = "First name is too long.")]
        [Display(Name = "FIRST NAME")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Last name is too long.")]
        [Display(Name = "LAST NAME")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Birthdate is required.")]
        [AgeCheck]
        [Display(Name = "DATE OF BIRTH")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDay { get; set; }

        [Required(ErrorMessage = "Enrollment date is required.")]
        [EnrollmentCheck]
        [Display(Name = "ENROLLMENT DATE")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? EnrolledDate { get; set; }

        [Required(ErrorMessage = "Course selection is required.")]
        [Display(Name="COURSE NAME")]
        public int CourseId { get; set; }

        public Course Course { get; set; }

        [Required(ErrorMessage = "Course status is required.")]
        [Display(Name = "COURSE STATUS")]
        public int CourseStatusId { get; set; }

        public Status CourseStatus { get; set; }

        [Required(ErrorMessage = "Grade is required.")]
        [GradeCheck]
        [Display(Name = "GRADE")]
        public string Grade { get; set; }
    }
}