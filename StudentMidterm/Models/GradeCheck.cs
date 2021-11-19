using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentMidterm.Models
{
    public class GradeCheck : ValidationAttribute
    {
        //Give grades a range from A to F. 

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var student = (Student)validationContext.ObjectInstance;

            if (student.Grade == null)
                return new ValidationResult("Grade is required.");

            bool rightgrade;

            if (student.Grade.ToUpper() == 'A'.ToString() || student.Grade.ToUpper() == 'B'.ToString() || student.Grade.ToUpper() == 'C'.ToString() || student.Grade.ToUpper() == 'D'.ToString() || student.Grade.ToUpper() == 'E'.ToString() || student.Grade.ToUpper() == 'F'.ToString())
            { rightgrade = true; }
            else { rightgrade = false;  }

            return (rightgrade) ? ValidationResult.Success
                : new ValidationResult("Grades range from A to F.");
        }
    }
}