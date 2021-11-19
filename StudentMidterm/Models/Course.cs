using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentMidterm.Models
{
    public class Course
    {
        //Course table with data annotations. 

        public int Id { get; set; }

        [Required(ErrorMessage = "Course name is required.")]
        [StringLength(50, ErrorMessage = "Course name is too long.")]
        [Display(Name="COURSE NAME")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Course description is required.")]
        [StringLength(255, ErrorMessage = "Course description is too long.")]
        [Display(Name = "COURSE DESCRIPTION")]
        public string CourseDescription { get; set; }

        [Required(ErrorMessage = "Tutor name is required.")]
        [StringLength(50, ErrorMessage = "Tutor name is too long.")]
        [Display(Name = "TUTOR NAME")]
        public string TutorName { get; set; }

        [Required(ErrorMessage = "Course rating is required.")]
        [Range(1,10, ErrorMessage = "Enter a number between 1 and 10.")]
        [Display(Name = "COURSE RATING")]
        public int CourseRating { get; set; }
    }
}