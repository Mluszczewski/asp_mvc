using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using tech_dot_net_Mluszczewski.Models;

namespace tech_dot_net_Mluszczewski.Validation{
    public class FirstNameValidation : ValidationAttribute{
        private string _AllowedChars;

        public FirstNameValidation(string AllowedChars){
            _AllowedChars = AllowedChars;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext){
            Author author = (Author)validationContext.ObjectInstance;

            if (Regex.IsMatch(author.FirstName, _AllowedChars)){
                return ValidationResult.Success;
            }
                return new ValidationResult(GetErrorMessage());
        }
        private string GetErrorMessage(){
            return $"Passed First name is not valid. Accepted signs are ^[A-Z]+[a-z]";
        }
    }
}