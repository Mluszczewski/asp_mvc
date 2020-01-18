using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using tech_dot_net_Mluszczewski.Models;

namespace tech_dot_net_Mluszczewski.Validation
{
    public class ClassicBookAttribute : ValidationAttribute
    {
        private int _year;

        public ClassicBookAttribute(int Year)
        {
            _year = Year;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Book book = (Book)validationContext.ObjectInstance;

            if (book.ReleasteDate.Year > _year)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

        private string GetErrorMessage()
        {
            return $"Classic books must have a release year earlier than {_year}.";
        }
    }
}
