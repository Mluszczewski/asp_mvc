using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using tech_dot_net_Mluszczewski.Models;

namespace tech_dot_net_Mluszczewski.Validation{
    
    public class PageNumberValidation : ValidationAttribute{
        private int _pagesNumber;

        public PageNumberValidation(int PagesNumber){
            _pagesNumber = PagesNumber;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext){
            Book book = (Book)validationContext.ObjectInstance;

            if (book.PagesNumber < _pagesNumber)
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;
        }
        private string GetErrorMessage(){
            return $"Number of book pages cannot be lower that {_pagesNumber}.";
        }
    }
}