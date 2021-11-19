using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentMidterm.Models
{
    public class AgeCheck : ValidationAttribute
    {
        //Check to see if student is over 18.

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            var student = (Student)validationContext.ObjectInstance;

            if (student.BirthDay == null)
                return new ValidationResult("Birthdate is required.");

            var birthage = DateTime.Today.Year - student.BirthDay.Value.Year;

            return (birthage >= 18) ? ValidationResult.Success
                : new ValidationResult("You have to be 18 or older to enroll.");
        }
    }
}