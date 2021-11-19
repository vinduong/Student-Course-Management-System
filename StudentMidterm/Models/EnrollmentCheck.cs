using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentMidterm.Models
{
    public class EnrollmentCheck : ValidationAttribute
    {
        //Limit enrollment to current year only.

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var student = (Student)validationContext.ObjectInstance;

            if (student.EnrolledDate == null)
                return new ValidationResult("Enrollment date is required.");

            return ((student.EnrolledDate.Value.Year - DateTime.Today.Year) >= 0) ? ValidationResult.Success
                : new ValidationResult("You have to be enrolled this year take courses.");
        }
    }
}