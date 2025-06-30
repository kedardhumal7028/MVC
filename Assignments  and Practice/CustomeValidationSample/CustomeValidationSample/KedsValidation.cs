using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomeValidationSample
{
    public class KedsValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string message = value.ToString();
                if(message.Contains("Kedar"))
                {
                    return ValidationResult.Success;
                }
            }

            ErrorMessage = ErrorMessage ?? validationContext.DisplayName + "Field must contain Kedar";
            return new ValidationResult(ErrorMessage);
        }
    }
}